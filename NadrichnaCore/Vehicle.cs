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
            var type = this.GetType().Name;
            Console.WriteLine($"{Color} {type}. I'm moving...");
        }
    }
}
