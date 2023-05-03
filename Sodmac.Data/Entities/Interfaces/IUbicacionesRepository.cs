using System;
using Sodimac.Model;

namespace Sodmac.Data.Entities.Interfaces
{
	public interface IUbicacionesRepository
	{
        List<UbicacionesDTO> getAll(string sku);
    }
}

