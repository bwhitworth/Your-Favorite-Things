using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavThings
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsFriendly { get; set; }

        public void FeedTreat(string TypeOfTreat)
        {
            Console.WriteLine($"You fed {Name} a {TypeOfTreat} treat.");
        }

        public void ShakePaw()
        {
            if (IsFriendly)
            {
                Console.WriteLine($"{Name} gave their paw for a friendly shake!");
            }
            else
            {
                Console.WriteLine($"{Name} doesn't like you, and will not shake paw.");
            }
        }
    }
}
