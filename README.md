# Colonial Bank Breakeven
Eighth C# assignment submitted via Blackboard.

This is a no-frills implementation of the bare specification.

The error handling could be more robust; for example it could
tell you what type of bad data you have entered, and exactly why
the input is not accepted.

The expected output for "Rosa Caili" seems to be off by $10,000.00 
in the spec (it calls for a bonus of $77,000.00 but my algorithm
calculates a bonus of only $67,000.00).

I'm confident that my algorithm is correct.

## Debugging output
```
Salesperson name is Rosa Caili
Sales amount is $1,500,000.00
Standard bonus rate is 4.00%
Incentive bonus rate is 5.00%
Sales code is 2
Base bonus is $40,000.00
Incentive bonus is $25,000.00
Code bonus is $2,000.00
Total bonus is $67,000.00
Bad Data flag set to False
Bonus is $67,000.00

Salesperson name is David Ecco
Sales amount is $600,000.00
Standard bonus rate is 4.00%
Incentive bonus rate is 5.00%
Sales code is 4
Base bonus is $24,000.00
Incentive bonus is $0.00
Code bonus is $1,000.00
Total bonus is $25,000.00
Bad Data flag set to False
Bonus is $25,000.00

Bad Data
Bad Data
```
