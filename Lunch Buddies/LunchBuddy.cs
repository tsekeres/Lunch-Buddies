using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat()
        {
            var LunchPick = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {LunchPick.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} in the office lunch room.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var LunchPick = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {LunchPick.Name}");

            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var LunchPick = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {LunchPick.Name} and they ordered {food}. They are eating with:");
            foreach (var companion in companions)
                {
                    Console.WriteLine(companion.FirstName);
                }
        }
    }
}
