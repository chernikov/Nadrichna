using NadrichnaCore;
using System;
using System.Collections.Generic;

namespace NadrichnaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IVehicle>();
            list.Add(new Car(ColorEnum.Black));
            list.Add(new Truck(ColorEnum.Gray));
            list.Add(new Cabriolet(ColorEnum.Pink));
            list.Add(new Bus());
            //list.Add(new Cloud());
            foreach(var item in list)
            {
                item.Move();
            }
            Console.ReadLine();
        }
    }
}
