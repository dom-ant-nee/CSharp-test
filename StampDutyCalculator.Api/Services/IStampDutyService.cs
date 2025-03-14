using StampDutyCalculator.Api.Models;

namespace StampDutyCalculator.Api.Services
{
    /// <summary>
    /// Service interface for calculating stamp duty on property purchases.
    /// </summary>
    public interface IStampDutyService
    {
        /// <summary>
        /// Calculates the stamp duty for a property purchase.
        /// </summary>
        /// <param name="request">The stamp duty calculation request.</param>
        /// <returns>The stamp duty calculation response.</returns>
        StampDutyResponse CalculateStampDuty(StampDutyRequest request);
    }
} 