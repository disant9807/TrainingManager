using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;
using TrainingManager.Logic.Storage.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TrainingManager.Logic.Storage.Requests
{
    public class GetObjectOfStatisticsByIdRequest : BaseStorageRequest<Model.ObjectOfStatistics>
    {
        private readonly Guid _objectOfStatisticsCode;
        private readonly IMapper _mapper;

        public GetObjectOfStatisticsByIdRequest(StorageContext context, IMapper mapper, Guid objectOfStatisticsCode) : base(context)
        {
            _objectOfStatisticsCode = objectOfStatisticsCode;
            _mapper = mapper;
        }

        public override async Task<Model.ObjectOfStatistics> ExecuteAsync()
        {
            var statisticsRequest = await context.ObjectOfStatistics
                .Include(e => e.StatisticsIndicators)
                .FirstOrDefaultAsync(e => e.Id == _objectOfStatisticsCode);

            if (statisticsRequest is null)
                throw new ArgumentNullException(nameof(statisticsRequest), $"Ошибка при получении части тела по id {_objectOfStatisticsCode}");

            var result = _mapper.Map<Domain.ObjectOfStatistics, Model.ObjectOfStatistics>(statisticsRequest);

            return result;
        }
    }
}
