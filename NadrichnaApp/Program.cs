using NadrichnaCore;
using System;

namespace NadrichnaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var volgaAT2929KH = new Car(ColorEnum.Black);
            var someTruck = new Truck(ColorEnum.Gray);
            var roadster = new Cabriolet(ColorEnum.Pink);
            var bohdan = new Bus();

            volgaAT2929KH.Move();
            someTruck.Move();
            roadster.Move();
            bohdan.Move();


            Console.ReadLine();
           
                
        }
    }
}
