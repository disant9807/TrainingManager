using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrainingManager.Logic.Model;
using TrainingManager.ViewModels;

namespace TrainingManager.Mappings
{
	public class LongToStringFormatter : IValueConverter<long, string>
	{
		public string Convert(long source, ResolutionContext context)
			=> source.ToString();
	}
	public class StringToLongFormatter : IValueConverter<string, long>
	{
		public long Convert(string source, ResolutionContext context)
			=> long.Parse(source);
	}

	public class GuidToStringFormatter : IValueConverter<Guid, string>
	{
		public string Convert(Guid source, ResolutionContext context)
			=> source.ToString();
	}
	public class StringToGuidFormatter : IValueConverter<string, Guid>
	{
		public Guid Convert(string source, ResolutionContext context)
			=> Guid.Parse(source);
	}

	public class ModelToViewModelProfile : Profile
    {
		public ModelToViewModelProfile()
		{
			CreateMap<Exercise, ExerciseVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()));

			CreateMap<Training, TrainingVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()));

			CreateMap<Approach, ApproachVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()));

			CreateMap<TrainingProgram, TrainingProgramVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()));

			CreateMap<TrainingProgramDay, TrainingProgramDayVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()));

			CreateMap<GetTrainingsFilter, QueryParamsTrainingVM>().ReverseMap();
			CreateMap<GetTrainingProgramsFilter, QueryParamsTrainingProgramVM>().ReverseMap();
		}
	}
}
