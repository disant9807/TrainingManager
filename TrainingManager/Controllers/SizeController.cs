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
    public class SizeController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
        private readonly IMapper _mapper;

        public SizeController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(SizeController));
            _mapper = mapper;
        }

        /// <summary>Создать замер</summary>
		/// <returns>Идентификатор созданного замера</returns>
		[HttpPost("create")]
        [ProducesResponseType(typeof(Size), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> CreateSize([FromBody] SizeVM sizeVm)
        {
            if (sizeVm == null)
                return BadRequest();

            var size = _mapper.Map<SizeVM, Size>(sizeVm);

            var result = await _storage.CreateSize(size);
            return Ok(result);
        }

        /// <summary>Обновить замер</summary>
		/// <returns>Идентификатор обновленного замера</returns>
		[HttpPost("update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<long>> UpdateSize([FromBody] SizeVM sizeVm)
        {
            if (sizeVm == null)
                return BadRequest();

            var size = _mapper.Map<SizeVM, Size>(sizeVm);

            await _storage.UpdateSize(size);
            return Ok(sizeVm.Id);
        }

        /// <summary>Архивировать замер</summary>
		/// <returns>Идентификатор архивированного замера</returns>
		[HttpPost("{id}/size/{status}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ArchiveSize([FromRoute] string id, [FromRoute] bool status = true)
        {
            long longId;
            if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
                return BadRequest();

            await _storage.ArchiveSize(longId, status);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SizeVM>> SizeById([FromRoute] string id)
        {
            long longId;
            if (string.IsNullOrWhiteSpace(id) || !long.TryParse(id, out longId))
                return BadRequest();

            var result = await _storage.GetSizeById(longId);

            var exercise = _mapper.Map<Size, SizeVM>(result);

            return Ok(exercise);
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<SizeVM>>> Sizes([FromQuery] QueryParamsSizeVM parameters)
        {
            var filter = _mapper.Map<QueryParamsSizeVM, GetSizesFilter>(parameters);

            var requests = await _storage.GetSizes(filter, parameters.order, parameters.start, parameters.count);

            return Ok(requests.Select(e => _mapper.Map<Size, SizeVM>(e)));
        }
    }
}
