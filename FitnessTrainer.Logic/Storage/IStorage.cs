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
        Task<Exercise[]> GetExercises(GetExercisesFilter filter, Order? order = null, int? start = null, int? count = null);
        Task<long> CreateExercise(Exercise exercise);
        Task UpdateExercise(Exercise exercise);
        Task ArchiveExercise(long id, bool isArchived);
        Task<Exercise> GetExerciseById(long id);
    }
}
