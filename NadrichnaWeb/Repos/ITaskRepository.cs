using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NadrichnaWeb.Db;

namespace NadrichnaWeb.Repos
{
    public interface ITaskRepository
    {
        List<_Task> GetAll();

        _Task Get(int id);

        _Task Create(_Task task);

        void Remove(int id);
    }
}
