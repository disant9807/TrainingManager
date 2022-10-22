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
		public async Task<ActionResult> ArchiveExercise([FromQuery] string id, [FromQuery] bool status = true)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || long.TryParse(id, out longId))
				return BadRequest();

			await _storage.ArchiveExercise(longId, status);
			return Ok();
		}


		[HttpGet("{id}")]
		public async Task<ActionResult<Exercise>> ExerciseById([FromQuery] string id)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || long.TryParse(id, out longId))
				return BadRequest();

			var result = await _storage.GetExerciseById(longId);
			return Ok(result);
		}

		[HttpGet]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<Exercise>>> Exercises(
			[FromQuery(Name = "categoryOfBodies[]")] string[] categoryOfBodies,
            [FromQuery]string name,
            [FromQuery]DateTime? createdFrom,
            [FromQuery]DateTime? createdTo,
            [FromQuery]bool? isBased,
			[FromQuery(Name = "hardSkills[]")] HardSkill[] hardSkills,
            [FromQuery] HardSkill hardSkill,
            [FromQuery] Order order,
            [FromQuery] int start = 0,
            [FromQuery] int count = 0
			)
		{
			var filter = new GetExercisesFilter()
			{
				CategoryOfBodies = categoryOfBodies,
				CreatedFrom = createdFrom,
				CreatedTo = createdTo,
				Name = name,
				IsBased = isBased,
				HardSkill = hardSkill,
				HardSkills = hardSkills
			};

			var requests = await _storage.GetExercises(filter, order, start, count);

			return Ok(requests);
		}
	}
}
