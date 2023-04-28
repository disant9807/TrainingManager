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
    public class GetGenStatisticsByDateRequest : BaseStorageRequest<bool>
    {
        private readonly DateTime _date;
        private readonly string _userId;
        private readonly string _category;
        private readonly IMapper _mapper;

        public GetGenStatisticsByDateRequest(StorageContext context, IMapper mapper, DateTime date, string userId, string category) : base(context)
        {
            _mapper = mapper;
            _date = date;
            _userId = userId;
            _category = category;
        }

        public override async Task<bool> ExecuteAsync()
        {
            var result = await context.GenStatistics
                .Where(e => e.UserId == _userId)
                .Where(e => e.CategoryCode == _category)
                .Where(e => e.GeneratedTime.Date == _date.Date)
                .CountAsync();

            return result > 0;
        }
    }
}
