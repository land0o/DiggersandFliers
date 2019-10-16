using System;
using System.Collections.Generic;

namespace DiggersandFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aquarium
            Zoo.Salmon Sally = new Zoo.Salmon();
            Zoo.SeaTurtle Sealy = new Zoo.SeaTurtle();
            Zoo.Terrapins Terry = new Zoo.Terrapins();
            Zoo.Earthworms Earthy = new Zoo.Earthworms();
            Zoo.TimberRattlesnake Timmy = new Zoo.TimberRattlesnake();
            Zoo.BettaFish Betty = new Zoo.BettaFish();
            Zoo.CopperheadSnake Corey = new Zoo.CopperheadSnake();
            //container
            Aquarium aquarium1 = new Aquarium();
            // adding critters to an Aquarium
            aquarium1.aquarium.Add(Sally);
            aquarium1.aquarium.Add(Sealy);
            aquarium1.aquarium.Add(Terry);
            aquarium1.aquarium.Add(Earthy);
            aquarium1.aquarium.Add(Timmy);
            aquarium1.aquarium.Add(Betty);
            aquarium1.aquarium.Add(Corey);

            // print critters
            // shows the type of animal nt their names
            foreach (var critters in aquarium1.aquarium)
            {
                Console.WriteLine(critters);
            }

        }
    }
}
