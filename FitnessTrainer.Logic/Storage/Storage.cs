using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Storage.Requests;
using TrainingManager.Logic.Storage.Commands;
using Microsoft.EntityFrameworkCore;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Storage
{
    public class Storage: IStorage
    {
		protected readonly ILogFactory _logFactory;
		private readonly IMapper _mapper;
		private readonly IDbContextFactory<StorageContext> _contextFactory;

		public Storage(ILogFactory logFactory, IMapper mapper, IDbContextFactory<StorageContext> contextFactory)
        {
            _logFactory = logFactory;
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

		public Task<Exercise[]> GetExercises(GetExercisesFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetExercisesRequest(u, filter, order, start, count));

		public Task<Exercise> GetExerciseById(long id)
			=> Execute((u) => new GetExerciseByIdRequest(u, _logFactory, _mapper, id));

		public Task<long> CreateExercise(Exercise exercise)
			=> Execute((u) => new CreateExerciseRequest(u, exercise, _logFactory, _mapper));

		public Task UpdateExercise(Exercise exercise)
			=> Execute((u) => new UpdateExerciseCommand(u, exercise, _logFactory, _mapper));

		public Task ArchiveExercise(long id, bool isArchive)
			=> Execute((u) => new ArchiveExerciseCommand(u, _logFactory, id, isArchive));

		protected virtual async Task Execute(Func<StorageContext, BaseStorageCommand> command)
		{
			using var context = _contextFactory.CreateDbContext();
			// Ожидание для сохранения контекста
			await command(context).ExecuteAsync();
		}

		protected virtual async Task<T> Execute<T>(Func<StorageContext, BaseStorageRequest<T>> request)
		{
			using var unitOfWork = _contextFactory.CreateDbContext();
			// Ожидание для сохранения контекста
			return await request(unitOfWork).ExecuteAsync();
		}
	}
}
