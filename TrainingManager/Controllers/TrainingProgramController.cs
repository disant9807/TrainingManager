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
	public class TrainingProgramController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
		private readonly IMapper _mapper;

		public TrainingProgramController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(TrainingProgramController));
			_mapper = mapper;
        }

		/// <summary>Создать тренировку</summary>
		/// <returns>Идентификатор созданной тренировки</returns>
		[HttpPost("create")]
		[ProducesResponseType(typeof(TrainingProgramVM), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<long>> CreateTrainingProgram([FromBody] TrainingProgramVM trainingProgramVM)
		{
			if (trainingProgramVM == null)
				return BadRequest();

			var trainingProgram = _mapper.Map<TrainingProgramVM, TrainingProgram>(trainingProgramVM);

			var result = await _storage.CreateTrainingProgram(trainingProgram);
			return Ok(result);
		}

		/// <summary>Обновить упражнение</summary>
		/// <returns>Идентификатор обновленного упражнения</returns>
		[HttpPost("update")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<long>> UpdateTraining([FromBody] TrainingProgramVM trainingProgramVM)
		{
			if (trainingProgramVM == null)
				return BadRequest();

			var trainingProgram = _mapper.Map<TrainingProgramVM, TrainingProgram>(trainingProgramVM);

			await _storage.UpdateTrainingProgram(trainingProgram);
			return Ok(trainingProgram.Id);
		}

		/// <summary>Архивировать упражнение</summary>
		/// <returns>Идентификатор архивированного упражнения</returns>
		[HttpPost("{id}/archive/{status}")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult> ArchiveTrainingProgram([FromRoute] string id, [FromRoute] bool status = true)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			await _storage.ArchiveTrainingProgram(longId, status);
			return Ok();
		}


		[HttpGet("{id}")]
		public async Task<ActionResult<TrainingVM>> TrainingProgramById([FromRoute] string id)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			var result = await _storage.GetTrainingProgramById(longId);

			var trainingProgram = _mapper.Map<TrainingProgram, TrainingProgramVM>(result);

			return Ok(trainingProgram);
		}

		[HttpGet("get/{userId}")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<Exercise>>> TrainingPrograms([FromRoute] string userId, [FromQuery] QueryParamsTrainingProgramVM parameters)
		{
			var filter = _mapper.Map<QueryParamsTrainingProgramVM, GetTrainingProgramsFilter>(parameters);

			var requests = await _storage.GetTrainingPrograms(filter, userId, true, parameters.order, parameters.start, parameters.count);

			return Ok(requests.Select(e => _mapper.Map<TrainingProgram, TrainingProgramVM>(e)));
		}
	}
}
