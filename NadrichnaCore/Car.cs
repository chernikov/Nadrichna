using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaCore
{
    public class Car : Vehicle
    {
        public Car(ColorEnum color) : base(color)
        {
        }

        public override void Move()
        {
            Console.WriteLine("------*@@@@*------");
            base.Move();
            Console.WriteLine("------*@@@@*------");
        }
    }
}
