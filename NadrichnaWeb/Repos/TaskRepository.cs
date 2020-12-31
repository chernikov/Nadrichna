using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Repos
{
    public class TaskRepository : ITaskRepository
    {
        private readonly INadrichnaDbConext dbConext;

        public TaskRepository (INadrichnaDbConext dbConext)
        {
            this.dbConext = dbConext;
        }

         public _Task Create(_Task task)
        {
            dbConext.Tasks.Add(task);
            dbConext.SaveChanges();
            return task;
        }

        public _Task Get(int id)
        {
            return dbConext.Tasks.FirstOrDefault(p => p.Id == id);
        }

        public List<_Task> GetAll()
        {
            return dbConext.Tasks.ToList();
        }

        public void Remove(int id)
        {
           var entity = dbConext.Tasks.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                dbConext.Tasks.Remove(entity);
                dbConext.SaveChanges();
            }
        }
    }
}
