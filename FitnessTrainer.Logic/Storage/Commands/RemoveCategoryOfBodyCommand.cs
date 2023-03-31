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
    public class RemoveCategoryOfBodyCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly string _code;

        public RemoveCategoryOfBodyCommand(StorageContext context, ILogFactory log, string code) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(RemoveCategoryOfBodyCommand));
            _code = code;
        }

        public async override Task ExecuteAsync()
        {
            var categortOfBody = await context.CategoryOfBody.Where(e => e.Code == _code)
                .SingleOrDefaultAsync();

            if (categortOfBody == null)
                throw new KeyNotFoundException($"Часть тела с id = {_code} не найдена");

            context.CategoryOfBody.Remove(categortOfBody);
            await context.SaveChangesAsync();
        }
    }
}
