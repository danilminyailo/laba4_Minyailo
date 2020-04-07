using System;

namespace Animals
{
    abstract class MainAnimal
    {
        public double MaxHeightofFly
        {
            get { return maxheight; }
            set
            {
                if (value <= 0)
                {
                    maxheight = 0;
                    Console.WriteLine("Error: Incorrect value of height!");
                }
                else maxheight = value;
            }
        }
        public double MaxSpeed
        {
            get { return maxspeed; }
            set
            {
                if (value <= 0)
                {
                    maxspeed = 0;
                    Console.WriteLine("Error: Incorrect value of speed!");
                }
                else maxspeed = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    age = 0;
                    Console.WriteLine("Error: Incorrect value of age!");
                }
                else age = value;
            }
        }

        private int age;
        private double maxheight;
        private double maxspeed;
        public MainAnimal(double value,int age, bool fly)
        {
            Age = age;
            if (fly) MaxHeightofFly = value;
            else MaxSpeed = value;
        }
    }
}
