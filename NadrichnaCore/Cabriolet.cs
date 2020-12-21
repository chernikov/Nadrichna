using System;
using System.Collections.Generic;
using System.Text;

namespace NadrichnaCore
{
    public class Cabriolet: Vehicle

    {
        public Cabriolet(ColorEnum color) : base(color)
        {

        }
        public override void Move()
        {
            Console.WriteLine("<3<3<3<3<3<3<3<3<3<3<3<3");
            base.Move();
            Console.WriteLine("<3<3<3<3<3<3<3<3<3<3<3<3");
        }
    }
}

