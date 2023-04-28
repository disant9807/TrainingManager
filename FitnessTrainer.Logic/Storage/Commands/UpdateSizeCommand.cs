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
using TrainingManager.Logic.Model;

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
            var size = await context.Size
                .Where(e => e.Id == _size.Id)
                .Include(e => e.SizeItems)
                .FirstOrDefaultAsync();

            if (size == null)
                throw new KeyNotFoundException($"Цель с id = {_size.Id} не найдена");

            size.Name = _size.Name;

            var deleteSizeItems = size.SizeItems.Where(e => !_size.SizeItems.Any(z => z.Id == e.Id));
            var addSizeItems = _size.SizeItems.Where(e => !size.SizeItems.Any(z => z.Id == e.Id));
            var editSizeItems = size.SizeItems.Where(e => _size.SizeItems.Any(z => z.Id == e.Id));

            foreach (var sizeItem in deleteSizeItems)
            {
                context.SizeItem.Remove(sizeItem);
            }

            foreach (var sizeItemModel in addSizeItems)
            {
                var sizeItem = new Domain.SizeItem();
                sizeItem.Value = sizeItemModel.Value;
                sizeItem.BodyCode = sizeItemModel.BodyCode;
                sizeItem.CodeUnitsOfMeasurement = sizeItemModel.CodeUnitsOfMeasurement;

                size.SizeItems.Add(sizeItem);
            }

            foreach (var sizeItem in editSizeItems)
            {
                var updatedSizeIteml = _size.SizeItems
                    .FirstOrDefault(e => e.Id == sizeItem.Id);

                sizeItem.Value = updatedSizeIteml.Value;
                sizeItem.BodyCode = updatedSizeIteml.BodyCode;
                sizeItem.CodeUnitsOfMeasurement = updatedSizeIteml.CodeUnitsOfMeasurement;
            }

            context.Size.Update(size);
            await context.SaveChangesAsync();
        }
    }
}
