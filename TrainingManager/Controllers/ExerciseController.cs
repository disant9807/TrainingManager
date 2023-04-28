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
using AutoMapper;

namespace TrainingManager.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ExerciseController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
		private readonly IMapper _mapper;

        public ExerciseController (IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(ExerciseController));
			_mapper = mapper;
        }

		/// <summary>Создать упражнение</summary>
		/// <returns>Идентификатор созданного упражнения</returns>
		[HttpPost("create")]
		[ProducesResponseType(typeof(Exercise), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<long>> CreateExercise([FromBody] ExerciseVM exerciseVM)
		{
			if (exerciseVM == null)
				return BadRequest();

			var exercise = _mapper.Map<ExerciseVM, Exercise>(exerciseVM);

			var result = await _storage.CreateExercise(exercise);
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

			var exercise = _mapper.Map<ExerciseVM, Exercise>(exerciseVM);

			await _storage.UpdateExercise(exercise);
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

			var exercise = _mapper.Map<Exercise, ExerciseVM>(result);

			return Ok(exercise);
		}

		[HttpGet("get/{userId}")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<Exercise>>> Exercises([FromRoute] string userId, [FromQuery] QueryParamsExerciseVM parameters)
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

			var requests = await _storage.GetExercises(filter, userId, true, parameters.order, parameters.start, parameters.count);

			return Ok(requests.Select(e => _mapper.Map<Exercise, ExerciseVM>(e)));
		}
	}
}
