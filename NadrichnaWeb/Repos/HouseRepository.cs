using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Repos
{
    public class HouseRepository : IHouseRepository
    {
        private readonly INadrichnaDbConext dbContext;

        public HouseRepository(INadrichnaDbConext dbContext)
        {
            this.dbContext = dbContext; 
        }

        public House Create(House house)
        {
            dbContext.Houses.Add(house);
            dbContext.SaveChanges();
            return house;
        }

        public House Get(int id)
        {
            return dbContext.Houses.FirstOrDefault(p => p.Id == id);
        }

        public List<House> GetAll()
        {
            return dbContext.Houses.ToList();
        }

        public void Remove(int id)
        {
            var house = dbContext.Houses.FirstOrDefault(p => p.Id == id);
            if (house != null)
            {
                dbContext.Houses.Remove(house);
                dbContext.SaveChanges();
            }
        }

        public House Update(House house)
        {
            var entity = dbContext.Houses.FirstOrDefault(p => p.Id == house.Id);
            if(entity != null)
            {
                entity.Address = house.Address;
                entity.FloorsCount = house.FloorsCount;
                entity.RoomCount = house.RoomCount;
                dbContext.SaveChanges();
                return entity;
            }
            else
            {
                throw new Exception("The house does not exist");
            }
        }
    }
}
