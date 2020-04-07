using System;

namespace Animals
{
    class Eagle : MainAnimal, IAnimal
    {
        public Eagle(double value, int age, bool fly) : base(value, age, fly) { }
        public void Move()
        {
            Console.WriteLine("Eagle starts fling!");
        }
        public void Born()
        {
            Console.WriteLine("Eagle was born!");
        }
        public void Die()
        {
            Console.WriteLine("Eagle was died!");
        }
        public void StopMoving()
        {
            Console.WriteLine("Eagle stoped!");
        }
        public Tuple<int, double> GetInfo()
        {
            MainAnimal eq = this as MainAnimal;
            return new Tuple<int, double>(eq.Age, eq.MaxHeightofFly);
        }
    }
    class Parrot : MainAnimal, IAnimal
    {
        public Parrot(double value, int age, bool fly) : base(value, age, fly) { }
        public void Move()
        {
            Console.WriteLine("Parrot starts fling!");
        }
        public void Born()
        {
            Console.WriteLine("Parrot was born!");
        }
        public void Die()
        {
            Console.WriteLine("Parrot was died!");
        }
        public void StopMoving()
        {
            Console.WriteLine("Parrot stoped!");
        }
        public Tuple<int, double> GetInfo()
        {
            MainAnimal eq = this as MainAnimal;
            return new Tuple<int, double>(eq.Age, eq.MaxHeightofFly);
        }
    }
    class Pinguin : MainAnimal, IAnimal
    {
        public Pinguin(double value, int age, bool fly) : base(value, age, fly) { }
        public void Move()
        {
            Console.WriteLine("Pinguin starts running!");
        }
        public void Born()
        {
            Console.WriteLine("Pinguin was born!");
        }
        public void Die()
        {
            Console.WriteLine("Pinguin was died!");
        }
        public void StopMoving()
        {
            Console.WriteLine("Pinguin stoped!");
        }
        public Tuple<int, double> GetInfo()
        {
            MainAnimal eq = this as MainAnimal;
            return new Tuple<int, double>(eq.Age, eq.MaxSpeed);
        }
    }
    class Straus : MainAnimal, IAnimal
    {
        public Straus(double value, int age, bool fly) : base(value, age, fly) { }

        public void Move()
        {
            Console.WriteLine("Straus starts running!");
        }
        public void Born()
        {
            Console.WriteLine("Straus was born!");
        }
        public void Die()
        {
            Console.WriteLine("Straus was died!");
        }
        public void StopMoving()
        {
            Console.WriteLine("Straus stoped!");
        }
        public Tuple<int, double> GetInfo()
        {
            MainAnimal eq = this as MainAnimal;
            return new Tuple<int, double>(eq.Age, eq.MaxSpeed);
        }
    }
}
