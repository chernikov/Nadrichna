using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Api
{
    [Route("api/house")]
    public class HouseController : Controller
    {
        private readonly INadrichnaDbConext dbConext;

        public HouseController(INadrichnaDbConext dbConext)
        {
            this.dbConext = dbConext;
        }

        //get list

        [HttpGet]
        public IActionResult Get()
        {
            var list = dbConext.Houses.ToList();
            return Ok(list);
        }

        //get item

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = dbConext.Houses.FirstOrDefault(p => p.Id == id);
            return Ok(entity);
        }

        //add

        [HttpPost]

        public IActionResult Add([FromBody] House house)
        {
            dbConext.Houses.Add(house);
            dbConext.SaveChanges();
            return Ok();
        }

        //delete

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var entity = dbConext.Houses.FirstOrDefault(p => p.Id == id);
            dbConext.Houses.Remove(entity);
            dbConext.SaveChanges();
            return Ok(entity);
        }

        //update*

        [HttpPut]
        public IActionResult Put([FromBody] House house)
        {
            var entity = dbConext.Houses.FirstOrDefault(p => p.Id == house.Id);

            if(entity != null)
            {
                entity.Address = house.Address;
                entity.FloorsCount = house.FloorsCount;
                entity.RoomCount = house.RoomCount;
            }
            dbConext.SaveChanges();
            return Ok(entity);
        }

    }
}
