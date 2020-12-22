using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaCore
{
    public class Bus : Vehicle
    {
        public Bus() : base(ColorEnum.Yellow)
        {
            AmountOfSeats = 20;
        }

        public int AmountOfSeats { get; set; }


        public override void Move()
        {
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+");
            base.Move();
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+");
        }
    }
}
