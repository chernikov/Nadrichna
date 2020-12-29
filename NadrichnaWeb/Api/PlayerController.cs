using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IActionResult Get()
        {
            var list = playerRepository.GetAll();
            var resultList = mapper.Map<List<Player>, List<PlayerDto>>(list);
            return Ok(resultList);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = playerRepository.Get(id);
            var result = mapper.Map<PlayerDto>(entity);
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
