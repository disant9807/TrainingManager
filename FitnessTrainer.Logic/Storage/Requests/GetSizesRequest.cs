﻿using System;
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
    public class GetSizesRequest : BaseStorageRequest<Model.Size[]>
    {
        private readonly GetSizesFilter filter;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;
        private readonly string _userId;
        private readonly bool? _isEveryone;

        public GetSizesRequest(StorageContext context, IMapper mapper, GetSizesFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            this.filter = filter;
            _order = order;
            this.start = start;
            this.count = count;
            _mapper = mapper;
            this._userId = userId;
            this._isEveryone = isEveryone;
        }

        public override async Task<Size[]> ExecuteAsync()
        {
            var sizeRequest = context.GetFiltredSizes(filter)
                .Where(e => (_isEveryone == true && e.IsEveryone == true) || (e.UserId == _userId))
                .Where(e => !e.IsArchived);

            var size = sizeRequest.AsNoTracking();
            size = Order(size);
            size = Take(size);
            return await size.Select(e => e.AsSize(_mapper)).ToArrayAsync();
        }

        private IQueryable<Domain.Size> Take(IQueryable<Domain.Size> sizes)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                sizes = sizes.Skip(start.Value).Take(count.Value);
            }

            return sizes;
        }

        private IQueryable<Domain.Size> Order(IQueryable<Domain.Size> sizes)
        {

            if (_order == Model.Order.Asc)
                sizes = sizes.OrderBy(e => e.CreatedDate);
            else
                sizes = sizes.OrderByDescending(e => e.CreatedDate);


            return sizes;
        }
    }
}
