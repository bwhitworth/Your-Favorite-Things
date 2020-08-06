using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Your_Favorite_Things.FavThings
{
    class Lizard
    {
        public string Color { get; set; }

        public string FavoriteFood { get; set; }

        public void ChangeColor(string col)
        {
            Console.WriteLine($"The lizard changed its color to {col}.");
            Color = col;
        }

        public void WishForFood()
        {
            Console.WriteLine($"The lizard wishes it had {FavoriteFood} to eat, right now...");
        }
    }
}
