using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class QueryParamsTrainingVM
    {
        [FromQuery(Name = "categoryOfBodies[]")]
        public string[] CategoryOfBodies { get; set; }

        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [FromQuery(Name = "createdFrom")]
        public DateTime? CreatedFrom { get; set; }

        [FromQuery(Name = "createdTo")]
        public DateTime? CreatedTo { get; set; }

        [FromQuery(Name = "trainingFrom")]
        public DateTime? TrainingFrom { get; set; }

        [FromQuery(Name = "trainingTo")]
        public DateTime? TrainingTo { get; set; }

        [FromQuery(Name = "exercises[]")]
        public string[] Exercises { get; set; }

        [FromQuery(Name = "trainingPrograms[]")]
        public string[] TrainingPrograms { get; set; }

        [FromQuery(Name = "isNoneTrainingProgram")]
        public bool? isNoneTrainingProgram { get; set; }

        [FromQuery(Name = "MaxCountApproach")]
        public int? MaxCountApproach { get; set; }

        [FromQuery(Name = "MinCountApproach")]
        public int? MinCountApproach { get; set; }

        [FromQuery(Name = "MaxTimeSec")]
        public long? MaxTimeSec { get; set; }

        [FromQuery(Name = "MinTimeSec")]
        public long? MinTimeSec { get; set; }

        [FromQuery(Name = "order")]
        public Order order { get; set; }

        [FromQuery(Name = "start")]
        public int? start { get; set; }

        [FromQuery(Name = "count")]
        public int? count { get; set; }
    }
}
