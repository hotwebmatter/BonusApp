using System;
using System.Collections.Generic;
using System.Text;

namespace BonusApp
{
    class Bonus
    {
        // private properties
        string salespersonName;
        double salesAmount;
        const double STANDARD_BONUS_RATE = .04;
        const double INCENTIVE_BONUS_RATE = .05;
        char salesCode;
        double baseBonus;
        double codeBonus;
        double totalBonus;
        bool badData;

        public Bonus()
        {
            // constructor without arguments
        }

        public Bonus(string name, double sales, char code)
        {
            // overloaded constructor with arguments
            salespersonName = name;
            salesAmount = sales;
            salesCode = code;
        }

        // property mutator methods (setters)
        public string SalespersonName
        {
            set { salespersonName = value; }
        }
        public double SalesAmount
        {
            set { salesAmount = value; }
        }
        public char SalesCode
        {
            set { salesCode = value; }
        }
    }
}
