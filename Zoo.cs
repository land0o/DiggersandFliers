using System;

namespace DiggersandFliers
{
    public class Zoo
    {

        public class Dog : IWalking
        {
            public void Run()
            {
                Console.WriteLine("Animal is running");
            }
            public void Walk()
            {
                Console.WriteLine("Animal is currently walking");
            }
        }
        public class SeaTurtle : IWalking, ISwimming
        {
            public int MaximumDepth { get; } = 100;
            public void Run()
            {
                Console.WriteLine("Animal is running");
            }
            public void Walk()
            {
                Console.WriteLine("Animal is currently walking");
            }

            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }
        public class Salmon : ISwimming
        {
            public int MaximumDepth { get; } = 100;
            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }

        public class Parakeets : IFlyable
        {
            public bool BirdHouse { get; set; }

            public void Fly()
            {
                System.Console.WriteLine("Can Fly");
            }

            public void LivesInBirdHouse()
            {
                BirdHouse = true;
            }
        }
        public class Earthworms : IDigable, IGroundable, ISwimming
        {
            public int GroundDepth { get; } = 25;
            public int MaximumDepth { get; } = 5;


            public bool LiveonGround { get; set; } = false;

            public int NumbOfLegs { get; set; } = 0;

            public void Dig()
            {
                System.Console.WriteLine("DIGGGGGGGGGG!!!!");
            }
            public void Swim()
            {
                Console.WriteLine("I can live in water but i dont really swim");
            }
        }
        public class Terrapins : ISwimming, IGroundable
        {
            public int MaximumDepth { get; } = 50;
            public bool LiveonGround { get; set; } = false;
            public int NumbOfLegs { get; set; } = 4;

            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }
        public class TimberRattlesnake : IGroundable, ISwimming
        {

            public bool LiveonGround { get; set; } = true;

            public int NumbOfLegs { get; set; } = 0;

            public int MaximumDepth { get; } = 10;

            public void Swim()
            {
                System.Console.WriteLine("Yup I eat fish as well..");
            }
        }
        public class Mice : IGroundable
        {

            public bool LiveonGround { get; set; } = true;

            public int NumbOfLegs { get; set; } = 4;

        }
        public class Ants : IGroundable, IDigable
        {

            public bool LiveonGround { get; set; } = false;

            public int NumbOfLegs { get; set; } = 6;

            public int GroundDepth { get; } = 25;

            public void Dig()
            {
                System.Console.WriteLine("DIGGGGGGGGGGG!!!!");
            }
        }
        public class Finches : IFlyable
        {
            public bool BirdHouse { get; set; }

            public void Fly()
            {
                System.Console.WriteLine("Can Fly");
            }

            public void LivesInBirdHouse()
            {
                BirdHouse = true;
            }
        }
        public class BettaFish : ISwimming
        {
            public int MaximumDepth { get; } = 100;
            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }
        public class CopperheadSnake : IGroundable, ISwimming
        {

            public bool LiveonGround { get; set; } = true;

            public int NumbOfLegs { get; set; } = 0;
            public int MaximumDepth { get; } = 10;

            public void Swim()
            {
                System.Console.WriteLine("Yup I eat fish as well..");
            }
        }

    }
    public class Gerbils : IGroundable
    {

        public bool LiveonGround { get; set; } = true;

        public int NumbOfLegs { get; set; } = 4;

    }
}
