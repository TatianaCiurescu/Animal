using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Platypus : Animals, ISwim, IWalk
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public Platypus(string name, Categories category, int maxSpeed): base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public override void CanWalk()
        {
            Console.WriteLine($"Hello! My name is {this.name}, I am a {this.GetType().Name}, part of {this.category} and I walk at {this.maxSpeed}");
        }

        public override void CanSwim()
        {
            Console.WriteLine($"Hello! My name is {this.name}, I am a {this.GetType().Name}, part of {this.category} and I swim at {this.maxSpeed}");
        }


    }
}
