using Appliaction.Dtos;
using AutoMapper;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Mapper
{
    internal class _Mapper: Profile
    {
        public _Mapper()
        {
            CreateMap<Student,StudentDTO>().ReverseMap();
        }

       
    }
}
