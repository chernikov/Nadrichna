using NadrichnaWeb.Db;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;


namespace NadrichnaWeb.Tests.Mocks
{
    public class MockPlayerRepository : IPlayerRepository
    {
        public Player Create(Player player)
        {
            throw new NotImplementedException();
        }

        public Player Get(int id)
        {
            return new Player()
            {
                Tasks = new List<Task>()
                {
                    new Task()
                }
            };
        }

        public List<Player> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
