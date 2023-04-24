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
    public class GetObjectsOfStatisticsRequest : BaseStorageRequest<Model.ObjectOfStatistics[]>
    {
        private readonly string _userId;
        private readonly IMapper _mapper;

        public GetObjectsOfStatisticsRequest(StorageContext context, IMapper mapper, string userId) : base(context)
        {
            this._userId = userId;
            _mapper = mapper;
        }

        public override async Task<ObjectOfStatistics[]> ExecuteAsync()
        {
            var statisticsRequest = context.GetFiltredObjectOfStatistics(_userId);
            var statistics = statisticsRequest.AsNoTracking();

            return await statistics.Select(e => e.AsStatistics(_mapper)).ToArrayAsync();
        }
    }
}
