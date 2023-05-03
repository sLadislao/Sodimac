using System;
using Sodimac.Model;

namespace Sodimac.Business.Interfaces
{
	public interface IComprometidasService
	{
        List<ComprometidasDTO> getAll(string sku);
    }
}