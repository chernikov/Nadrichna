using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NadrichnaWeb.Repos
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly INadrichnaDbConext dbContext;

        public PlayerRepository(INadrichnaDbConext dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<Player> GetAll()
        {
            return dbContext.Players.ToList();
        }

        public Player Get(int id)
        {
            return dbContext.Players.FirstOrDefault(p => p.Id == id);
        }

        public Player Create(Player player)
        {
            dbContext.Players.Add(player);
            dbContext.SaveChanges();
            return player;
        }

        public void  Remove(int id)
        {
            var entity  = dbContext.Players.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                dbContext.Players.Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public void AddTaskToPlayer(Task task, int id)
        {
            var entity = dbContext.Players.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                entity.Tasks.Add(task);
            }
        }
    }
}
