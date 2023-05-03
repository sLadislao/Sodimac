using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Sodimac.Model;
using Sodmac.Data.Entities.Interfaces;

namespace Sodmac.Data.Entities.Implementations
{
	public class ComprometidasRepository : IComprometidasRepository
    {
        private readonly DBContext context;
        private readonly Mapper mapper;

        public ComprometidasRepository(DBContext context)
        {
            this.context = context;
            mapper = new Mapper(AutomapperProfile.configuration);
        }

        public List<ComprometidasDTO> getAll(string sku)
        {
            var db = context.TBL_INV_NP_COMPROMETIDAS_N
                .Where(x => x.sku_id !=  null
                    && x.sku_id.Contains(sku) || sku == string.Empty).ToList();
            return mapper.Map<List<ComprometidasDTO>>(db);
        }
    }
}