using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Sodimac.Model;
using Sodmac.Data.Entities;

namespace Sodmac.Data
{
	public class AutomapperProfile : Profile
	{
        public readonly static MapperConfiguration configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<TBL_INV_NP_COMPROMETIDAS_N, ComprometidasDTO>();
            cfg.CreateMap<TBL_INV_CO_DESPACHADAS_N, DespachadasDTO>();
            cfg.CreateMap<TBL_INV_UBICACIONES_N, UbicacionesDTO>();
        });
    }
}