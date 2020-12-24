using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Api
{
    [Route("api/player")]
    public class PlayersController : Controller
    {
        private readonly INadrichnaDbConext dbConext;

        public PlayersController(INadrichnaDbConext dbConext)
        {
            this.dbConext = dbConext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = dbConext.Players.ToList();
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = dbConext.Players.FirstOrDefault(p => p.Id == id);
            return Ok(entity);
        }

        //Add new player
        [HttpPost]
        public IActionResult Post([FromBody] Player player)
        {
            dbConext.Players.Add(player);
            dbConext.SaveChanges();
            return Ok(player);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var entity = dbConext.Players.FirstOrDefault(p => p.Id == id);
            dbConext.Players.Remove(entity);
            dbConext.SaveChanges();
            return Ok(entity);
        }
    }
}
