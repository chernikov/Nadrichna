using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NadrichnaWeb.Api;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using NadrichnaWeb.Profiles;
using NadrichnaWeb.Repos;
using NadrichnaWeb.Tests.Mocks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NadrichnaWeb.Tests
{
    [TestFixture]
    class TaskControllerTests
    {

        [Test]
        public void Test_GetItem_ReturnOk()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);

            //act 
            var response = sut.GetItem(1);

            //assert
            Assert.IsTrue(response is OkObjectResult);
        }

        [Test]
        public void Test_GetItem_ReturnItem()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);
            //act 
            var response = sut.GetItem(1);
            var item = (response as OkObjectResult).Value as TaskDto;

            //assert
            Assert.IsNotNull(item);
            Assert.IsTrue(item is TaskDto);
        }

        [Test]
        public void Test_GetItem_ReturnList()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);

            //act 
            var response = sut.GetList();
            var list = (response as OkObjectResult).Value as List<TaskDto>;

            //assert
            Assert.IsNotNull(list);
            Assert.IsNotEmpty(list);
            Assert.IsTrue(list[0] is TaskDto);
        }

        [Test]
        public void Test_Add_CreatedAndGetItem()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);

            //act 
            var task = new TaskDto() { Name = "verify-item"};
            var newTask = sut.Add(task);
            var response = sut.GetItem(((newTask as OkObjectResult).Value as TaskDto).Id);
            var result = (response as OkObjectResult).Value as TaskDto;

            //assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is TaskDto);
            Assert.IsTrue(task.Name == result.Name);
        }

        [Test]
        public void Test_Delete()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);

            //act 
            var task = (sut.GetItem(1) as OkObjectResult).Value as TaskDto;
            sut.Delete(1);
            var removedTask = (sut.GetItem(1) as OkObjectResult).Value as TaskDto;

            //assert
            Assert.IsNotNull(task);
            Assert.Null(removedTask);
        }

        [Test]
        public void Test_Complete()
        {

            //arrange 
            var mapper = GetMapper();
            var taskRepository = GetTaskRepository();
            var sut = new TaskController(taskRepository, mapper);

            //act 
            sut.Complete(1);
            var result = (sut.GetItem(1) as OkObjectResult).Value as TaskDto;

            //assert
            Assert.NotNull(result);
            Assert.IsTrue(result.Completed);
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

        private ITaskRepository GetTaskRepository()
        {
            var options = new DbContextOptionsBuilder<NadrichnaDbConext>()
                .UseInMemoryDatabase("NadcrichnaTests")
                .Options;
            var mockContext = new NadrichnaDbConext(options);
            Seed(mockContext);
            return new MockTaskRepository(mockContext);
        }

        private void Seed(NadrichnaDbConext dbConext)
        {
            var tasks = new[]
            {
                new Task { Name = "test-1", Completed = false},
                new Task { Name = "test-2", Completed = true},
                new Task { Name = "test-3", Completed = false}
            };

            dbConext.Tasks.AddRange(tasks);
            dbConext.SaveChanges();
        }

    }
}
