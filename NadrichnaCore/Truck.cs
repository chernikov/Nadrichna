using System;
using System.Collections.Generic;
using System.Text;

namespace NadrichnaCore
{
    public class Truck : Vehicle
    {
        public Truck(ColorEnum color) : base(color)
        {

        }
        public override void Move()
        {
            Console.WriteLine("*@*@---------*@--");
            base.Move();
            Console.WriteLine("*@*@---------*@--");
        }
    }
}
