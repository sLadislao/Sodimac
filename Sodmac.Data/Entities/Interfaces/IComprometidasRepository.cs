using System;
using Sodimac.Model;

namespace Sodmac.Data.Entities.Interfaces
{
	public interface IComprometidasRepository
	{
		List<ComprometidasDTO> getAll(string sku);
    }
}
