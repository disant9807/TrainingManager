using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TrainingManager.Logic.Storage;
using TrainingManager.Logic.Model;
using TrainingManager.Log;
using TrainingManager.ViewModels;
using Serilog;
using System.Net;

namespace TrainingManager.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ExerciseController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;

        public ExerciseController (IStorage storage, ILogFactory logFactory)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(ExerciseController));
        }

		/// <summary>Создать упражнение</summary>
		/// <returns>Идентификатор созданного упражнения</returns>
		[HttpPost("create")]
		[ProducesResponseType(typeof(Exercise), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<long>> CreateExercise([FromBody] ExerciseVM exerciseVM)
		{
			if (exerciseVM == null)
				return BadRequest();

			var result = await _storage.CreateExercise(exerciseVM.AsExercise());
			return Ok(result);
		}

		/// <summary>Обновить упражнение</summary>
		/// <returns>Идентификатор обновленного упражнения</returns>
		[HttpPost("update")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<long>> UpdateExercise([FromBody] ExerciseVM exerciseVM)
		{
			if (exerciseVM == null)
				return BadRequest();

			await _storage.UpdateExercise(exerciseVM.AsExercise());
			return Ok(exerciseVM.Id);
		}

		/// <summary>Архивировать упражнение</summary>
		/// <returns>Идентификатор архивированного упражнения</returns>
		[HttpPost("{id}/archive/{status}")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult> ArchiveExercise([FromRoute] string id, [FromRoute] bool status = true)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			await _storage.ArchiveExercise(longId, status);
			return Ok();
		}


		[HttpGet("{id}")]
		public async Task<ActionResult<ExerciseVM>> ExerciseById([FromRoute] string id)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			var result = await _storage.GetExerciseById(longId);
			return Ok(result.AsExerciseVM());
		}

		[HttpGet]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<Exercise>>> Exercises([FromQuery] QueryParamsExerciseVM parameters)
		{
			var filter = new GetExercisesFilter()
			{
				CategoryOfBodies = parameters.categoryOfBodies,
				CreatedFrom = parameters.createdFrom,
				CreatedTo = parameters.createdTo,
				Name = parameters.name,
				IsBased = parameters.isBased,
				HardSkill = parameters.hardSkill,
				HardSkills = parameters.hardSkills
			};

			var requests = await _storage.GetExercises(filter, parameters.order, parameters.start, parameters.count);

			return Ok(requests.Select(e => e.AsExerciseVM()));
		}
	}
}
