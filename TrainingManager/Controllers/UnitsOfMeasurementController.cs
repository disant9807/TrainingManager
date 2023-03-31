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
    public class UnitsOfMeasurementController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
        private readonly IMapper _mapper;

        public UnitsOfMeasurementController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(UnitsOfMeasurementController));
            _mapper = mapper;
        }


		[HttpPost("create")]
        [ProducesResponseType(typeof(Goal), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CreateGoal([FromBody] UnitsOfMeasurementVM unitsOfMeasurementVM)
        {
            if (unitsOfMeasurementVM == null)
                return BadRequest();

            var unitsOfMeasurement = _mapper.Map<UnitsOfMeasurementVM, UnitsOfMeasurement>(unitsOfMeasurementVM);

            var result = await _storage.CreateUnitsOfMeasurement(unitsOfMeasurement);
            return Ok(result);
        }


		[HttpPost("update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<string>> UpdateUnitsOfMeasurement([FromBody] UnitsOfMeasurementVM unitsOfMeasurementVM)
        {
            if (unitsOfMeasurementVM == null)
                return BadRequest();

            var unitsOfMeasurement = _mapper.Map<UnitsOfMeasurementVM, UnitsOfMeasurement>(unitsOfMeasurementVM);

            await _storage.UpdateUnitsOfMeasurementy(unitsOfMeasurement);
            return Ok(unitsOfMeasurementVM.Code);
        }


		[HttpPost("unitsOfmeasuremen/{code}/remove")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveUnitsOfMeasurementById([FromRoute] string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return BadRequest();

            await _storage.RemoveUnitsOfMeasurement(code, true);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnitsOfMeasurementVM>> UnitsOfMeasurementById([FromRoute] string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return BadRequest();

            var result = await _storage.GetUnitsOfMeasurementById(code);

            var unitsOfMeasurement = _mapper.Map<UnitsOfMeasurement, UnitsOfMeasurementVM>(result);

            return Ok(unitsOfMeasurement);
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<UnitsOfMeasurementVM>>> Sizes([FromQuery] QueryParamsUnitsOfMeasurementVM parameters)
        {
            var requests = await _storage.GetUnitsOfMeasurement(parameters.QueryString, parameters.order, parameters.start, parameters.count);

            return Ok(requests.Select(e => _mapper.Map<UnitsOfMeasurement, UnitsOfMeasurementVM>(e)));
        }
    }
}
