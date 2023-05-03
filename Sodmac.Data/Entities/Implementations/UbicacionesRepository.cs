using System;
using AutoMapper;
using Sodimac.Model;
using Sodmac.Data.Entities.Interfaces;

namespace Sodmac.Data.Entities.Implementations
{
	public class UbicacionesRepository : IUbicacionesRepository
    {
        private readonly DBContext context;
        private readonly Mapper mapper;

        public UbicacionesRepository(DBContext context)
		{
            this.context = context;
            mapper = new Mapper(AutomapperProfile.configuration);
        }

        public List<UbicacionesDTO> getAll(string sku)
        {
            var db = context.TBL_INV_UBICACIONES_N.Where(x => x.sku_id.Contains(sku) || sku == string.Empty).ToList();
            return mapper.Map<List<UbicacionesDTO>>(db);
        }
    }
}

