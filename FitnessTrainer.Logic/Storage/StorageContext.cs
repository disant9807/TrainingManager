﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;

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
			modelBuilder.Entity<CategoryOfBody>().HasData(
				new CategoryOfBody
                {
                    Code = "Back",
                    Name = "Спина",
                    Decsription = "Спина",
                    ShortName = "Спина"
                },
                new CategoryOfBody
                {
                    Code = "legs",
                    Name = "Ноги",
                    Decsription = "Ноги",
                    ShortName = "Ноги"
                },
                new CategoryOfBody
                {
                    Code = "Chest",
                    Name = "Грудь",
                    Decsription = "Грудь",
                    ShortName = "Грудь"
                }
            );
		}
	}
}
