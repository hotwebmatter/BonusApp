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
        double incentiveBonus;
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

        private void SetBonus()
        {
            if (salesAmount <= 0)
            {
                badData = true;
            }
            else
            {
                if (salesAmount < 1000000)
                {
                    baseBonus = salesAmount * STANDARD_BONUS_RATE;
                }
                else
                {
                    baseBonus = 1000000 * STANDARD_BONUS_RATE;
                    incentiveBonus = (salesAmount - 1000000) * INCENTIVE_BONUS_RATE;
                }

                totalBonus = baseBonus + incentiveBonus + GetSalesCodeBonus();
            }
        } // end SetBonus() method

        public double GetSalesCodeBonus()
        {
            codeBonus = 0; // initialize value to prevent null return
            switch (salesCode)
            {
                case '1': codeBonus = 2500;
                    break;
                case '2': codeBonus = 2000;
                    break;
                case '3': codeBonus = 1500;
                    break;
                case '4': codeBonus = 1000;
                    break;
                default: badData = true;
                    break;
            }
            return codeBonus;
        } // end GetSalesCodeBonus() method

        public override string ToString()
        {
            badData = false; // initialize flag
            string str = string.Empty; // initialize string
            SetBonus(); // execute method to calculate results
            if (badData)
            {
                return "Bad Data";
            }
            else
            {
                str += string.Format("Salesperson name is {0}\n", salespersonName);
                str += string.Format("Sales amount is {0:c}\n", salesAmount);
                str += string.Format("Standard bonus rate is {0:P}\n", STANDARD_BONUS_RATE);
                str += string.Format("Incentive bonus rate is {0:P}\n", INCENTIVE_BONUS_RATE);
                str += string.Format("Sales code is {0}\n", salesCode);
                str += string.Format("Base bonus is {0:c}\n", baseBonus);
                str += string.Format("Incentive bonus is {0:c}\n", incentiveBonus);
                str += string.Format("Code bonus is {0:c}\n", codeBonus);
                str += string.Format("Total bonus is {0:c}\n", totalBonus);
                str += string.Format("Bad Data flag set to {0}\n", badData);
                str += string.Format("Bonus is {0:c}\n", totalBonus);
            }
            return str;
        }
    }
}
