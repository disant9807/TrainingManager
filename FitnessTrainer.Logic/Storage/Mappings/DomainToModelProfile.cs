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
			CreateMap<Domain.Exercise, Model.Exercise>().ReverseMap();
			CreateMap<Domain.Training, Model.Training>().ReverseMap();
			CreateMap<Domain.TrainingProgram, Model.TrainingProgram>().ReverseMap()
				.ForMember(m => m.Days, d => d.Ignore());
			CreateMap<Domain.TrainingProgramDay, Model.TrainingProgramDay>().ReverseMap();
			CreateMap<Domain.Size, Model.Size>().ReverseMap()
                .ForMember(m => m.SizeItems, d => d.Ignore());
            CreateMap<Domain.SizeItem, Model.SizeItem>().ReverseMap();
        }
	}
}
