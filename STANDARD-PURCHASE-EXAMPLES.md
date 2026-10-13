# Standard purchase test examples

Use these examples to check the standard stamp duty calculation against the rate bands in [README.md](README.md).

| House price | Expected total stamp duty |
| ---: | ---: |
| £100,000 | £0.00 |
| £125,000 | £0.00 |
| £125,001 | £0.02 |
| £250,000 | £2,500.00 |
| £250,001 | £2,500.05 |
| £500,000 | £15,000.00 |
| £675,000 | £23,750.00 |
| £925,000 | £36,250.00 |
| £925,001 | £36,250.10 |
| £1,500,000 | £93,750.00 |
| £1,500,001 | £93,750.12 |
| £2,000,000 | £153,750.00 |

Apply each rate only to the portion of the price within its band. The cases at each threshold and £1 above it check that the calculator switches rates correctly. Expected amounts include pence.

For example, a £500,000 purchase incurs £0 on the first £125,000, £2,500 on the next £125,000, and £12,500 on the remaining £250,000, giving £15,000 in total.
