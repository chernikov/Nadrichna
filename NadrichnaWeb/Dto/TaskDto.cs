using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public string Name { get; set; }

        public bool Completed { get; set; }

        public int CompleteDay { get; set; }

        public int CompleteHour { get; set; }

        public int CompleteMinute { get; set; }

    }
}
