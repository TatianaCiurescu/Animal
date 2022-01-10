using System;
using System.Collections.Generic;
using System.Text;

 namespace Animal
{
    public enum Categories
    {
        mammals,
        fishes,
        birds,
        reptiles,
        insects
    }
    public class Animals:  IFly, ICrawl, ISwim, IWalk
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public string Name { get { return name; } }
        public Categories Category { get { return category; } }
        public int MaxSpeed { get { return maxSpeed; } }

        public Animals( string name, Categories category, int maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

         public virtual void CanCrawl()
        {
            Console.WriteLine($"My name is {this.name} and I crowl at {this.maxSpeed}");
        }

        public virtual void CanWalk()
        {
            Console.WriteLine($"My name is {this.name} and I walk at {this.maxSpeed}");
        }

        public virtual void CanSwim()
        {
            Console.WriteLine($"My name is {this.name} and I swim at {this.maxSpeed}");
        }
        public virtual void CanFly()
        {
            Console.WriteLine($"My name is  {this.name} and I fly at {this.maxSpeed}");
        }
    }
}
