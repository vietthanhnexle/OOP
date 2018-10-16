using AdvancedProgramming.Oop.Models;
using System;
using System.Collections.Generic;

namespace AdvancedProgramming.Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var cat = new Cat();
            cat.SetName("Miu Miu");
            animals.Add(cat);

            var dog = new Dog();
            dog.SetName("Lu lu");
            animals.Add(dog);

            foreach (var animal in animals)
            {
                animal.SayHello();
                animal.GetDisplay();
            }
            Console.ReadKey();
        }
    }
}
