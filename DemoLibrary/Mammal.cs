using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class Mammal
    {
        public bool IsPredator { get; set; }
        public int Age { get; set; }

        public Mammal(bool isPredator, int age)
        {
            IsPredator = isPredator;
            Age = age;
        }

        public void Anoy()
        {
            Console.WriteLine("Let me alone!");
            MakeSound();
        }

        public abstract void MakeSound();
    };


    public class Elephant : Mammal
    {
        public Elephant(int age) : base(false, age)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Törööööööö!");
        }

        public void GrabNuts()
        {
            Console.WriteLine("I can grab nuts with my trunk!");
        }
    };


    public class Tiger : Mammal
    {
        public Tiger(int age) : base(true, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Grrr!");
        }
        
        public void Hunt()
        {
            Console.WriteLine("I can hunt for food!");
        }
    }
}

