using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NadrichnaWeb.Repos
{
    public class TaskRepository : ITaskRepository
    {
        private readonly INadrichnaDbConext dbContext;

        public TaskRepository (INadrichnaDbConext dbConext)
        {
            this.dbContext = dbConext;
        }

        public Task Complete(int id)
        {
            var task = dbContext.Tasks.FirstOrDefault(p => p.Id == id);
            if(task != null)
            {
                task.Completed = true;
                task.CompleteDate = DateTime.Now;
            }
            dbContext.SaveChanges();
            return task;
        }

        public Task Create(Task task)
         {
            dbContext.Tasks.Add(task);
            var taskList = dbContext.Tasks.ToList();
            List<Task> taskListByPlayerId = new List<Task>();
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].PlayerId == task.PlayerId)
                    taskListByPlayerId.Add(taskList[i]);
            }
            var player = dbContext.Players.FirstOrDefault(p => p.Id == task.PlayerId);
            player.Tasks = taskListByPlayerId;
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
           var entity = dbContext.Tasks.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                dbContext.Tasks.Remove(entity);
                dbContext.SaveChanges();
            }
        }
    }
}
