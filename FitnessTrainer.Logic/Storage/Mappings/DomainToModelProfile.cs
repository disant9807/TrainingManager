﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrainingManager.Logic.Storage.Domain;
using TrainingManager.Logic.Storage.Model;

namespace TrainingManager.Logic.Storage.Mappings
{
    public class DomainToModelProfile : Profile
    {
		public DomainToModelProfiles()
		{
			CreateMap<Domain.Approach, Model.Approach>().ReverseMap();
			CreateMap<Domain.CategoryOfBody, Model.CategoryOfBody>().ReverseMap();
			CreateMap<Domain.Exercise, Model.Exercise>().ReverseMap();
			CreateMap<Domain.Training, Model.Training>().ReverseMap();
			CreateMap<Domain.TrainingProgram, Model.TrainingProgram>().ReverseMap();
			CreateMap<Domain.TrainingProgramDay, Model.TrainingProgramDay>().ReverseMap();
		}
	}
}
