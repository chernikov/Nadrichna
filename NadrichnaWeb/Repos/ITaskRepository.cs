using NadrichnaWeb.Db;
using System.Collections.Generic;

namespace NadrichnaWeb.Repos
{
    public interface ITaskRepository
    {
        List<Task> GetAll();

        Task Get(int id);

        Task Create(Task task);

        Task Complete(int id);

        void Remove(int id);
    }
}
