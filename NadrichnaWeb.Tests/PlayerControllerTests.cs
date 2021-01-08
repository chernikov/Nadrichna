using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NadrichnaWeb.Api;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Profiles;
using NadrichnaWeb.Repos;
using NadrichnaWeb.Tests.Mocks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Tests
{
    [TestFixture]
    public class PlayerControllerTests 
    {


        [Test]
        public void Test_GetList_ReturnOk()
        {

            //arrange 
            var mapper = GetMapper();
            var playerRepository = GetPlayerRepository();
            var sut = new PlayerController(playerRepository, mapper);

            //act 
            var response = sut.GetTasks(1);

            //assert
            Assert.IsTrue(response is OkObjectResult);
        }

        [Test]
        public void Test_GetList_ReturnListOfPlayers()
        {

            //arrange 
            var mapper = GetMapper();
            var playerRepository = GetPlayerRepository();
            var sut = new PlayerController(playerRepository, mapper);

            //act 
            var response = sut.GetTasks(1);
            var list = (response as OkObjectResult).Value as List<TaskDto>;

            //assert
            Assert.IsNotNull(list);
            Assert.IsNotEmpty(list);
            Assert.IsTrue(list[0] is TaskDto);
        }


        private IMapper GetMapper()
        {
            var playerProfile = new PlayerProfile();
            var houseProfile = new HouseProfile();
            var taskProfile = new TaskProfile();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(playerProfile);
                cfg.AddProfile(houseProfile);
                cfg.AddProfile(taskProfile);
            });
            return mapperConfig.CreateMapper();
        }

        private IPlayerRepository GetPlayerRepository()
        {
            return new MockPlayerRepository();
        }
    }
}
