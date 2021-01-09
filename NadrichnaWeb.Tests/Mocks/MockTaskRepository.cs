using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NadrichnaWeb.Tests.Mocks
{
    class MockTaskRepository : ITaskRepository
    {
        private readonly INadrichnaDbConext dbContext;

        public MockTaskRepository(INadrichnaDbConext dbConext)
        {
            this.dbContext = dbConext;
        }

        public Task Complete(int id)
        {
            var task = dbContext.Tasks.FirstOrDefault(p => p.Id == id);

            if (task != null)
            {
                task.Completed = true;
                dbContext.SaveChanges();
                return task;
            }
            return null;
        }

        public Task Create(Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
            return task;
        }

        public Task Get(int id)
        {
            return dbContext.Tasks.FirstOrDefault(p => p.Id == id);
        }

        public List<Task> GetAll()
        {
            return dbContext.Tasks.ToList();
        }

        public void Remove(int id)
        {
            var task = dbContext.Tasks.FirstOrDefault(p => p.Id == id);

            if(task != null)
            {
                dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }

        }
    }
}
