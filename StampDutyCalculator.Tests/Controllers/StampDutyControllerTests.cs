using System;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using StampDutyCalculator.Api.Controllers;
using StampDutyCalculator.Api.Models;
using StampDutyCalculator.Api.Services;

namespace StampDutyCalculator.Tests.Controllers
{
    public class StampDutyControllerTests
    {       
        private readonly StampDutyController _controller;

        public StampDutyControllerTests()
        {           
            _controller = new StampDutyController(null);
        }       
        
        [Fact]
        public void CalculateStampDuty_WithNullRequest_ReturnsBadRequest()
        {
            // TODO: Implement this test
            Assert.Fail("Test not implemented");
        }

        // Since we're testing the controller's validation handling (not the service),
        // how might we test this behavior without implementing the service
        [Fact]
        public void CalculateStampDuty_WithNegativePropertyValue_ReturnsBadRequest()
        {
            // TODO: Implement this test
            Assert.Fail("Test not implemented");
        }      
    }
} 