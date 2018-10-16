using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.Oop.Models
{
    public class Dog : Animal
    {
        public override void GetDisplay()
        {
            Console.WriteLine("I'm a dog");
        }
    }
}
