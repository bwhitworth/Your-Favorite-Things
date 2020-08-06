using System;
using Your_Favorite_Things.FavThings;

namespace Your_Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogMylo = new Dog
            {
                Name = "Mylo",
                IsFriendly = false
            };
            var dogBug = new Dog
            {
                Name = "Bug",
                IsFriendly = true
            };
            var masGiraffe = new Giraffe
            {
                Species = GiraffeSpecies.Masai,
                TongueInches = 24
            };
            var retGiraffe = new Giraffe
            {
                Species = GiraffeSpecies.Reticulated,
                TongueInches = 27
            };
            var ladybug = new Bug
            {
                IsPoisonous = false,
                Species = "ladybug"
            };
            var tarantula = new Bug
            {
                IsPoisonous = true,
                Species = "tarantula"
            };
            var gecko = new Lizard
            {
                Color = "yellow",
                FavoriteFood = "crickets"
            };
            var chameleon = new Lizard
            {
                Color = "green",
                FavoriteFood = "katydids"
            };
            Console.WriteLine("DOGS:");
            dogMylo.ShakePaw();
            dogBug.FeedTreat("bacon");
            Console.WriteLine("GIRAFFES:");
            masGiraffe.Stretch();
            retGiraffe.MeasureTongue();
            Console.WriteLine("LIZARDS:");
            gecko.WishForFood();
            chameleon.ChangeColor("orange");
            Console.WriteLine("BUGS:");
            ladybug.Crawl();
            tarantula.Attack();
        }
    }
}
