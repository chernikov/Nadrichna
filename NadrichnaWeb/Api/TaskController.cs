using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Repos;
using System.Collections.Generic;
using System.Linq;
using _Task = NadrichnaWeb.Db._Task;

namespace NadrichnaWeb.Api
{
    [Route("api/task")]
    public class TaskController : Controller
    {
        private readonly ITaskRepository taskRepository;
        private readonly IMapper mapper;

        public TaskController(ITaskRepository taskRepository, IMapper mapper)
        {
            this.taskRepository = taskRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = taskRepository.GetAll();
            var resultList = mapper.Map<List<_Task>, List<TaskDto>>(list);
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = taskRepository.Get(id);
            var result = mapper.Map<TaskDto>(entity);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] TaskDto task)
        {
            var entity = mapper.Map<_Task>(task);
            var newTask = taskRepository.Create(entity);
            var result = mapper.Map<TaskDto>(newTask);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            taskRepository.Remove(id);
            return Ok();
        }


    }
}

