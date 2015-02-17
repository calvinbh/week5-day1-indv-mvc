using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week5_day1_indv.Models
{
    public class Other : Animal
    {
        public Other(string name, int age, int id)
            : base(name, age, AnimalType.Other, id)
        { 
        }
    }
}