using System;
using Xunit;
using StampDutyCalculator.Api.Models;
using StampDutyCalculator.Api.Services;

namespace StampDutyCalculator.Tests.Services
{
    public class StampDutyServiceTests
    {
        private readonly StampDutyService _service;

        public StampDutyServiceTests()
        {
            _service = new StampDutyService();
        }      

        // We might want to test this with a range of values to ensure the calculation is correct for different property values, how might we do this?
        [Fact]
        public void CalculateStampDuty_StandardPurchase_CalculatesCorrectly()
        {
            // TODO: Implement this test         
            Assert.Fail("Test not implemented");
        }      
    }
} 