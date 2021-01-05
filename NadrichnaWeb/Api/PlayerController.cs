using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NadrichnaWeb.Api
{
    [Route("api/player")]
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository playerRepository;
        private readonly IMapper mapper;

        public PlayerController(IPlayerRepository playerRepository, IMapper mapper)
        {
            this.playerRepository = playerRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var list = playerRepository.GetAll();
            var resultList = mapper.Map<List<Player>, List<PlayerDto>>(list);
            return Ok(resultList);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPlayer(int id)
        {
            var entity = playerRepository.Get(id);
            var result = mapper.Map<PlayerDto>(entity);
            return Ok(result);
        }

        [HttpGet("{id:int}/tasks")]
        public IActionResult GetTasks(int id)
        {
            var entity = playerRepository.Get(id);
            var taskList = entity.Tasks.ToList();
            var result = mapper.Map<List<Task>, List<TaskDto>>(taskList);
            return Ok(result);
        }

        //Add new player
        [HttpPost]
        public IActionResult Post([FromBody] PlayerDto player)
        {
            var entity = mapper.Map<Player>(player);
            var newPlayer = playerRepository.Create(entity);
            var result = mapper.Map<PlayerDto>(newPlayer);
            return Ok(result);
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            playerRepository.Remove(id);
            return Ok();
        }
    }
}
