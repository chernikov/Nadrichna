using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Db
{
    public class House
    {
        public int Id { get; set; }

        public string Adress { get; set; }

        public int RoomCount { get; set; }

        public int FloorsCount { get; set; }
    }
}
