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
        {
			long result;
			return long.TryParse(source, out result) ? result : 0;
        }
			
	}

	public class GuidToStringFormatter : IValueConverter<Guid, string>
	{
		public string Convert(Guid source, ResolutionContext context)
			=> source.ToString();
	}

	public class GuidNullableToStringFormatter : IValueConverter<Guid?, string>
	{
		public string Convert(Guid? source, ResolutionContext context)
			=> source?.ToString() ?? String.Empty;
	}

	public class StringToGuidNullableFormatter : IValueConverter<string, Guid?>
	{
		public Guid? Convert(string source, ResolutionContext context)
		{
			Guid result;
			return Guid.TryParse(source, out result) ? result : null;
		}
	}

	public class StringToGuidFormatter : IValueConverter<string, Guid>
	{
		public Guid Convert(string source, ResolutionContext context)
		{
			Guid result;
			return Guid.TryParse(source, out result) ? result : Guid.Empty;
		}
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

			CreateMap<ApproachItem, ApproachItemVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()));

			CreateMap<TrainingProgram, TrainingProgramVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ForMember(vm => vm.AvatarId, m => m.ConvertUsing(new GuidNullableToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()))
				.ForMember(vm => vm.AvatarId, m => m.ConvertUsing(new StringToGuidNullableFormatter()));

			CreateMap<TrainingProgramDay, TrainingProgramDayVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()));

			CreateMap<Size, SizeVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()));

            CreateMap<SizeItem, SizeItemVM>()
                .ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
                .ForMember(vm => vm.AvatarId, m => m.ConvertUsing(new GuidNullableToStringFormatter()))
                .ReverseMap()
                .ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()))
                .ForMember(vm => vm.AvatarId, m => m.ConvertUsing(new StringToGuidNullableFormatter()));

			CreateMap<Goal, GoalVM>()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new LongToStringFormatter()))
				.ReverseMap()
				.ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToLongFormatter()));

            CreateMap<SubGoal, SubGoalVM>()
                .ForMember(vm => vm.Id, m => m.ConvertUsing(new GuidToStringFormatter()))
                .ReverseMap()
                .ForMember(vm => vm.Id, m => m.ConvertUsing(new StringToGuidFormatter()));

            CreateMap<CategoryOfBody, CategoryOfBodyVM>().ReverseMap();
            CreateMap<UnitsOfMeasurement, UnitsOfMeasurementVM>().ReverseMap();

            CreateMap<GetTrainingsFilter, QueryParamsTrainingVM>().ReverseMap();
			CreateMap<GetTrainingProgramsFilter, QueryParamsTrainingProgramVM>().ReverseMap();
            CreateMap<GetExercisesFilter, QueryParamsExerciseVM>().ReverseMap();
            CreateMap<GetSizesFilter, QueryParamsSizeVM>().ReverseMap();
            CreateMap<GetGoalsFilter, QueryParamsGoalVM>().ReverseMap();
        }
	}
}
