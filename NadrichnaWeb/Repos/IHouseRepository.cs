using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Repos
{
    public interface IHouseRepository
    {
        List<House> GetAll();

        House Get(int id);

        House Create(House house);

        House Update(House house);

        void Remove(int id);

    }
}
