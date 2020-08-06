using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavThings
{
    class Giraffe
    {
        public GiraffeSpecies Species { get; set; }

        public int TongueInches { get; set; }

        public void Stretch()
        {
            Console.WriteLine($"The {Species} giraffe stretched its long neck toward the sky...");
        }

        public void MeasureTongue()
        {
            Console.WriteLine($"The giraffe stuck its tongue out... you measured it as {TongueInches} inches long.");
        }

    }

    enum GiraffeSpecies
    {
        Reticulated = 1,
        Masai,
        Rothschild,
        Northern,
        Southern
    }
}
