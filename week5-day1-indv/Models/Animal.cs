using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week5_day1_indv.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public AnimalType AnimalType { get; set; }
        public int ID { get; set; }

        public Animal(string name, int age, AnimalType type, int id)
        {
            Name = name;
            Age = age;
            AnimalType = type;
            ID = id;

        }

        public Animal()
        { 
        }
    }

    
    

    public enum AnimalType
    {
        Dog,
        Cat,
        Bird,
        Other
    }
}