using Application.Features.Customers.Commands.CreateCustomer;
using Application.Features.Customers.Dtos;
using Application.Features.Customers.Models;
using Application.Features.Villa.Commands.CreateVilla;
using Application.Features.Villa.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Villa.Profiles
{
    public class MappingVilla : Profile
    {
        public MappingVilla()
        {
            CreateMap < Domain.Entities.Villa , CreatedVillaCommand>().ReverseMap();

            CreateMap<Domain.Entities.Villa, CreatedVillaDto>().ReverseMap();
           
        }
    }
}
