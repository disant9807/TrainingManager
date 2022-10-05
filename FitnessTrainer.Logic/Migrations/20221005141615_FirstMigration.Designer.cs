﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingManager.Logic.Storage;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20221005141615_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Approach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfTraining")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Technicality")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Approach");
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

                    b.Property<long?>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.HasIndex("AvatarId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("CategoryOfBody");

                    b.HasData(
                        new
                        {
                            Code = "Back",
                            Decsription = "Спина",
                            Name = "Спина",
                            ShortName = "Спина"
                        },
                        new
                        {
                            Code = "legs",
                            Decsription = "Ноги",
                            Name = "Ноги",
                            ShortName = "Ноги"
                        },
                        new
                        {
                            Code = "Chest",
                            Decsription = "Грудь",
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

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HardSkill")
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Training", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrainingProgramId")
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

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.Property<long>("ExercisesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfTrainingProgram")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExercisesId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramDay");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Approach", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Training", "Training")
                        .WithMany("Approachs")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.CategoryOfBody", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", null)
                        .WithMany("CategoryOfBodies")
                        .HasForeignKey("ExerciseId");

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

                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", null)
                        .WithMany("Images")
                        .HasForeignKey("TrainingProgramId");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Training", b =>
                {
                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", "TrainingProgram")
                        .WithMany()
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                    b.HasOne("TrainingManager.Logic.Storage.Domain.Exercise", "Exercises")
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingManager.Logic.Storage.Domain.TrainingProgram", "TrainingProgram")
                        .WithMany("Days")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercises");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("TrainingManager.Logic.Storage.Domain.Exercise", b =>
                {
                    b.Navigation("CategoryOfBodies");

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
