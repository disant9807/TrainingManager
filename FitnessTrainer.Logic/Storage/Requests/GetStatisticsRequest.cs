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
    public class GetStatisticsRequest : BaseStorageRequest<Model.StatisticsIndicator[]>
    {
        private readonly GetStatisticsFilter filter;
        private readonly IMapper _mapper;

        public GetStatisticsRequest(StorageContext context, IMapper mapper, GetStatisticsFilter filter) : base(context)
        {
            this.filter = filter;
            _mapper = mapper;
        }

        public override async Task<StatisticsIndicator[]> ExecuteAsync()
        {
            var statisticsRequest = context.GetFiltredStatistics(filter);
            var statistics = statisticsRequest.AsNoTracking();

            return await statistics.Select(e => e.AsStatistics(_mapper)).ToArrayAsync();
        }
    }
}
