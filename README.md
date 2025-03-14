# Stamp Duty Calculator - Coding Challenge

## Overview

This repository contains a coding challenge for a Stamp Duty Land Tax (SDLT) calculator implemented as an ASP.NET Core Web API. 

## Background

Stamp Duty Land Tax is a tax paid when purchasing property in England and Northern Ireland. The amount of tax varies based on the property value, whether the buyer is a first-time buyer, and whether the property is an additional property.

## Stamp Duty Rates

### Standard Rates 

Use the following rules to calculate the total stamp duty.
```
- Up to £125,000	Zero
- The next £125,000 (the portion from £125,001 to £250,000)	2%
- The next £675,000 (the portion from £250,001 to £925,000)	5%
- The next £575,000 (the portion from £925,001 to £1.5 million)	10%
- The remaining amount (the portion above £1.5 million)	12%
```

## Examples

### Example 1: Standard Purchase
- Property value: £675,000
- Expected stamp duty: £23,750
  - £0 - £125,000: £0 (0%)
  - £125,001 - £250,000: £2,500 (2% of £125,000)
  - £250,001 - £675,000: £21,250 (5% of £325,000)

## Your Task

Your task is to implement the missing logic in the Stamp Duty Calculator API. The repository contains a partially implemented solution with placeholder methods that you need to complete. Remember to write tests and build the best solution possible to showcase your skills.

### Requirements

1. Implement the standard stamp duty calculation logic.
2. Implement and make sure all tests pass.

### Extension Tasks

1. Implement the first-time buyer calculation logic.
2. Implement the additional property calculation logic.
3. Ensure the special rule for purchases in 2019 or earlier works correctly.
4. Make sure all tests pass.

### First-Time Buyer Rates
- £0 - £300,000: 0%
- £300,001 - £500,000: 5%
- Above £500,000: Standard rates apply - no relief can be claimed, follow standard rules.

### Additional Property Rates
```
Additional home
- Up to £125,000	5%
- The next £125,000 (the portion from £125,001 to £250,000)	7%
- The next £675,000 (the portion from £250,001 to £925,000)	10%
- The next £575,000 (the portion from £925,001 to £1.5 million)	15%
- The remaining amount (the portion above £1.5 million)	17%
```

### Special Rule
- If the purchase date is in 2019 or earlier, no stamp duty is payable (zero duty).

### Example 2: First-Time Buyer
- Property value: £500,000
- Expected stamp duty: £3,750
  - £0 - £300,000: £0 (0%)
  - £300,001 - £500,000: £3,750 (5% of £200,000)

### Example 3: Additional Property
- Property value: £620,000
- Expected stamp duty: £43,500
  - £0 - £125,000: £6,250 (5% of £125,000)
  - £125,001 - £250,000: £8,750 (7% of £125,000)
  - £250,001 - £620,000: £28,500 (10% of £370,000)

### Example 4: Purchase in 2019
- Property value: £500,000
- Purchase date: 2019-12-31
- Expected stamp duty: £0 (special rule)



### Future Enhancements

1. **Future Enhancements**: How can this be enchanced in the future and what would you implement first?

2. **Alternative Approach**: What is an alternative approach to calculating stamp duty that might be more efficient or maintainable?

3. **Architecture**: How can this be enhanced to be more maintainable and scalable? What architecture would you implement?



## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- An IDE such as Visual Studio, Visual Studio Code, or JetBrains Rider

### Building the Solution

```bash
dotnet restore
dotnet build
```

### Running the Tests

```bash
dotnet test
```

### Running the API

```bash
cd StampDutyCalculator.Api
dotnet run
```

### API Endpoints

#### Calculate Stamp Duty

```
POST /api/stampduty/calculate
```

Request body:
```json
{
  "propertyValue": 500000, 
}
```

Response:
```json
{
  "stampDutyAmount": 12500,
}
```

## Project Structure

- `StampDutyCalculator.sln`: The solution file.
- `StampDutyCalculator.Api/`: The ASP.NET Core Web API project.
  - `Controllers/`: Contains the API controllers.
  - `Models/`: Contains the request and response models.
  - `Services/`: Contains the service interfaces and implementations.
- `StampDutyCalculator.Tests/`: The test project.
  - `Controllers/`: Contains tests for the controllers.
  - `Services/`: Contains tests for the services.

## Evaluation Criteria

Your solution will be evaluated based on:

1. Correctness: Does the calculator produce the correct results for all scenarios?
2. Code quality: Is the code well-structured, readable, and maintainable?
3. Test coverage: Are scenarios adequately tested?
4. Approach: How did you approach the problem and what is your thought process?
