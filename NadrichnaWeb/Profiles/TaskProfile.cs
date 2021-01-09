﻿using AutoMapper;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
namespace NadrichnaWeb.Profiles
{
    public class TaskProfile: Profile
    {
        public TaskProfile()
        {
            CreateMap<Task, TaskDto>()
                .ForMember(p => p.CompleteDay, opt => opt.MapFrom(task => task.CompleteDate.Day))
                .ForMember(p => p.CompleteHour, opt => opt.MapFrom(task => task.CompleteDate.Hour))
                .ForMember(p => p.CompleteMinute, opt => opt.MapFrom(task => task.CompleteDate.Minute));
            CreateMap<TaskDto, Task>()
                .ForPath(p => p.Player.Id, opt => opt.MapFrom(taskDto => taskDto.Player.Id));
        }
    }
}
