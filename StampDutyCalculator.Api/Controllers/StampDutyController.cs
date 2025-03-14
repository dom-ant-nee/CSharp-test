using Microsoft.AspNetCore.Mvc;
using StampDutyCalculator.Api.Models;
using StampDutyCalculator.Api.Services;
using System;

namespace StampDutyCalculator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StampDutyController : ControllerBase
    {
        private readonly IStampDutyService _stampDutyService;

        public StampDutyController(IStampDutyService stampDutyService)
        {
            _stampDutyService = stampDutyService;
        }

        /// <summary>
        /// Calculates the stamp duty for a property purchase.
        /// </summary>
        /// <param name="request">The stamp duty calculation request.</param>
        /// <returns>The stamp duty calculation response.</returns>
        [HttpPost("calculate")]
        public ActionResult<StampDutyResponse> CalculateStampDuty(StampDutyRequest request)
        {
            try
            {
                var response = _stampDutyService.CalculateStampDuty(request);
                return Ok(response);
            }
            catch (NotImplementedException ex)
            {
                // How might we handle this in a real application?
                return StatusCode(501, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
} 