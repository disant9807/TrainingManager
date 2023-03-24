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
    public class GoalController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
        private readonly IMapper _mapper;

        public GoalController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(GoalController));
            _mapper = mapper;
        }

        /// <summary>Создать замер</summary>
		/// <returns>Идентификатор созданного замера</returns>
		[HttpPost("create")]
        [ProducesResponseType(typeof(Goal), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> CreateGoal([FromBody] GoalVM goalVm)
        {
            if (goalVm == null)
                return BadRequest();

            var goal = _mapper.Map<GoalVM, Goal>(goalVm);

            var result = await _storage.CreateGoal(goal);
            return Ok(result);
        }

        /// <summary>Обновить замер</summary>
		/// <returns>Идентификатор обновленного замера</returns>
		[HttpPost("update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<long>> UpdateGoal([FromBody] GoalVM goalVM)
        {
            if (goalVM == null)
                return BadRequest();

            var goal = _mapper.Map<GoalVM, Goal>(goalVM);

            await _storage.UpdateGoal(goal);
            return Ok(goalVM.Id);
        }

        /// <summary>Архивировать замер</summary>
		/// <returns>Идентификатор архивированного замера</returns>
		[HttpPost("{id}/goal/{status}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ArchiveGoal([FromRoute] string id, [FromRoute] bool status = true)
        {
            long longId;
            if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
                return BadRequest();

            await _storage.ArchiveGoal(longId, status);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GoalVM>> GoalById([FromRoute] string id)
        {
            long longId;
            if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
                return BadRequest();

            var result = await _storage.GetGoalById(longId);

            var goal = _mapper.Map<Goal, GoalVM>(result);

            return Ok(goal);
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<GoalVM>>> Sizes([FromQuery] QueryParamsGoalVM parameters)
        {
            var filter = _mapper.Map<QueryParamsGoalVM, GetGoalsFilter>(parameters);

            var requests = await _storage.GetGoals(filter, parameters.order, parameters.start, parameters.count);

            return Ok(requests.Select(e => _mapper.Map<Goal, GoalVM>(e)));
        }
    }
}
