using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetricsController : ControllerBase
    {
        private readonly IMetricService _metricService;
        private readonly ILogger<MetricsController> _logger;
        public MetricsController(IMetricService metricService, ILogger<MetricsController> logger)
        {
            _metricService = metricService;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMetrics()
        {
            try
            {
                var result = _metricService.GetAllMetrics();
                if (result == null) throw new ArgumentNullException(nameof(result));
                _logger.LogInformation("Metrics were succsesfully loaded");
                return Ok(result);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CalculateMetrics(int id, [FromBody]string text)
        {
            try
            {
                var result = _metricService.DoMetric(id, text);
                if (result == null) throw new ArgumentNullException(nameof(result));
                _logger.LogInformation("Metrics were succsesfully loaded");
                return Ok(result);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
    }
}