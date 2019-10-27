using System;
using static System.Console;

namespace BonusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonus aBonus = new Bonus("Rosa Caili", 1500000, '2');
            WriteLine(aBonus.ToString());
            ReadLine();
        }
    }
}
