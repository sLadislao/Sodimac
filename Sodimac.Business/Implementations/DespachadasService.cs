using System;
using Sodimac.Business.Interfaces;
using Sodimac.Model;
using Sodmac.Data.Entities.Implementations;
using Sodmac.Data.Entities.Interfaces;

namespace Sodimac.Business.Implementations
{
	public class DespachadasService : IDespachadasService
    {
        private readonly IDespachadasRepository despachadasRepository;
        public DespachadasService(IDespachadasRepository despachadasRepository)
		{
            this.despachadasRepository = despachadasRepository;
		}

        public List<DespachadasDTO> getAll()
        {
            return despachadasRepository.getAll();
        }
    }
}

