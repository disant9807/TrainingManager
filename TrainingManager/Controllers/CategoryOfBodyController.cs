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
    public class CategoryOfBodyController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
        private readonly IMapper _mapper;

        public CategoryOfBodyController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(CategoryOfBodyController));
            _mapper = mapper;
        }


		[HttpPost("create")]
        [ProducesResponseType(typeof(Goal), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CreateCategoryOfBody([FromBody] CategoryOfBodyVM categoryOfBodyVM)
        {
            if (categoryOfBodyVM == null)
                return BadRequest();

            var categoryOfBody = _mapper.Map<CategoryOfBodyVM, CategoryOfBody>(categoryOfBodyVM);

            var result = await _storage.CreateCategoryOfBody(categoryOfBody);
            return Ok(result);
        }


		[HttpPost("update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<string>> UpdateCategoryOfBody([FromBody] CategoryOfBodyVM categoryOfBodyVM)
        {
            if (categoryOfBodyVM == null)
                return BadRequest();

            var categoryOfBody = _mapper.Map<CategoryOfBodyVM, CategoryOfBody>(categoryOfBodyVM);

            await _storage.UpdateCategoryOfBody(categoryOfBody);
            return Ok(categoryOfBodyVM.Code);
        }


		[HttpPost("categoryOfBody/{code}/remove")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveCategoryOfBodyById([FromRoute] string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return BadRequest();

            await _storage.RemoveCategoryOfBody(code, true);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryOfBodyVM>> CategoryOfBodyById([FromRoute] string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return BadRequest();

            var result = await _storage.GetCategoryOfBodyById(code);

            var unitsOfMeasurement = _mapper.Map<CategoryOfBody, CategoryOfBodyVM>(result);

            return Ok(unitsOfMeasurement);
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<CategoryOfBodyVM>>> CategoryOfBodies([FromQuery] QueryParamsCategoryOfBodyVM parameters)
        {
            var requests = await _storage.GetCategoryOfBody(parameters.QueryString, parameters.order, parameters.start, parameters.count);

            return Ok(requests.Select(e => _mapper.Map<CategoryOfBody, CategoryOfBodyVM>(e)));
        }
    }
}
