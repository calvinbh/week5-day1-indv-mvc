using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week5_day1_indv.Models
{
    public class DB
    {
        public List<Animal> Animals { get; set; }
        public static DB Instance
        { 
            get
            {
                return _instance ?? (_instance = CreateDB());
            }
        }
        private static DB _instance;

        private static DB CreateDB()
        {
            return new DB()
            {
                Animals = new List<Animal>()
                {
                    new Dog("Rex", 1, 1),
                    new Bird("Tweety", 3, 2),
                    new Cat("Felix", 8, 3),
                    new Cat("Simon", 0, 4),
                    new Dog("Melvin", 4, 5),
                    new Bird("Zeek", 1, 6),
                    new Other("Liz", 1, 7),
                    new Dog("Fury", 5, 8),
                    new Dog("Willard", 6, 9),
                    new Dog("George", 3, 10),
                    new Cat("Bubbles", 2, 11),
                    new Cat("Red", 2, 12),
                    new Dog("Kibby", 3, 13),
                    new Cat("Twix", 6, 14),
                    new Dog("Pete", 4, 15),
                    new Dog("Yogi", 1, 16),
                    new Cat("Toni", 1, 17),
                    new Cat("Fry", 2, 18),
                    new Dog("Rough Neck", 9, 19),
                    new Bird("Eagle", 3, 20),
                    new Dog("Monster", 3, 21),
                    new Cat("Ronnie", 1, 22),
                    new Other("Nixon", 1, 23),
                    new Other("Steve", 0, 24)

                }
            };
        }
        private DB()
        { 
        }
    }
}