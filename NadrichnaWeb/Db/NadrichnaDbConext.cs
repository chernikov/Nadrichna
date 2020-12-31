using Microsoft.EntityFrameworkCore;

namespace NadrichnaWeb.Db
{
    public class NadrichnaDbConext : DbContext, INadrichnaDbConext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<House> Houses { get; set; }

        public DbSet<Task> Tasks { get;  set; }

        public NadrichnaDbConext(DbContextOptions options) : base(options)
        {

        }
    }
}
