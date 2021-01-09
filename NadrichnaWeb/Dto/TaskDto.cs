using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace NadrichnaWeb.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public PlayerBaseDto Player { get; set; }

        public string Name { get; set; }

        public bool Completed { get; set; }

        public int CompleteDay { get; set; }

        public int CompleteHour { get; set; }

        public int CompleteMinute { get; set; }

    }
}
