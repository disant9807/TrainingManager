﻿using System;
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
using System.Collections;

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

		public Task<Model.Exercise[]> GetExercises(GetExercisesFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetExercisesRequest(u, filter, userId, isEveryone, order, start, count));

		public Task<Model.Exercise> GetExerciseById(long id)
			=> Execute((u) => new GetExerciseByIdRequest(u, _logFactory, _mapper, id));

		public Task<long> CreateExercise(Model.Exercise exercise)
			=> Execute((u) => new CreateExerciseRequest(u, exercise, _logFactory, _mapper));

		public Task UpdateExercise(Model.Exercise exercise)

			=> Execute((u) => new UpdateExerciseCommand(u, exercise, _logFactory, _mapper));

		public Task ArchiveExercise(long id, bool isArchive)
			=> Execute((u) => new ArchiveExerciseCommand(u, _logFactory, id, isArchive));



		public Task<Model.TrainingProgram[]> GetTrainingPrograms(GetTrainingProgramsFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null) 
            => Execute((u) => new GetTrainingProgramsRequest(u, _mapper, filter, userId, isEveryone, order, start, count));

		public Task<long> CreateTrainingProgram(Model.TrainingProgram trainingProgram)
			=> Execute((u) => new CreateTrainingProgramRequest(u, trainingProgram, _logFactory, _mapper));

		public Task UpdateTrainingProgram(Model.TrainingProgram trainingProgram)
			=> Execute((u) => new UpdateTrainingProgramInfoCommand(u, trainingProgram, _logFactory, _mapper));

		public Task ArchiveTrainingProgram(long id, bool isArchive)

			=> Execute((u) => new ArchiveTrainingProgramCommand(u, _logFactory, id, isArchive));

		public Task<Model.TrainingProgram> GetTrainingProgramById(long id)
			=> Execute((u) => new GetTrainingProgramByIdRequest(u, _logFactory, _mapper, id));


        public Task<Model.Training[]> GetTrainingsByPeriodInclude(DateTime dateFrom, DateTime dateTo, string userId)
            => Execute((u) => new GetTrainingsByPeriodIncludeRequest(u, _mapper, dateFrom, dateTo, userId));

        public Task<Model.Training[]> GetTraining(GetTrainingsFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null)
			=> Execute((u) => new GetTrainingsRequest(u, _mapper, filter, userId, isEveryone, order, start, count));

		public Task<long> CreateTraining(Model.Training training)
			=> Execute((u) => new CreateTrainingRequest(u, training, _logFactory, _mapper));

		public Task UpdateTraining(Model.Training training)
			=> Execute((u) => new UpdateTrainingCommand(u, training, _logFactory, _mapper));

		public Task ArchiveTraining(long id, bool isArchive)
			=> Execute((u) => new ArchiveTrainingCommand(u, _logFactory, id, isArchive));

        public Task<Model.Training> GetTrainingById(long id)
            => Execute((u) => new GetTrainingByIdRequest(u, _logFactory, _mapper, id));


        public Task<Model.Size[]> GetSizesByPeriodInclude(DateTime _dateFrom, DateTime _dateTo, string _userId)
            => Execute((u) => new GetSizesByPeriodIncludeRequest(u, _mapper, _dateFrom, _dateTo, _userId));

        public Task<Model.Size[]> GetSizes(GetSizesFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetSizesRequest(u, _mapper, filter, userId, isEveryone, order, start, count));

        public Task<Model.Size> GetSizeById(long id)
			=> Execute((u) => new GetSizeByIdRequest(u, _logFactory, _mapper, id));

        public Task<long> CreateSize(Model.Size size)
            => Execute((u) => new CreateSizeRequest(u, size, _logFactory, _mapper));

        public Task UpdateSize(Model.Size size)
            => Execute((u) => new UpdateSizeCommand(u, size, _logFactory, _mapper));

        public Task ArchiveSize(long id, bool isArchive)
            => Execute((u) => new ArchiveSizeCommand(u, _logFactory, id, isArchive));


        public Task<Model.Goal[]> GetGoalsByPeriodInclude(DateTime dateFrom, DateTime dateTo, string userId)
             => Execute((u) => new GetGoalsByPeriodIncludeRequest(u, _mapper, dateFrom, dateTo, userId));

        public Task<Model.Goal[]> GetGoals(GetGoalsFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null)
            => Execute((u) => new GetGoalsRequest(u, _mapper, filter, userId, isEveryone, order, start, count));

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

        public Task ArchiveCategoryOfBody(string code, bool isArchived)
            => Execute((u) => new ArchiveCategoryOfBodyCommand(u, _logFactory, code, isArchived));

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

        public Task ArchiveUnitsOfMeasurement(string code, bool isArchived)
            => Execute((u) => new ArchiveUnitsOfMeasurementCommand(u, _logFactory, code, isArchived));

        public Task<Model.UnitsOfMeasurement> GetUnitsOfMeasurementById(string code)
            => Execute((u) => new GetUnitsOfMeasurementByIdRequest(u, _logFactory, _mapper, code));

		public Task<Model.ObjectOfStatistics> GetObjectOfStatisticsById(Guid id)
			=> Execute((u) => new GetObjectOfStatisticsByIdRequest(u, _mapper, id));
          
        public Task<Model.ObjectOfStatistics[]> GetObjectOfStatisticsByCategory(string categoryCode, string userId)
            => Execute((u) => new GetObjectOfStatisticsByCategoryRequest(u, _mapper, categoryCode, userId));

        public Task<Model.ObjectOfStatistics[]> GetObjectsOfStatistics(string id)
            => Execute((u) => new GetObjectsOfStatisticsRequest(u, _mapper, id));

        public Task<Guid> CreateObjectsOfStatistics(Model.ObjectOfStatistics objectOfStatistics)
            => Execute((u) => new CreateObjectsOfStatisticsRequest(u, objectOfStatistics, _logFactory, _mapper));

        public Task<Guid[]> CreateObjectsOfStatisticsArr(Model.ObjectOfStatistics[] objectOfStatistics)
            => Execute((u) => new CreateObjectsOfStatisticsArrRequest(u, objectOfStatistics, _logFactory, _mapper));

        public Task UpdateObjectOfStatistics(Model.ObjectOfStatistics objectOfStatistics)
            => Execute((u) => new UpdateObjectOfStatisticsCommand(u, objectOfStatistics, _logFactory, _mapper));

        public Task ArchiveObjectOfStatstics(Guid id, bool isArchived)
            => Execute((u) => new ArchiveObjectOfStatisticsCommand(u, id, isArchived, _logFactory));

        public Task<Model.StatisticsIndicator[]> GetStatistics(GetStatisticsFilter filter)
            => Execute((u) => new GetStatisticsRequest(u, _mapper, filter));

        public Task<Guid> AddStatistics(Model.StatisticsIndicator statistics)
            => Execute((u) => new AddStatisticsIndicatorRequest(u, statistics, _logFactory, _mapper));

        public Task UpdateStatisticsIndicator(Model.StatisticsIndicator statistics)
            => Execute((u) => new UpdateStatisticsIndicatorCommand(u, statistics, _logFactory, _mapper));

        public Task ArchiveStatistics(Guid id, bool isArchive)
            => Execute((u) => new ArchiveStatisticsCommand(u, _logFactory, id, isArchive));


        public Task<Guid> CreateGenStatistics(GenStatistics genStatistics)
            => Execute((u) => new CreateGenStatisticsRequest(u, genStatistics, _logFactory, _mapper));

        public Task<GenStatistics[]> GetGenStatisticsByCategory(string categoryCode, string userId)
            => Execute((u) => new GetGenStatisticsByCategoryRequest(u, _mapper, categoryCode, userId));

        public Task<GenStatistics> GetGenStatisticsById(Guid id)
            => Execute((u) => new GetGenStatisticsByIdRequest(u, _mapper, id));

        public Task<bool> GetGenStatisticsByDate(DateTime date, string userId, string category)
            => Execute((u) => new GetGenStatisticsByDateRequest(u, _mapper, date, userId, category));


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
