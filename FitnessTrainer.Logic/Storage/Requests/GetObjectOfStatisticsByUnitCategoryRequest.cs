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
    public class GetObjectOfStatisticsByUnitCategoryRequest : BaseStorageRequest<Model.ObjectOfStatistics>
    {
        private readonly string _categoryCode;
        private readonly string _unitCode;
        private readonly IMapper _mapper;

        public GetObjectOfStatisticsByUnitCategoryRequest(StorageContext context, IMapper mapper, string categoryCode, string unitCode) : base(context)
        {
            _mapper = mapper;
            _categoryCode = categoryCode;
            _unitCode = unitCode; 
        }

        public override async Task<Model.ObjectOfStatistics> ExecuteAsync()
        {
            var statisticsRequest = await context.ObjectOfStatistics
                .Where(e => e.CategoryCode == _categoryCode)
                .Where(e => e.UnitCode == _unitCode)
                .FirstOrDefaultAsync();

            if (statisticsRequest is null)
                throw new ArgumentNullException(nameof(statisticsRequest), $"Ошибка при получении части тела по {_unitCode} и {_categoryCode}");

            var result = _mapper.Map<Domain.ObjectOfStatistics, Model.ObjectOfStatistics>(statisticsRequest);

            return result;
        }
    }
}
