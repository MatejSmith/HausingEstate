using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override string ToString()
        {
            return $"name: {this.name} \nsurname: {this.surname} \nage: {this.age} \n";
        }
    }
}