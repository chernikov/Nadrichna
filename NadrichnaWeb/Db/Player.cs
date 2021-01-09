using System;
using System.Collections.Generic;

namespace NadrichnaWeb.Db
{
    public class Player
    {
        public int Id { get; set; }

        public int? HouseId { get; set; }  

        public House House { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<Task> Tasks { get; set; }

    }
}
