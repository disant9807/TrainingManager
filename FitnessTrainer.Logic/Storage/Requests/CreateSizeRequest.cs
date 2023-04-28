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
    public class CreateSizeRequest : BaseStorageRequest<long>
    {
        private readonly Model.Size _size;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateSizeRequest(StorageContext context, Model.Size size, ILogFactory log, IMapper mapper) : base(context)
        {
            if (size is null) throw new ArgumentNullException();
            _size = size;
            _logger = log.CreateModuleLogger(typeof(CreateSizeRequest));
            _mapper = mapper;
        }

        public override async Task<long> ExecuteAsync()
        {
            var size = new Domain.Size();

            size.CreatedDate = DateTime.Now;
            size.Name = _size.Name;
            size.IsArchived = false;
            size.UserId = _size.UserId;
            size.IsEveryone = false;

            _size.SizeItems.ToList().ForEach(e =>
            {
                var sizeItem = new Domain.SizeItem();
                sizeItem.Value = e.Value;
                sizeItem.BodyCode = e.BodyCode;
                sizeItem.CodeUnitsOfMeasurement = e.CodeUnitsOfMeasurement;

                size.SizeItems.Add(sizeItem);
            });

            context.Size.Add(size);
            await context.SaveChangesAsync();

            return size.Id;
        }
    }
}