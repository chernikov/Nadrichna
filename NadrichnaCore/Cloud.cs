using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaCore
{
    public class Cloud : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Cloud moves on the sky");
        }
    }
}
