using AutoMapper;
using Desafio.Entities.DTOs;
using Desafio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.BL.Automapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Producto, ProductoDTO>()
                //.ForMember(destination => destination.Codigo, option => option.MapFrom(source => source.Id))
                .ForMember(destination => destination.StockProducto, option => option.MapFrom(source => source.Stock))
                .ReverseMap();
        }
    }
}
