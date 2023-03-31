using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateCategoryOfBodyCommand : BaseStorageCommand
    {
        private readonly Model.CategoryOfBody _categoryOfBody;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateCategoryOfBodyCommand(StorageContext context, Model.CategoryOfBody categoryOfBody, ILogFactory log, IMapper mapper) : base(context)
        {
            _categoryOfBody = categoryOfBody;
            _logger = log.CreateModuleLogger(typeof(UpdateCategoryOfBodyCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var categoryOfBodyCount = await context.CategoryOfBody.CountAsync(e => e.Code == _categoryOfBody.Code);

            if (categoryOfBodyCount < 1)
                throw new KeyNotFoundException($"Часть тела с id = {_categoryOfBody.Code} не найден");

            var categoryOfBody = _mapper.Map<Model.CategoryOfBody, Domain.CategoryOfBody>(_categoryOfBody);

            context.CategoryOfBody.Update(categoryOfBody);
            await context.SaveChangesAsync();
        }
    }
}
