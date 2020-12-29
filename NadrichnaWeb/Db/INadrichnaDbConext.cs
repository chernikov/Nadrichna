using Microsoft.EntityFrameworkCore;

namespace NadrichnaWeb.Db
{
    public interface INadrichnaDbConext
    {
        DbSet<Player> Players { get; set; }

        DbSet<House> Houses { get; set; }

        DbSet<Task> Tasks { get;  set; }

        int SaveChanges();
    }
}