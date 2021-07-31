using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lunch Buddies!");
            LunchBuddy tad = new LunchBuddy("Tad", "Sekeres");
            LunchBuddy henry = new LunchBuddy("Henry", "Sekeres");
            LunchBuddy geo = new LunchBuddy("Geo", "Sekeres");
            LunchBuddy lily = new LunchBuddy("Lily", "Sekeres");

            List<LunchBuddy> companions = new List<LunchBuddy>();
            companions.Add(henry);
            companions.Add(geo);
            companions.Add(lily);

            tad.Eat();
            tad.Eat("burrito");
            tad.Eat(companions);
            tad.Eat("pizza", companions);
        }
    }
}
