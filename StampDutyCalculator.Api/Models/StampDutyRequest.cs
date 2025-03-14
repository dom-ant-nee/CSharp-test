using System;

namespace StampDutyCalculator.Api.Models
{
    /// <summary>
    /// Represents a request to calculate stamp duty on a property purchase.
    /// </summary>
    public class StampDutyRequest
    {
        /// <summary>
        /// The purchase price of the property in GBP.
        /// </summary>
        public decimal PropertyValue { get; set; }       
    }
} 