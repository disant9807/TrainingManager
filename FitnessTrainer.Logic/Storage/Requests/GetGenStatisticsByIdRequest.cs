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
    public class GetGenStatisticsByIdRequest : BaseStorageRequest<Model.GenStatistics>
    {
        private readonly Guid _id;
        private readonly IMapper _mapper;

        public GetGenStatisticsByIdRequest(StorageContext context, IMapper mapper, Guid id) : base(context)
        {
            _mapper = mapper;
            _id = id;
        }

        public override async Task<GenStatistics> ExecuteAsync()
        {
            var statisticsRequest = await context.GenStatistics
                .Where(e => e.Id == _id)
                .Include(e => e.Statistics)
                .ThenInclude(e => e.StatisticsIndicators)
                .FirstOrDefaultAsync();

            if (statisticsRequest is null)
                throw new ArgumentNullException(nameof(statisticsRequest), $"Ошибка при получении части тела по {statisticsRequest}");

            var result = _mapper.Map<Domain.GenStatistics, Model.GenStatistics>(statisticsRequest);

            return result;
        }
    }
}
