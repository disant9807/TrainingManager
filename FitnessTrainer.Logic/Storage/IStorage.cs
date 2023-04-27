using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;
using TrainingManager.Logic.Storage.Requests;

namespace TrainingManager.Logic.Storage
{
    public interface IStorage
    {
        // Упражнения
        Task<Exercise[]> GetExercises(GetExercisesFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateExercise(Exercise exercise);
        Task UpdateExercise(Exercise exercise);
        Task ArchiveExercise(long id, bool isArchived);
        Task<Exercise> GetExerciseById(long id);

        // Тренировочные программы
        Task<TrainingProgram[]> GetTrainingPrograms(GetTrainingProgramsFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateTrainingProgram(TrainingProgram trainingProgram);
        Task UpdateTrainingProgram(TrainingProgram trainingProgram);
        Task ArchiveTrainingProgram(long id, bool isArchived);
        Task<TrainingProgram> GetTrainingProgramById(long id);

        // Тренировки
        Task<Training[]> GetTrainingsByPeriodInclude(DateTime dateFrom, DateTime dateTo);
        Task<Training[]> GetTraining(GetTrainingsFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateTraining(Training training);
        Task UpdateTraining(Training training);
        Task ArchiveTraining(long id, bool isArchived);
        Task<Training> GetTrainingById(long id);

        // Замеры
        Task<Size[]> GetSizesByPeriodInclude(DateTime dateFrom, DateTime dateTo);
        Task<Size[]> GetSizes(GetSizesFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateSize(Size size);
        Task UpdateSize(Size size);
        Task ArchiveSize(long id, bool isArchived);
        Task<Size> GetSizeById(long id);

        // Цели
        Task<Goal[]> GetGoalsByPeriodInclude(DateTime dateFrom, DateTime dateTo);
        Task<Goal[]> GetGoals(GetGoalsFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateGoal(Goal size);
        Task UpdateGoal(Goal size);
        Task ArchiveGoal(long id, bool isArchived);
        Task<Goal> GetGoalById(long id);

        // Части тела
        Task<CategoryOfBody[]> GetCategoryOfBody(string queryString, Order? order = null, int? start = null, int? count = null);
        Task<string> CreateCategoryOfBody(CategoryOfBody  categoryOfBody);
        Task UpdateCategoryOfBody(string code, CategoryOfBody categoryOfBody);
        Task RemoveCategoryOfBody(string code, bool isArchived);
        Task ArchiveCategoryOfBody(string code, bool isArchived);
        Task<CategoryOfBody> GetCategoryOfBodyById(string code);

        // Едиинцы измерения
        Task<UnitsOfMeasurement[]> GetUnitsOfMeasurement(string queryString, Order? order = null, int? start = null, int? count = null);
        Task<string> CreateUnitsOfMeasurement(UnitsOfMeasurement unitsOfMeasurement);
        Task UpdateUnitsOfMeasurementy(string code, UnitsOfMeasurement unitsOfMeasurement);
        Task RemoveUnitsOfMeasurement(string id, bool isArchived);
        Task ArchiveUnitsOfMeasurement(string id, bool isArchived);
        Task<UnitsOfMeasurement> GetUnitsOfMeasurementById(string code);

        // Объекты статистики
        Task<ObjectOfStatistics[]> GetObjectsOfStatistics(string userId);
        Task<ObjectOfStatistics[]> GetObjectOfStatisticsByCategory(string categoryCode, string userId);
        Task<ObjectOfStatistics> GetObjectOfStatisticsById(Guid id);
        Task<Guid> CreateObjectsOfStatistics(ObjectOfStatistics objectOfStatistics);
        Task<Guid[]> CreateObjectsOfStatisticsArr(ObjectOfStatistics[] objectOfStatistics);
        Task UpdateObjectOfStatistics(ObjectOfStatistics objectOfStatistics);
        Task ArchiveObjectOfStatstics(Guid id, bool isArchived);


        Task<Guid> CreateGenStatistics(GenStatistics genStatistics);
        Task<GenStatistics[]> GetGenStatisticsByCategory(string categoryCode, string userId);
        Task<GenStatistics> GetGenStatisticsById(Guid id);
    }
}
