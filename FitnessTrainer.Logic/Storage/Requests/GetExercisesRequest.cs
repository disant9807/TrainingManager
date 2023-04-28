using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;
using TrainingManager.Logic.Storage.Extensions;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Requests
{
    public class GetExercisesRequest : BaseStorageRequest<Model.Exercise[]>
    {
        private readonly GetExercisesFilter filter;
        private readonly string _userId;
        private readonly bool? _isEveryone;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;

        public GetExercisesRequest(StorageContext context, GetExercisesFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            this.filter = filter;
            _order = order;
            this.start = start;
            this.count = count;
            _userId = userId;
            _isEveryone = isEveryone;
        }

        public override async Task<Exercise[]> ExecuteAsync()
        {
            var exercisesRequest = context.GetFiltredExercises(filter)
                .Where(e => (_isEveryone == true && e.IsEveryone == true) || (e.UserId == _userId));

            var exercises = exercisesRequest
                .Include(e => e.CategoryOfBodies)
                .Include(e => e.Images)
                .AsNoTracking();
            exercises = Order(exercises);
            exercises = Take(exercises);
            return await exercises.Select(e => e.AsExercise()).ToArrayAsync();
        }

        private IQueryable<Domain.Exercise> Take(IQueryable<Domain.Exercise> exercises)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                exercises = exercises.Skip(start.Value).Take(count.Value);
            }

            return exercises;
        }

        private IQueryable<Domain.Exercise> Order(IQueryable<Domain.Exercise> exercises)
        {

            if (_order == Model.Order.Asc)
                exercises = exercises.OrderBy(e => e.CreatedDate);
            else
                exercises = exercises.OrderByDescending(e => e.CreatedDate);
            

            return exercises;
        }
    }
}
