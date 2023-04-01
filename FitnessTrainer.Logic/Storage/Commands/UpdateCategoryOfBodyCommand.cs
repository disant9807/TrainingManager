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
        private readonly string _code;

        public UpdateCategoryOfBodyCommand(StorageContext context, Model.CategoryOfBody categoryOfBody, string code, ILogFactory log, IMapper mapper) : base(context)
        {
            _categoryOfBody = categoryOfBody;
            _logger = log.CreateModuleLogger(typeof(UpdateCategoryOfBodyCommand));
            _mapper = mapper;
            _code = code;
        }

        public async override Task ExecuteAsync()
        {
            var categoryOfBody = await context.CategoryOfBody.FirstOrDefaultAsync(e => e.Code == _code);

            if (categoryOfBody == null)
                throw new KeyNotFoundException($"Часть тела с code = {_code} не найден");

            if (_code == _categoryOfBody.Code)
            {
                categoryOfBody.Name = _categoryOfBody.Name;
                categoryOfBody.ShortName = _categoryOfBody.ShortName;
                categoryOfBody.Decsription = _categoryOfBody.Decsription;
                
                context.CategoryOfBody.Update(categoryOfBody);
            }
            else
            {
                context.CategoryOfBody.Remove(categoryOfBody);

                var newCategoryOfBody = _mapper.Map<Model.CategoryOfBody, Domain.CategoryOfBody>(_categoryOfBody);
                context.CategoryOfBody.Add(newCategoryOfBody);
            }

            await context.SaveChangesAsync();
        }
    }
}
