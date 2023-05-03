using System;
using Sodimac.Business.Interfaces;
using Sodimac.Model;
using Sodmac.Data.Entities;
using Sodmac.Data.Entities.Interfaces;

namespace Sodimac.Business.Implementations
{
    public class ComprometidasService : IComprometidasService
    {
        private readonly IComprometidasRepository comprometidasRepository;
        public ComprometidasService(IComprometidasRepository comprometidasRepository)
        {
            this.comprometidasRepository = comprometidasRepository;
        }

        public List<ComprometidasDTO> getAll(string sku)
        {
            return comprometidasRepository.getAll(sku);
        }
    }
}