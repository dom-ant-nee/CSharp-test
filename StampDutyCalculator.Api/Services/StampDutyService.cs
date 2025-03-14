using System;
using System.Collections.Generic;
using StampDutyCalculator.Api.Models;

namespace StampDutyCalculator.Api.Services
{
    /// <summary>
    /// Implementation of the stamp duty calculation service.
    /// </summary>
    public class StampDutyService : IStampDutyService
    {
        /// <summary>
        /// Calculates the stamp duty for a property purchase.
        /// </summary>
        /// <param name="request">The stamp duty calculation request.</param>
        /// <returns>The stamp duty calculation response.</returns>
        public StampDutyResponse CalculateStampDuty(StampDutyRequest request)
        {                       
            return CalculateStandardStampDuty(request);            
        }

        /// <summary>
        /// Calculates stamp duty for a standard property purchase.
        /// </summary>
        /// <param name="request">The stamp duty calculation request.</param>
        /// <returns>The stamp duty calculation response.</returns>
        private StampDutyResponse CalculateStandardStampDuty(StampDutyRequest request)
        {
            // TODO: Implement the logic for calculating standard stamp duty
            // Standard rates:
            // £0 - £125,000: 0%    
            // £125,001 - £250,000: 2%
            // £250,001 - £925,000: 5%
            // £925,001 - £1,500,000: 10%
            // £1,500,001+: 12%

            throw new NotImplementedException("Standard stamp duty calculation not implemented.");
        }
    }
} 