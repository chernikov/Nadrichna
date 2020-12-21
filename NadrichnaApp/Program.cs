using NadrichnaCore;
using System;

namespace NadrichnaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car volgaAT2929KH;
            volgaAT2929KH = new Car(ColorEnum.Black);
            Truck someTruck = new Truck(ColorEnum.Gray);

            volgaAT2929KH.Move();
            someTruck.Move();

            Console.ReadLine();
            Console.ReadLine();
                
        }
    }
}
