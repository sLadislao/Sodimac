using System;
namespace Sodimac.Model.Reporte
{
    public class ReporteModel
    {
        public decimal disponibilidadNeta { get; set; }
        public decimal totalInventarioComprometido { get; set; }
        public List<UnidadesUbicacionModel> unidadesPorUbicacion { get; set; } = new List<UnidadesUbicacionModel>();
    }

    public class UnidadesUbicacionModel
    {
        public string ubicacion { get; set; } = null!;
        public int cantidadReserva { get; set; }
        public decimal cantidadActivo { get; set; }
        public decimal cantidadNoAlmacenada { get; set; }
    }
}