using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class QueryParamsCategoryOfBodyVM
    {
        [FromQuery(Name = "queryString")]
        public string QueryString { get; set; }

        [FromQuery(Name = "order")]
        public Order order { get; set; }

        [FromQuery(Name = "start")]
        public int? start { get; set; }

        [FromQuery(Name = "count")]
        public int? count { get; set; }
    }
}
