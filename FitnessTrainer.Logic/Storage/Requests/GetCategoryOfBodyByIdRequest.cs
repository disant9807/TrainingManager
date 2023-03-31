using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Requests
{
    public class GetCategoryOfBodyByIdRequest : BaseStorageRequest<Model.CategoryOfBody>
    {
        private readonly ILogger _logger;
        private readonly string _code;
        private readonly IMapper _mapper;

        public GetCategoryOfBodyByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, string code) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetCategoryOfBodyByIdRequest));
            _code = code;
            _mapper = mapper;
        }

        public override async Task<Model.CategoryOfBody> ExecuteAsync()
        {
            var data = await context.CategoryOfBody
                .Where(e => e.Code == _code)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении части тела по id {_code}");

            var result = _mapper.Map<Domain.CategoryOfBody, Model.CategoryOfBody>(data);
            return result;
        }
    }
}
