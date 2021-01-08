using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Dto
{
    public class PlayerDto : PlayerBaseDto
    {
        public int? HouseId { get; set; }

        public int BirthdayDay { get; set; }

        public int BirthdayMonth { get; set; }

        public int BirthdayYear { get; set; }

        public List<TaskDto> Tasks { get; set; }

    }
}
