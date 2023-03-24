using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class QueryParamsGoalVM
    {
        [FromQuery(Name = "codeUnitsOfMeasurement[]")]
        public string[] CodeUnitsOfMeasurement { get; set; }

        [FromQuery(Name = "categoryOfBodies[]")]
        public string[] CategoryOfBodies { get; set; }

        [FromQuery(Name = "value")]
        public float Value { get; set; }

        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [FromQuery(Name = "description")]
        public string Description { get; set; }

        [FromQuery(Name = "createdFrom")]
        public DateTime? CreatedFrom { get; set; }

        [FromQuery(Name = "createdTo")]
        public DateTime? CreatedTo { get; set; }

        [FromQuery(Name = "completionFrom")]
        public DateTime? CompletionDateFrom { get; set; }

        [FromQuery(Name = "completionTo")]
        public DateTime? CompletionDateTo { get; set; }

        [FromQuery(Name = "order")]
        public Order order { get; set; }

        [FromQuery(Name = "start")]
        public int? start { get; set; }

        [FromQuery(Name = "count")]
        public int? count { get; set; }
    }
}
