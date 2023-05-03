using System;
using Sodimac.Model;

namespace Sodimac.Business.Interfaces
{
	public interface IUbicacionesService
	{
        List<UbicacionesDTO> getAll(string sku);
    }
}