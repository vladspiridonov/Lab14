using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write($"Имя: {Name}  Говорит:  ");
            Say();
        }
    }

    class Cat : Animal
    {
        string name;
        string sound;        
        public override string Name 
        { 
            get => name; 
            set => name=value; 
        }
        public Cat(string name, string sound)
            :base(name)        
        {           
            this.sound = sound;
        }

        public override void Say()               
        {
            Console.WriteLine(sound);
        }
    }
    class Dog : Animal
    {
        string name;
        string sound;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string sound)
            : base(name)
        {
            this.sound = sound;
        }

        public override void Say()
        {
            Console.WriteLine(sound);
        }
    }
}
