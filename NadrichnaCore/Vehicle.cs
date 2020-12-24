using System;

namespace NadrichnaCore
{
    public class Vehicle : IVehicle, IMovable
    {
        public ColorEnum Color { get; set; }


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
