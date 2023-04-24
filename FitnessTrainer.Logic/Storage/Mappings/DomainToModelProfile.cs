using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrainingManager.Logic.Storage.Domain;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Storage.Mappings
{
    public class DomainToModelProfile : Profile
    {
		public DomainToModelProfile()
		{
			CreateMap<Domain.ApproachItem, Model.ApproachItem>().ReverseMap();
			CreateMap<Domain.Approach, Model.Approach>().ReverseMap();
			CreateMap<Domain.CategoryOfBody, Model.CategoryOfBody>().ReverseMap();
			CreateMap<Domain.Exercise, Model.Exercise>().ReverseMap()
				.ForMember(m => m.CreatedDate, d => d.Ignore());
			CreateMap<Domain.Training, Model.Training>().ReverseMap();
			CreateMap<Domain.TrainingProgram, Model.TrainingProgram>().ReverseMap()
				.ForMember(m => m.Days, d => d.Ignore());
			CreateMap<Domain.TrainingProgramDay, Model.TrainingProgramDay>().ReverseMap();
			CreateMap<Domain.Size, Model.Size>().ReverseMap();
            CreateMap<Domain.SizeItem, Model.SizeItem>().ReverseMap();
            CreateMap<Domain.Goal, Model.Goal>().ReverseMap();
            CreateMap<Domain.SubGoal, Model.SubGoal>().ReverseMap()
				.ForMember(m => m.Body, m => m.Ignore())
				.ForMember(m => m.UnitsOfMeasurement, m => m.Ignore());
			CreateMap<Domain.UnitsOfMeasurement, Model.UnitsOfMeasurement>().ReverseMap();
			CreateMap<Domain.CategoryOfBody, Model.CategoryOfBody>().ReverseMap();
			CreateMap<Domain.StatisticsIndicator, Model.StatisticsIndicator>().ReverseMap();
			CreateMap<Domain.ObjectOfStatistics, Model.ObjectOfStatistics>().ReverseMap();
        }
	}
}
