using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;

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
        Task<Training[]> GetTraining(GetTrainingsFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateTraining(Training training);
        Task UpdateTraining(Training training);
        Task ArchiveTraining(long id, bool isArchived);
        Task<Training> GetTrainingById(long id);

        // Замеры
        Task<Size[]> GetSizes(GetSizesFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateSize(Size size);
        Task UpdateSize(Size size);
        Task ArchiveSize(long id, bool isArchived);
        Task<Size> GetSizeById(long id);

        // Цели
        // Замеры
        Task<Goal[]> GetGoals(GetGoalsFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateGoal(Goal size);
        Task UpdateGoal(Goal size);
        Task ArchiveGoal(long id, bool isArchived);
        Task<Goal> GetGoalById(long id);
    }
}
