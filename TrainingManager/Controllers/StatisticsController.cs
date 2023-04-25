using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TrainingManager.Logic.Storage;
using TrainingManager.Logic.Model;
using TrainingManager.Log;
using TrainingManager.ViewModels;
using Serilog;
using System.Net;
using AutoMapper;


namespace TrainingManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly Serilog.ILogger _log;
        private readonly ILogFactory _logFactory;
        private readonly IMapper _mapper;

        public StatisticsController(IStorage storage, ILogFactory logFactory, IMapper mapper)
        {
            _storage = storage;
            _logFactory = logFactory;
            _log = logFactory.CreateModuleLogger(typeof(StatisticsController));
            _mapper = mapper;
        }



        [HttpGet("{statisticsId}")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ObjectOfStatistics>>> GetStatisticsById([FromRoute]string statisticsId)
        {
            Guid statisticsGuid;
            if (Guid.TryParse(statisticsId, out statisticsGuid))
            {
                throw new ArgumentNullException(nameof(statisticsId));
            }

            var statistics = await _storage.GetObjectOfStatisticsById(statisticsGuid);
            return Ok(statistics);
        }


        [HttpGet("{userId}/{categoryCode}")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ObjectOfStatistics>>> GetStatisticsByCategory([FromRoute]string categoryCode, [FromRoute]string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) { 
                throw new ArgumentNullException(nameof(userId));
            }

            var statistics = await _storage.GetObjectOfStatisticsByCategory(categoryCode, userId);
            return Ok(statistics);
        }


        /// <summary>Статистика цели</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("goal")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ObjectOfStatistics>>> GenGoalStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            _log.Debug("Запуск процесса генерации стаатистики цели");
            if ((dateTo - dateFrom) > TimeSpan.FromDays(366))
                return BadRequest();

            var goals = await _storage.GetGoals(new GetGoalsFilter
            {
                CreatedFrom = dateFrom,
                CreatedTo = dateTo
            });

            var objOfStatistics = new List<ObjectOfStatistics>();

            foreach (var subGoal in goals.OrderByDescending(e => e.CompletionDate)
                .SelectMany(e => e.SubGoals)
                .OrderBy(e => e.BodyCode))
            {
                var localObjOfStatistics = objOfStatistics.FirstOrDefault(e => e.Code == subGoal.BodyCode);
                if (localObjOfStatistics is null)
                {
                    localObjOfStatistics = new ObjectOfStatistics
                    {
                        Id = Guid.NewGuid(),
                        CategoryCode = "Goal",
                        Description = "",
                        Code = subGoal.BodyCode,
                        Name = subGoal.Body.ShortName ?? subGoal.Body.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }

                localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                    {
                        DateOfMeasurement = goals
                            .FirstOrDefault(e => e.SubGoals.Contains(subGoal)).CompletionDate,
                        ObjectCode = localObjOfStatistics.Id,
                        Value = subGoal.Value.ToString()
                    });
            }

            await _storage.CreateObjectsOfStatisticsArr(objOfStatistics.ToArray());

            return objOfStatistics;
        }

        /// <summary>Статистика заамера</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("size")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ObjectOfStatistics>>> GenSizeStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            if ((dateTo - dateFrom) > TimeSpan.FromDays(366))
                return BadRequest();

            var sizes = await _storage.GetSizes(new GetSizesFilter
            {
                CreatedFrom = dateFrom,
                CreatedTo = dateTo
            });

            var objOfStatistics = new List<ObjectOfStatistics>();

            foreach (var sizeItem in sizes.OrderByDescending(e => e.CreatedDate)
                .SelectMany(e => e.SizeItems)
                .OrderBy(e => e.BodyCode))
            {
                var localObjOfStatistics = objOfStatistics.FirstOrDefault(e => e.Code == sizeItem.BodyCode);
                if (localObjOfStatistics is null)
                {
                    localObjOfStatistics = new ObjectOfStatistics
                    {
                        Id = Guid.NewGuid(),
                        CategoryCode = "Size",
                        Description = "",
                        Code = sizeItem.BodyCode,
                        Name = sizeItem.Body.ShortName ?? sizeItem.Body.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }

                localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                {
                    DateOfMeasurement = sizes
                            .FirstOrDefault(e => e.SizeItems.Contains(sizeItem)).CreatedDate,
                    ObjectCode = localObjOfStatistics.Id,
                    Value = sizeItem.Value.ToString()
                });
            }

            await _storage.CreateObjectsOfStatisticsArr(objOfStatistics.ToArray());

            return objOfStatistics;
        }

        /// <summary>Статистика тренировки</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("training")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ObjectOfStatistics>>> GenTrainingStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            if ((dateTo - dateFrom) > TimeSpan.FromDays(366))
                return BadRequest();

            var training = await _storage.GetTraining(new GetTrainingsFilter
            {
                TrainingFrom = dateFrom,
                TrainingTo = dateTo
            }, Order.Desc);

            var objOfStatistics = new List<ObjectOfStatistics>();

            foreach (var approach in training.OrderByDescending(e => e.CreatedDate)
                .SelectMany(e => e.Approachs)
                .OrderBy(e => e.Exercise.Id))
            {
                var localObjOfStatistics = objOfStatistics.FirstOrDefault(e => e.Code == approach.Exercise.Id.ToString());
                if (localObjOfStatistics is null)
                {
                    localObjOfStatistics = new ObjectOfStatistics
                    {
                        Id = Guid.NewGuid(),
                        CategoryCode = "Training",
                        Description = "",
                        Code = approach.Exercise.Id.ToString(),
                        Name = approach.Exercise.ShortName ?? approach.Exercise.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }

                localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                {
                    DateOfMeasurement = training
                            .FirstOrDefault(e => e.Approachs
                            .Select(z => z.Id)
                            .Contains(approach.Id)).CreatedDate,
                    ObjectCode = localObjOfStatistics.Id,
                    Value = approach.ApproachsItems.Average(e => e.Weight).ToString()
                });
            }

            await _storage.CreateObjectsOfStatisticsArr(objOfStatistics.ToArray());

            return objOfStatistics;
        }
    }
}
