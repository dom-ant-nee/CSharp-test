# Extension Tasks and Additional Details

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

