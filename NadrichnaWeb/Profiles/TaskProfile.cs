using AutoMapper;
using NadrichnaWeb.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Profiles
{
    public class TaskProfile: Profile
    {
        public TaskProfile()
        {
            CreateMap<Task, TaskDto>();
            CreateMap<TaskDto, Task>();

        }
    }
}
