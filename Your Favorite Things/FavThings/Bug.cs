using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavThings
{
    class Bug
    {
        public string Species { get; set; }
        public bool IsPoisonous { get; set; }

        public void Attack()
        {
            if (IsPoisonous)
            {
                Console.WriteLine($"The {Species} attacked! You have been poisoned!");
            }
            else
            {
                Console.WriteLine($"The {Species} is harmless and won't hurt you.");
            }
        }

        public void Crawl()
        {
            Console.WriteLine($"The {Species} creeped across the floor...");
        }
    }
}
