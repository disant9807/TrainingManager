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
    public class GetCategoryOfBodyRequest : BaseStorageRequest<Model.CategoryOfBody[]>
    {
        private readonly string _queryString;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;

        public GetCategoryOfBodyRequest(StorageContext context, IMapper mapper, string queryString, Order? order = null, int? start = null, int? count = null) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            _queryString = queryString;
            _order = order;
            this.start = start;
            this.count = count;
            _mapper = mapper;
        }

        public override async Task<CategoryOfBody[]> ExecuteAsync()
        {
            var categoryOfBodyRequest = context.CategoryOfBody
                .Where(e => string.IsNullOrEmpty(_queryString) || e.Name.ToLower().Contains(_queryString))
                .Where(e => string.IsNullOrEmpty(_queryString) || e.Decsription.ToLower().Contains(_queryString))
                .Where(e => string.IsNullOrEmpty(_queryString) || e.Code.ToLower().Contains(_queryString));

            var categoryOfBody = categoryOfBodyRequest.AsNoTracking();
            categoryOfBody = Order(categoryOfBody);
            categoryOfBody = Take(categoryOfBody);
            return await categoryOfBody.Select(e => _mapper.Map<Domain.CategoryOfBody, Model.CategoryOfBody>(e)).ToArrayAsync();
        }

        private IQueryable<Domain.CategoryOfBody> Take(IQueryable<Domain.CategoryOfBody> categoryOfBody)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                categoryOfBody = categoryOfBody.Skip(start.Value).Take(count.Value);
            }

            return categoryOfBody;
        }

        private IQueryable<Domain.CategoryOfBody> Order(IQueryable<Domain.CategoryOfBody> categoryOfBody)
        {

            if (_order == Model.Order.Asc)
                categoryOfBody = categoryOfBody.OrderBy(e => e.Name);
            else
                categoryOfBody = categoryOfBody.OrderByDescending(e => e.Name);


            return categoryOfBody;
        }
    }
}
