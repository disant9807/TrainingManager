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
            var size = _mapper.Map<Model.Size, Domain.Size>(_size);

            size.CreatedDate = DateTime.Now;
            context.Size.Add(size);
            await context.SaveChangesAsync();
            return size.Id;
        }
    }
}