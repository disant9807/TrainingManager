using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class QueryParamsExerciseVM
    {
        [FromQuery(Name = "categoryOfBodies[]")]
        public string[] categoryOfBodies { get; set; }

        [FromQuery(Name = "name")]
        public string name { get; set; }

        [FromQuery(Name = "createdFrom")]
        public DateTime? createdFrom { get; set; }

        [FromQuery(Name = "createdTo")]
        public DateTime? createdTo { get; set; }

        [FromQuery(Name = "isBased")]
        public bool? isBased { get; set; }

        [FromQuery(Name = "hardSkill")]
        public HardSkill? hardSkill { get; set; }

        [FromQuery(Name = "hardSkills[]")]
        public HardSkill[] hardSkills { get; set; }

        [FromQuery(Name = "order")]
        public  Order order { get; set; }

        [FromQuery(Name = "start")]
        public int? start { get; set; }

        [FromQuery(Name = "count")]
        public int? count { get; set; }
    }
}
