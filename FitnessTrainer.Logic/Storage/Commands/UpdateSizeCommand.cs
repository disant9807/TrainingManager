using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateSizeCommand : BaseStorageCommand
    {
        private readonly Model.Size _size;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateSizeCommand(StorageContext context, Model.Size size, ILogFactory log, IMapper mapper) : base(context)
        {
            _size = size;
            _logger = log.CreateModuleLogger(typeof(UpdateSizeCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {        
            var size = await context.Size.Where(e => e.Id == _size.Id).FirstOrDefaultAsync();

            if (size == null )
                throw new KeyNotFoundException($"Размер с id = {_size.Id} не найден");

            size.CreatedDate = _size.CreatedDate;

            context.Size.Update(size);
            await context.SaveChangesAsync();

            foreach(var sizeItem in size.SizeItems.ToArray())
            {
                context.Entry<Domain.SizeItem>(sizeItem).State = EntityState.Detached;
            }

            var deleteSizeItem = size.SizeItems.Where(e => !_size.SizeItems.Any(z => z.Id == e.Id));
            var addSizeItemModel = _size.SizeItems.Where(e => !size.SizeItems.Any(z => z.Id == e.Id));
            var editSizeItemModel = _size.SizeItems.Where(e => size.SizeItems.Any(z => z.Id == e.Id));

            foreach (var sizeItem in deleteSizeItem)
            {
                size.SizeItems.Remove(sizeItem);
                context.SizeItem.Remove(sizeItem);
                await context.SaveChangesAsync();
            }
            foreach(var sizeItemModel in addSizeItemModel)
            {
                var sizeItem = _mapper.Map<Model.SizeItem, Domain.SizeItem>(sizeItemModel);
                size.SizeItems.Add(sizeItem);
                await context.SaveChangesAsync();

                foreach (var sizeitemFor in size.SizeItems.ToArray())
                {
                    context.Entry<Domain.SizeItem>(sizeitemFor).State = EntityState.Detached;
                }

            }
            foreach (var sizeItemModel in editSizeItemModel)
            {
                var sizeItem = _mapper.Map<Model.SizeItem, Domain.SizeItem>(sizeItemModel);
                sizeItem.SizeId = size.Id;

                context.SizeItem.Attach(sizeItem);
                context.SizeItem.Update(sizeItem);
                
                
                await context.SaveChangesAsync();

                foreach (var sizeitemFor in size.SizeItems.ToArray())
                {
                    context.Entry<Domain.SizeItem>(sizeitemFor).State = EntityState.Detached;
                }
            }
        }
    }
}
