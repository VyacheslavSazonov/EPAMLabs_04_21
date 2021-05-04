using System;

namespace Lab2
{
    abstract class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public abstract void actions();
        public abstract void leisure();
        public void eat() 
        {
            Console.WriteLine("Ням");
        }
        public void sleep() 
        {
            Console.WriteLine("Zzzz");
        }
    }
}
