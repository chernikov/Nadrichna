using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NadrichnaWeb.Repos
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();

        Player Get(int id);

        void AddTaskToPlayer(Task task, int id);

        Player Create(Player player);

        void Remove(int id);

    }
}
