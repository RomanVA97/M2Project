using AutoMapper;
using M2DAL.Entities;
using M2BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.Automapper
{
    class MapperSetting:Profile
    {
        public MapperSetting()
        {
            CreateMap<AlertDTO, Alert>();
            CreateMap<Alert, AlertDTO>();

            CreateMap<AreaDTO, Area>();
            CreateMap<Area, AreaDTO>();
            CreateMap<ChemicalProductDTO, ChemicalProduct>();
            CreateMap<ChemicalProduct, ChemicalProductDTO>();








            CreateMap<PlantDTO, Plant>();
            CreateMap<Plant, PlantDTO>();

        }
    }
}
