using System;

namespace AdvancedProgramming.Oop.Models
{
    public abstract class Animal
    {
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        //public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, I'm {_name}");
        }

        public abstract void GetDisplay();
    }
}
