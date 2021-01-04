using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Dto
{
    public class PlayerDto
    {
        public int Id { get; set; }

        public int? HouseId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public int BirthdayDay { get; set; }

        public int BirthdayMonth { get; set; }

        public int BirthdayYear { get; set; }


    }
}
