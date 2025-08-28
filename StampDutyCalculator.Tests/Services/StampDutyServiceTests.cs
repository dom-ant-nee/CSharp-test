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

        // Hint: Validate a variety of price→expected duty examples without repeating near-identical tests.
        // How could we express these cases compactly?
        [Fact]
        public void CalculateStampDuty_StandardPurchase_CalculatesCorrectly()
        {
            // TODO: Implement this test         
            Assert.Fail("Test not implemented");
        }      
    }
} 