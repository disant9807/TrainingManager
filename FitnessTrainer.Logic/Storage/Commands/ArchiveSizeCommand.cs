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
    public class ArchiveSizeCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly bool _isArchive;

        public ArchiveSizeCommand(StorageContext context, ILogFactory log, long id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveSizeCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var size = await context.Size.Where(e => e.Id == _id)
                .SingleOrDefaultAsync();

            if (size == null)
                throw new KeyNotFoundException($"Замер с id = {_id} не найден");

            if (size.IsEveryone)
                throw new MethodAccessException();

            size.IsArchived = _isArchive;

            context.Size.Update(size);
            await context.SaveChangesAsync();
        }
    }
}
