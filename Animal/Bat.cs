using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Bat: Animals, IFly
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public Bat(string name, Categories category, int maxSpeed) : base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public override void CanFly()
        {
            Console.WriteLine($"Hello! My name is {this.name}, I am a {this.GetType().Name}, part of {this.category} and I fly at {this.maxSpeed}");
        }
    }
}
