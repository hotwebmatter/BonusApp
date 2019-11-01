# BonusApp
Eighth C# assignment submitted via Blackboard.

This is (mostly) a no-frills implementation of the specification.

I did add some input validation to prevent errors that were actually
causing the program to crash on bad input.

The error handling could be more robust; for example it could
tell you what type of bad data you have entered, and exactly why
the input is not accepted, instead of just saying "Bad Data".

## Example output
```
**************************************************
        Bonus
        Calculate bonus for sales employees
        Matthew Obert
        October 27 2019
**************************************************
This program will determine bonus for employees.

You will be asked to enter sales name, sales,
and employee code.

**************************************************
Enter salesperson name: Rosa Caili
Enter sales amount (in dollars): 1500000
Enter sales code (1, 2, 3, or 4 only): 2

**************************************************

Bonus is $67,000.00
```
The expected output for "Rosa Caili" seems to be off by $10,000.00 
in the spec.

(It calls for a bonus of $77,000.00 but my algorithm
calculates a bonus of only $67,000.00.)

I'm confident that my algorithm is correct. See below:

## Debugging input
```
using System;
using static System.Console;

namespace BonusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonus aBonus = new Bonus("Rosa Caili", 1500000, '2');
            WriteLine(aBonus.GetDebugInfo());
            Bonus bBonus = new Bonus("David Ecco", 600000, '4');
            WriteLine(bBonus.GetDebugInfo());
            Bonus cBonus = new Bonus("Paul Gorman", 0, '2');
            WriteLine(cBonus.GetDebugInfo());
            Bonus dBonus = new Bonus("Ruth Basso", 40000, '7');
            WriteLine(dBonus.GetDebugInfo());
            ReadLine();
        }
    }
}

```
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

Three out of the four test cases match the expected output
in the problem specification. Only the first example is off.
