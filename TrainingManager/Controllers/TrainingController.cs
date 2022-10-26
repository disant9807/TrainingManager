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
	public class TrainingController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;

        public TrainingController(IStorage storage, ILogFactory logFactory)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(ExerciseController));
        }

		/// <summary>Создать тренировку</summary>
		/// <returns>Идентификатор созданной тренировки</returns>
		[HttpPost("create")]
		[ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<long>> CreateExercise([FromBody] TrainingVM trainingVM)
		{
			if (trainingVM == null)
				return BadRequest();

			var result = await _storage.CreateTraining(trainingVM.AsTraining());
			return Ok(result);
		}

		/// <summary>Обновить упражнение</summary>
		/// <returns>Идентификатор обновленного упражнения</returns>
		[HttpPost("update")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<long>> UpdateTraining([FromBody] TrainingVM trainingVM)
		{
			if (trainingVM == null)
				return BadRequest();

			await _storage.UpdateTraining(trainingVM.AsTraining());
			return Ok(trainingVM.Id);
		}

		/// <summary>Архивировать упражнение</summary>
		/// <returns>Идентификатор архивированного упражнения</returns>
		[HttpPost("{id}/archive/{status}")]
		[ProducesDefaultResponseType]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult> ArchiveTraining([FromRoute] string id, [FromRoute] bool status = true)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			await _storage.ArchiveTraining(longId, status);
			return Ok();
		}


		[HttpGet("{id}")]
		public async Task<ActionResult<Training>> TrainingById([FromRoute] string id)
		{
			long longId;
			if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
				return BadRequest();

			var result = await _storage.GetTrainingById(longId);
			return Ok(result);
		}
	}
}
