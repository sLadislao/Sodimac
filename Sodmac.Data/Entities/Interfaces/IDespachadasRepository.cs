using System;
using Sodimac.Model;

namespace Sodmac.Data.Entities.Interfaces
{
	public interface IDespachadasRepository
	{
		List<DespachadasDTO> getAll();
	}
}

