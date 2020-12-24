using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Db
{
    public class NadrichnaDbConext : DbContext, INadrichnaDbConext
    {
        public DbSet<Player> Players { get; set; }

        public NadrichnaDbConext(DbContextOptions options) : base(options)
        {

        }
    }
}
