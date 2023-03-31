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
    public class CreateCategoryOfBodyRequest : BaseStorageRequest<string>
    {
        private readonly Model.CategoryOfBody _categoryOfBody;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateCategoryOfBodyRequest(StorageContext context, Model.CategoryOfBody categoryOfBody, ILogFactory log, IMapper mapper) : base(context)
        {
            _categoryOfBody = categoryOfBody;
            _logger = log.CreateModuleLogger(typeof(CreateExerciseRequest));
            _mapper = mapper;
        }

        public override async Task<string> ExecuteAsync()
        {
            if (_categoryOfBody == null)
                throw new ArgumentNullException($"Ошибка в {_categoryOfBody}");

            var categoryOfBody = _mapper.Map<Model.CategoryOfBody, Domain.CategoryOfBody>(_categoryOfBody);
           
            context.CategoryOfBody.Add(categoryOfBody);
            await context.SaveChangesAsync();
            return categoryOfBody.Code;
        }
    }
}
