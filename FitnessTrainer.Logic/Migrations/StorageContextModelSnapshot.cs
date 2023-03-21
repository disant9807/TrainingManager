﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingManager.Logic.Storage;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("CategoryOfBodyExercise", b =>
                {
                    b.Property<string>("CategoryOfBodiesCode")
                        .HasColumnType("TEXT");

                    b.Property<long>("ExercisesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryOfBodiesCode", "ExercisesId");

                    b.HasIndex("ExercisesId");

                    b.ToTable("CategoryOfBodyExercise");
                });

            modelBuilder.Entity("ExerciseTrainingProgramDay", b =>
                {
                    b.Property<long>("ExercisesId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TrainingProgramDaysId")
                        .HasColumnType("TEXT");

                    b.HasKey("ExercisesId", "TrainingProgramDaysId");

                    b.HasIndex("TrainingProgramDaysId");

                    b.ToTable("ExerciseTrainingProgramDay");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Approach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long?>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfTraining")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Approach");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.ApproachItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Hard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfApproach")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Technicality")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.Property<Guid>("approachId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("approachId");

                    b.ToTable("ApproachItem");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.CategoryOfBody", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AvatarId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Decsription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.HasIndex("AvatarId");

                    b.ToTable("CategoryOfBody");

                    b.HasData(
                        new
                        {
                            Code = "Back",
                            Decsription = "Спина",
                            IsArchived = false,
                            Name = "Спина",
                            ShortName = "Спина"
                        },
                        new
                        {
                            Code = "legs",
                            Decsription = "Ноги",
                            IsArchived = false,
                            Name = "Ноги",
                            ShortName = "Ноги"
                        },
                        new
                        {
                            Code = "Chest",
                            Decsription = "Грудь",
                            IsArchived = false,
                            Name = "Грудь",
                            ShortName = "Грудь"
                        });
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Exercise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("AvatarId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("HardSkill")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsBased")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SizeItemId")
                        .HasColumnType("TEXT");

                    b.Property<long?>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("SizeItemId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Purpose", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Purpose");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Size", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.SizeItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AvatarId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BodyCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeUnitsOfMeasurement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("SizeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("BodyCode");

                    b.HasIndex("CodeUnitsOfMeasurement");

                    b.HasIndex("SizeId");

                    b.ToTable("SizeItem");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.SubPurpose", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryOfBodyCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeUnitsOfMeasurement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PurposeId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryOfBodyCode");

                    b.HasIndex("CodeUnitsOfMeasurement");

                    b.HasIndex("PurposeId");

                    b.ToTable("SubPurpose");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Training", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TrainingDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.TrainingProgram", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("AvatarId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("TrainingProgram");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.TrainingProgramDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("DayRelax")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfTrainingProgram")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramDay");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.UnitsOfMeasurement", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.ToTable("UnitsOfMeasurement");
                });

            modelBuilder.Entity("CategoryOfBodyExercise", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.CategoryOfBody", null)
                        .WithMany()
                        .HasForeignKey("CategoryOfBodiesCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseTrainingProgramDay", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgramDay", null)
                        .WithMany()
                        .HasForeignKey("TrainingProgramDaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Approach", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Training", "Training")
                        .WithMany("Approachs")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.ApproachItem", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Approach", "approach")
                        .WithMany("ApproachsItems")
                        .HasForeignKey("approachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("approach");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.CategoryOfBody", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Exercise", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Image", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", null)
                        .WithMany("Images")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("TrainingManager.Logic.Storage.Domain.SizeItem", null)
                        .WithMany("Images")
                        .HasForeignKey("SizeItemId");

                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", null)
                        .WithMany("Images")
                        .HasForeignKey("TrainingProgramId");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.SizeItem", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.CategoryOfBody", "Body")
                        .WithMany()
                        .HasForeignKey("BodyCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.UnitsOfMeasurement", "UnitsOfMeasurement")
                        .WithMany()
                        .HasForeignKey("CodeUnitsOfMeasurement")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Size", "Size")
                        .WithMany("SizeItems")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");

                    b.Navigation("Body");

                    b.Navigation("Size");

                    b.Navigation("UnitsOfMeasurement");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.SubPurpose", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.CategoryOfBody", "CategoryOfBody")
                        .WithMany()
                        .HasForeignKey("CategoryOfBodyCode");

                    b.HasOne("TrainingManager.Logic.Storage.Domain.UnitsOfMeasurement", "UnitsOfMeasurement")
                        .WithMany()
                        .HasForeignKey("CodeUnitsOfMeasurement")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Purpose", "Purpose")
                        .WithMany("SubPurpose")
                        .HasForeignKey("PurposeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryOfBody");

                    b.Navigation("Purpose");

                    b.Navigation("UnitsOfMeasurement");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Training", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", "TrainingProgram")
                        .WithMany()
                        .HasForeignKey("TrainingProgramId");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.TrainingProgram", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.TrainingProgramDay", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", "TrainingProgram")
                        .WithMany("Days")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Approach", b =>
                {
                    b.Navigation("ApproachsItems");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Exercise", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Purpose", b =>
                {
                    b.Navigation("SubPurpose");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Size", b =>
                {
                    b.Navigation("SizeItems");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.SizeItem", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Training", b =>
                {
                    b.Navigation("Approachs");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.TrainingProgram", b =>
                {
                    b.Navigation("Days");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
