using Microsoft.EntityFrameworkCore;

namespace NadrichnaWeb.Db
{
    public interface INadrichnaDbConext
    {
        DbSet<Player> Players { get; set; }

        int SaveChanges();
    }
}