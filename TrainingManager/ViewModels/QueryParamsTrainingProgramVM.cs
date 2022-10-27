using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class QueryParamsTrainingProgramVM
    {
        [FromQuery(Name = "categoryOfBodies[]")]
        public string[] CategoryOfBodies { get; set; }

        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [FromQuery(Name = "createdFrom")]
        public DateTime? CreatedFrom { get; set; }

        [FromQuery(Name = "createdTo")]
        public DateTime? CreatedTo { get; set; }

        [FromQuery(Name = "exercises[]")]
        public string[] Exercises { get; set; }

        [FromQuery(Name = "maxCountTrainingDays")]
        public int? MaxCountTrainingDays { get; set; }

        [FromQuery(Name = "minCountTrainingDays")]
        public int? MinCountTrainingDays { get; set; }

        [FromQuery(Name = "order")]
        public Order order { get; set; }

        [FromQuery(Name = "start")]
        public int? start { get; set; }

        [FromQuery(Name = "count")]
        public int? count { get; set; }
    }
}
