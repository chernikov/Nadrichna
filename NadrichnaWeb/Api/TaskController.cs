using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using System.Collections.Generic;
using System.Linq;
using Task = NadrichnaWeb.Db.Task;

namespace NadrichnaWeb.Api
{
    [Route("api/task")]
    public class TaskController : Controller
    {
        private readonly INadrichnaDbConext dbConext;

        public TaskController(INadrichnaDbConext dbConext)
        {
            this.dbConext = dbConext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = dbConext.Tasks.ToList();
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = dbConext.Tasks.FirstOrDefault(p => p.Id == id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Task task)
        {
            dbConext.Tasks.Add(task);
            dbConext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var entity = dbConext.Tasks.FirstOrDefault(p => p.Id == id);
            dbConext.Tasks.Remove(entity);
            dbConext.SaveChanges();
            return Ok(entity);
        }


    }
}

