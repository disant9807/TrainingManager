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
using TrainingManager.Logic.Storage.Domain;

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

		public Task<Model.Exercise[]> GetExercises(GetExercisesFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetExercisesRequest(u, filter, order, start, count));

		public Task<Model.Exercise> GetExerciseById(long id)
			=> Execute((u) => new GetExerciseByIdRequest(u, _logFactory, _mapper, id));

		public Task<long> CreateExercise(Model.Exercise exercise)
			=> Execute((u) => new CreateExerciseRequest(u, exercise, _logFactory, _mapper));

		public Task UpdateExercise(Model.Exercise exercise)

			=> Execute((u) => new UpdateExerciseCommand(u, exercise, _logFactory, _mapper));

		public Task ArchiveExercise(long id, bool isArchive)
			=> Execute((u) => new ArchiveExerciseCommand(u, _logFactory, id, isArchive));



		public Task<Model.TrainingProgram[]> GetTrainingPrograms(GetTrainingProgramsFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetTrainingProgramsRequest(u, _mapper, filter, order, start, count));

		public Task<long> CreateTrainingProgram(Model.TrainingProgram trainingProgram)
			=> Execute((u) => new CreateTrainingProgramRequest(u, trainingProgram, _logFactory, _mapper));

		public Task UpdateTrainingProgram(Model.TrainingProgram trainingProgram)
			=> Execute((u) => new UpdateTrainingProgramInfoCommand(u, trainingProgram, _logFactory, _mapper));

		public Task ArchiveTrainingProgram(long id, bool isArchive)

			=> Execute((u) => new ArchiveTrainingProgramCommand(u, _logFactory, id, isArchive));

		public Task<Model.TrainingProgram> GetTrainingProgramById(long id)
			=> Execute((u) => new GetTrainingProgramByIdRequest(u, _logFactory, _mapper, id));



		public Task<Model.Training[]> GetTraining(GetTrainingsFilter filter, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetTrainingsRequest(u, _mapper, filter, order, start, count));

		public Task<long> CreateTraining(Model.Training training)
			=> Execute((u) => new CreateTrainingRequest(u, training, _logFactory, _mapper));

		public Task UpdateTraining(Model.Training training)
			=> Execute((u) => new UpdateTrainingCommand(u, training, _logFactory, _mapper));

		public Task ArchiveTraining(long id, bool isArchive)
			=> Execute((u) => new ArchiveTrainingCommand(u, _logFactory, id, isArchive));

        public Task<Model.Training> GetTrainingById(long id)
            => Execute((u) => new GetTrainingByIdRequest(u, _logFactory, _mapper, id));


        public Task<Model.Size[]> GetSizes(GetSizesFilter filter, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetSizesRequest(u, _mapper, filter, order, start, count));

        public Task<Model.Size> GetSizeById(long id)
			=> Execute((u) => new GetSizeByIdRequest(u, _logFactory, _mapper, id));

        public Task<long> CreateSize(Model.Size size)
            => Execute((u) => new CreateSizeRequest(u, size, _logFactory, _mapper));

        public Task UpdateSize(Model.Size size)
            => Execute((u) => new UpdateSizeCommand(u, size, _logFactory, _mapper));

        public Task ArchiveSize(long id, bool isArchive)
            => Execute((u) => new ArchiveSizeCommand(u, _logFactory, id, isArchive));



        public Task<Model.Goal[]> GetGoals(GetGoalsFilter filter, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetGoalsRequest(u, _mapper, filter, order, start, count));

        public Task<Model.Goal> GetGoalById(long id)
            => Execute((u) => new GetGoalByIdRequest(u, _logFactory, _mapper, id));

        public Task<long> CreateGoal(Model.Goal goal)
            => Execute((u) => new CreateGoalRequest(u, goal, _logFactory, _mapper));

        public Task UpdateGoal(Model.Goal goal)
            => Execute((u) => new UpdateGoalCommand(u, goal, _logFactory, _mapper));

        public Task ArchiveGoal(long id, bool isArchive)
            => Execute((u) => new ArchiveGoalCommand(u, _logFactory, id, isArchive));


        public Task<Model.CategoryOfBody[]> GetCategoryOfBody(string queryString, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetCategoryOfBodyRequest(u, _mapper, queryString, order, start, count));

		public Task<string> CreateCategoryOfBody(Model.CategoryOfBody categoryOfBody)
			=> Execute((u) => new CreateCategoryOfBodyRequest(u, categoryOfBody, _logFactory, _mapper));

        public Task UpdateCategoryOfBody(string code, Model.CategoryOfBody categoryOfBody)
			=> Execute((u) => new UpdateCategoryOfBodyCommand(u, categoryOfBody, code, _logFactory, _mapper));

        public Task RemoveCategoryOfBody(string code, bool isArchived)
			=> Execute((u) => new RemoveCategoryOfBodyCommand(u, _logFactory, code));

		public Task<Model.CategoryOfBody> GetCategoryOfBodyById(string code)
			=> Execute((u) => new GetCategoryOfBodyByIdRequest(u, _logFactory, _mapper, code));



        public Task<Model.UnitsOfMeasurement[]> GetUnitsOfMeasurement(string queryString, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetUnitsOfMeasurementRequest(u, _mapper, queryString, order, start, count));

        public Task<string> CreateUnitsOfMeasurement(Model.UnitsOfMeasurement categoryOfBody)
            => Execute((u) => new CreateUnitsOfMeasurementRequest(u, categoryOfBody, _logFactory, _mapper));

        public Task UpdateUnitsOfMeasurementy(string code, Model.UnitsOfMeasurement categoryOfBody)
            => Execute((u) => new UpdateUnitsOfMeasurementCommand(u, categoryOfBody, code, _logFactory, _mapper));

        public Task RemoveUnitsOfMeasurement(string code, bool isArchived)
            => Execute((u) => new RemoveUnitsOfMeasurementCommand(u, _logFactory, code));

        public Task<Model.UnitsOfMeasurement> GetUnitsOfMeasurementById(string code)
            => Execute((u) => new GetUnitsOfMeasurementByIdRequest(u, _logFactory, _mapper, code));



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
