using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat piestanska = new Flat(24, 100, 4);
            Flat vansova = new Flat(42, 95, 6);
            piestanska.AddHabitant("Matej", "Kovac", 17);
            piestanska.AddHabitant("Martin", "Holena", 17);
            piestanska.AddHabitant("Jakub", "Venetianer", 8);


            vansova.AddHabitant("Michal", "Turcel", 18);
            Console.WriteLine(piestanska.ToString());
            piestanska.GetInfoAboutAllHabitants();

            Console.WriteLine(vansova.ToString());
            vansova.GetInfoAboutAllHabitants();
        }
    }
}