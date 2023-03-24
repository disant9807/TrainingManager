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



		public Task<TrainingProgram[]> GetTrainingPrograms(GetTrainingProgramsFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetTrainingProgramsRequest(u, _mapper, filter, order, start, count));

		public Task<long> CreateTrainingProgram(TrainingProgram trainingProgram)
			=> Execute((u) => new CreateTrainingProgramRequest(u, trainingProgram, _logFactory, _mapper));

		public Task UpdateTrainingProgram(TrainingProgram trainingProgram)
			=> Execute((u) => new UpdateTrainingProgramInfoCommand(u, trainingProgram, _logFactory, _mapper));

		public Task ArchiveTrainingProgram(long id, bool isArchive)

			=> Execute((u) => new ArchiveTrainingProgramCommand(u, _logFactory, id, isArchive));

		public Task<TrainingProgram> GetTrainingProgramById(long id)
			=> Execute((u) => new GetTrainingProgramByIdRequest(u, _logFactory, _mapper, id));



		public Task<Training[]> GetTraining(GetTrainingsFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetTrainingsRequest(u, _mapper, filter, order, start, count));

		public Task<long> CreateTraining(Training training)
			=> Execute((u) => new CreateTrainingRequest(u, training, _logFactory, _mapper));

		public Task UpdateTraining(Training training)
			=> Execute((u) => new UpdateTrainingCommand(u, training, _logFactory, _mapper));

		public Task ArchiveTraining(long id, bool isArchive)

			=> Execute((u) => new ArchiveTrainingCommand(u, _logFactory, id, isArchive));



        public Task<Size[]> GetSizes(GetSizesFilter filter, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetSizesRequest(u, _mapper, filter, order, start, count));

        public Task<Size> GetSizeById(long id)
			=> Execute((u) => new GetSizeByIdRequest(u, _logFactory, _mapper, id));

        public Task<long> CreateSize(Size size)
            => Execute((u) => new CreateSizeRequest(u, size, _logFactory, _mapper));

        public Task UpdateSize(Size size)
            => Execute((u) => new UpdateSizeCommand(u, size, _logFactory, _mapper));

        public Task ArchiveSize(long id, bool isArchive)
            => Execute((u) => new ArchiveSizeCommand(u, _logFactory, id, isArchive));


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
