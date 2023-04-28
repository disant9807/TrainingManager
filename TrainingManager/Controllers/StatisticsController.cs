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
        public async Task<ActionResult<IEnumerable<GenStatistics>>> GetStatisticsById([FromRoute]string statisticsId)
        {
            Guid statisticsGuid;
            if (!Guid.TryParse(statisticsId, out statisticsGuid))
            {
                throw new ArgumentNullException(nameof(statisticsId));
            }

            var statistics = await _storage.GetGenStatisticsById(statisticsGuid);
            return Ok(statistics);
        }


        [HttpGet("{userId}/{categoryCode}")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GenStatistics>>> GetStatisticsByCategory([FromRoute]string categoryCode, [FromRoute]string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) { 
                throw new ArgumentNullException(nameof(userId));
            }

            var statistics = await _storage.GetGenStatisticsByCategory(categoryCode, userId);
            return Ok(statistics);
        }


        /// <summary>Статистика цели</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("goal")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GenStatistics>> GenGoalStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo, [FromQuery] string userId)
        {
            _log.Debug("Запуск процесса генерации стаатистики цели");
            if ((dateTo - dateFrom) > TimeSpan.FromDays(366))
                return BadRequest("Выборка должна быть меньше года");

            var isNotNewGen = await _storage.GetGenStatisticsByDate(DateTime.Now, userId, "Goal");
            if (isNotNewGen)
                return BadRequest("Разрешена тольк 1 генерация статистики в сутки");

            var goals = await _storage.GetGoalsByPeriodInclude(dateFrom, dateTo);

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
                        UserId = userId,
                        CategoryCode = "Goal",
                        Description = "",
                        Code = subGoal.BodyCode,
                        Name = subGoal.Body.ShortName ?? subGoal.Body.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }

                var selectGoal = goals.FirstOrDefault(e => e.SubGoals.Any(z => z.Id == subGoal.Id));

                localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                    {
                        DateOfMeasurement = selectGoal.CompletionDate,
                        ObjectCode = localObjOfStatistics.Id,
                        Value = subGoal.Value.ToString()
                    });
            }

            var genStatistics = new GenStatistics
            {
                CategoryCode = "Goal",
                CreatedTime = DateTime.Now,
                GeneratedTime = DateTime.Now,
                Id = Guid.NewGuid(),
                Statistics = objOfStatistics,
                UserId = userId
            };

            if(genStatistics.Statistics?.Count == 0)
            {
                return BadRequest("Отсутствуют данные в выборке");
            }

            await _storage.CreateGenStatistics(genStatistics);

            return Ok(genStatistics);
        }

        /// <summary>Статистика заамера</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("size")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GenStatistics>> GenSizeStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo, [FromQuery] string userId)
        {
            if ((dateTo - dateFrom) > TimeSpan.FromDays(366))
                return BadRequest();

            var isNotNewGen = await _storage.GetGenStatisticsByDate(DateTime.Now, userId, "Size");
            if (isNotNewGen)
                return BadRequest();

            var sizes = await _storage
                .GetSizesByPeriodInclude(dateFrom, dateTo);

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
                        UserId = userId,
                        Code = sizeItem.BodyCode,
                        Name = sizeItem.Body.ShortName ?? sizeItem.Body.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }
                var selectSize = sizes.FirstOrDefault(e => e.SizeItems.Any(z => z.Id == sizeItem.Id));

                localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                {
                    DateOfMeasurement = selectSize.CreatedDate,
                    ObjectCode = localObjOfStatistics.Id,
                    Value = sizeItem.Value.ToString()
                });
            }

            var genStatistics = new GenStatistics
            {
                CategoryCode = "Size",
                CreatedTime = DateTime.Now,
                GeneratedTime = DateTime.Now,
                Id = Guid.NewGuid(),
                Statistics = objOfStatistics,
                UserId = userId
            };

            if (genStatistics.Statistics?.Count == 0)
            {
                return BadRequest("Отсутствуют данные в выборке");
            }

            await _storage.CreateGenStatistics(genStatistics);

            return Ok(genStatistics);
        }

        /// <summary>Статистика тренировки</summary>
		/// <returns>Идентификатор созданной цели</returns>
		[HttpPost("training")]
        [ProducesResponseType(typeof(Training), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GenStatistics>> GenTrainingStatistics([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo, [FromQuery] string userId)
        {
            var daysCount = (dateTo - dateFrom).TotalDays;
            if (daysCount > 366)
                return BadRequest();

            var isNotNewGen = await _storage.GetGenStatisticsByDate(DateTime.Now, userId, "Training");
            if (isNotNewGen)
                return BadRequest();

            var training = await _storage.GetTrainingsByPeriodInclude(dateFrom, dateTo);

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
                        UserId = userId,
                        CategoryCode = "Training",
                        Description = "",
                        Code = approach.Exercise.Id.ToString(),
                        Name = approach.Exercise.ShortName ?? approach.Exercise.Name
                    };

                    objOfStatistics.Add(localObjOfStatistics);
                }

                var selectTraining = training.FirstOrDefault(e => e.Approachs.Any(z => z.Id == approach.Id));



                if (approach?.ApproachsItems?.Length > 0)
                {
                    localObjOfStatistics.StatisticsIndicators.Add(new StatisticsIndicator
                    {
                        DateOfMeasurement = selectTraining.TrainingDate ?? selectTraining.CreatedDate,
                        ObjectCode = localObjOfStatistics.Id,
                        Value = approach.ApproachsItems.Average(e => e.Weight).ToString()
                    });
                }
            }

            var genStatistics = new GenStatistics
            {
                CategoryCode = "Training",
                CreatedTime = DateTime.Now,
                GeneratedTime = DateTime.Now,
                Id = Guid.NewGuid(),
                Statistics = objOfStatistics,
                UserId = userId
            };

            if (genStatistics.Statistics?.Count == 0)
            {
                return BadRequest("Отсутствуют данные в выборке");
            }

            await _storage.CreateGenStatistics(genStatistics);

            return Ok(genStatistics);
        }
    }
}
