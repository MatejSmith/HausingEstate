using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Flat
    {
        public List<Person> persones = new List<Person>();
            
        private int flatNumber;
        private int area;
        private int numberOfRooms;

        public Flat(int flatNumber, int area, int numberOfRooms)
        {
            this.flatNumber = flatNumber;
            this.area = area;
            this.numberOfRooms = numberOfRooms;
        }
        public override string ToString()
        {
            return $"FlatNumber: {this.flatNumber} \narea: {this.area} \nnumberOfRooms: {this.numberOfRooms}";
        }
        public void AddHabitant(string name, string surname, int age)
        {
            Person habitant = new Person(name, surname, age);
            persones.Add(habitant);
        }

        public void HabitantsInfo()
        {
            for (int i = 0; i < persones.Count; i++)
            {
                Console.WriteLine($"{persones[i]}");
            }
        }
    }
}