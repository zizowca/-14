using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            Console.ReadKey();
        }
        abstract class Animal
        {
            
            public abstract string Type { get; set; }
            public Animal(string type)
            {
                Type = type;
            }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.Write("Вид животного:\t{0},\nХарактерный звук животного:\t", Type);
                Say();
            }
        }
        class Cat : Animal
        {
          
            public Cat(string type)
                : base(type)
            { Type = type; }

            public override string Type {get; set;}

            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
        }
        class Dog : Animal
        {
            
            public Dog(string type)
              : base(type)
            { type = Type; }


            public override string Type { get; set; }
            

            public override void Say()
            {
                Console.WriteLine("Гав");
            }
        }

    }
}
