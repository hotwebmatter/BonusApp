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
            Bonus bBonus = new Bonus("David Ecco", 600000, '4');
            WriteLine(bBonus.ToString());
            Bonus cBonus = new Bonus("Paul Gorman", 0, '2');
            WriteLine(cBonus.ToString());
            Bonus dBonus = new Bonus("Ruth Basso", 40000, '7');
            WriteLine(dBonus.ToString());
            ReadLine();
        }
    }
}
