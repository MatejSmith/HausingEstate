using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat piestanska = new Flat(24, 100, 4);
            piestanska.AddHabitant("Matej", "Kovac", 17);

            piestanska.HabitantsInfo();
            Console.WriteLine(piestanska.ToString());
        }
    }
}