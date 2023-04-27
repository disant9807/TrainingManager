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
    public class GetGenStatisticsByCategoryRequest : BaseStorageRequest<Model.GenStatistics[]>
    {
        private readonly string _categoryCode;
        private readonly IMapper _mapper;
        private readonly string _userId;

        public GetGenStatisticsByCategoryRequest(StorageContext context, IMapper mapper, string categoryCode, string userId) : base(context)
        {
            _mapper = mapper;
            _categoryCode = categoryCode;
            _userId = userId;
        }

        public override async Task<Model.GenStatistics[]> ExecuteAsync()
        {
            var statisticsRequest = await context.GenStatistics
                .Where(e => e.CategoryCode == _categoryCode)
                .Where(e => e.UserId == _userId)
                .OrderByDescending(e => e.GeneratedTime)
                .ToListAsync();

            if (statisticsRequest is null)
                throw new ArgumentNullException(nameof(statisticsRequest), $"Ошибка при получении части тела по {_categoryCode}");

            var result = statisticsRequest.Select(e => _mapper.Map<Domain.GenStatistics, Model.GenStatistics>(e)).ToArray();

            return result;
        }
    }
}
