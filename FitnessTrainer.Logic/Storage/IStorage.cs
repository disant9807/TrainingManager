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
    }
}
