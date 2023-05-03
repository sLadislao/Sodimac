using System;
using Sodimac.Business.Interfaces;
using Sodimac.Model;
using Sodmac.Data.Entities.Interfaces;

namespace Sodimac.Business.Implementations
{
	public class UbicacionesService : IUbicacionesService
    {
        private readonly IUbicacionesRepository ubicacionesRepository;
        public UbicacionesService(IUbicacionesRepository ubicacionesRepository)
		{
            this.ubicacionesRepository = ubicacionesRepository;
		}

        public List<UbicacionesDTO> getAll(string sku)
        {
            return ubicacionesRepository.getAll(sku);
        }
    }
}

