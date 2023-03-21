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
    public class GetSizeByIdRequest : BaseStorageRequest<Model.Size>
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly IMapper _mapper;

        public GetSizeByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, long id) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetTrainingByIdRequest));
            _id = id;
            _mapper = mapper;
        }

        public override async Task<Model.Size> ExecuteAsync()
        {
            var data = await context.Size
                .Where(e => e.Id == _id)
                .Include(e => e.SizeItems)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении замера по id {_id}");

            var result = _mapper.Map<Domain.Size, Model.Size>(data);
            return result;
        }
    }
}
