using System;

namespace NadrichnaCore
{
    public class Vehicle
    {
        public ColorEnum Color;


        public Vehicle(ColorEnum color)
        {
            this.Color = color;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Color}. I'm moving...");
        }
    }
}
