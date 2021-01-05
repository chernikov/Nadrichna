using System;

namespace NadrichnaWeb.Db
{
    public class Task
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public string Name { get; set; }

        public bool Completed { get; set; }

        public DateTime CompleteDate { get; set; }

    }
}

