using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Api
{
    [Route("api/house")]
    public class HouseController : Controller
    {
        private readonly IHouseRepository houseRepository;
        private readonly IMapper mapper;

        public HouseController(IHouseRepository houseRepository, IMapper mapper)
        {
            this.houseRepository = houseRepository;
            this.mapper = mapper;
        }

        //get list

        [HttpGet]
        public IActionResult Get()
        {
            var list = houseRepository.GetAll();
            var result = mapper.Map<List<House>, List<HouseDto>>(list);
            return Ok(list);
        }

        //get item

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entity = houseRepository.Get(id);
            var result = mapper.Map<HouseDto>(entity);
            return Ok(entity);
        }

        //add

        [HttpPost]

        public IActionResult Add([FromBody] HouseDto house)
        {
            var entity = mapper.Map<House>(house);
            var newHouse = houseRepository.Create(entity);
            var result = mapper.Map<HouseDto>(newHouse);
            return Ok(result);
        }

        //delete

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            houseRepository.Remove(id);
            return Ok();
        }

        //update*

        [HttpPut]
        public IActionResult Put([FromBody] HouseDto house)
        {
            var entity = mapper.Map<House>(house);
            var editedHouse = houseRepository.Update(entity);
            var result = mapper.Map<HouseDto>(editedHouse);
            return Ok(result);
        }

    }
}
