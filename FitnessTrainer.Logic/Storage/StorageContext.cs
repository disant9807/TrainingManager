using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;
using TrainingManager.Logic.Storage.Extensions;

namespace TrainingManager.Logic.Storage
{
    public class StorageContext : DbContext
    {
        public DbSet<Approach> Approach { get; set; }
        public DbSet<ApproachItem> ApproachItem { get; set;}
        public DbSet<CategoryOfBody> CategoryOfBody { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<TrainingProgram> TrainingProgram { get; set; }
        public DbSet<TrainingProgramDay> TrainingProgramDay { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<SizeItem> SizeItem { get; set; }
        public DbSet<Goal> Goal { get; set; }
        public DbSet<SubGoal> SubGoal { get; set; }

        public DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

        public StorageContext(DbContextOptions<StorageContext> dbContextOptions) : base(dbContextOptions)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.builderInitBody();
		}
	}
}
