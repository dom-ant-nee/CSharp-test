using System.Collections.Generic;

namespace StampDutyCalculator.Api.Models
{
    /// <summary>
    /// Represents the response containing the calculated stamp duty.
    /// </summary>
    public class StampDutyResponse
    {
        /// <summary>
        /// The calculated stamp duty amount in GBP.
        /// </summary>
        public decimal StampDutyAmount { get; set; }

    }  
} 