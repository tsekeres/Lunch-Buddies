using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name { get; set; }
        private List<string> RestaurantNames { get; set; } = new List<string>();

        public Restaurant()
        {
            RestaurantNames.Add("Baja Burrito");
            RestaurantNames.Add("Taco Bell");
            RestaurantNames.Add("Moe's");
            RestaurantNames.Add("Chipotle");

            Random any = new Random();
            int anyRestaurant = any.Next(0, RestaurantNames.Count);
            Name = RestaurantNames[anyRestaurant];
        }


    }
}
