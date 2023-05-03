using System;
using AutoMapper;
using Sodimac.Model;
using Sodmac.Data.Entities.Interfaces;

namespace Sodmac.Data.Entities.Implementations
{
	public class DespachadasRepository : IDespachadasRepository
    {
        private readonly DBContext context;
        private readonly Mapper mapper;

        public DespachadasRepository(DBContext context)
        {
            this.context = context;
            mapper = new Mapper(AutomapperProfile.configuration);
        }
        public List<DespachadasDTO> getAll()
        {
            var db = context.TBL_INV_CO_DESPACHADAS_N.ToList();
            return mapper.Map<List<DespachadasDTO>>(db);
        }
    }
}