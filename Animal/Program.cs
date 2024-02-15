using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("bobik", "bark");
            Cat cat = new Cat("Murzik", "meow");
            dog.ShowInfo();
            cat.ShowInfo();
            dog.Say();
            cat.Say();
            Console.ReadKey();
        }
    }
}
