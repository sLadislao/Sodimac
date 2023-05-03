using System;
using Sodimac.Business.Interfaces;
using Sodimac.Model;
using Sodimac.Model.Reporte;

namespace Sodimac.Business
{
	public class ReporteBL
	{
        private readonly IComprometidasService comprometidasService;
        private readonly IDespachadasService despachadasService;
        private readonly IUbicacionesService ubicacionesService;

        public ReporteBL (
			IComprometidasService comprometidasService,
            IDespachadasService despachadasService,
            IUbicacionesService ubicacionesService )
		{
            this.comprometidasService = comprometidasService;
            this.despachadasService = despachadasService;
            this.ubicacionesService = ubicacionesService;
        }

        public ReporteModel obtenerReporte(string sku)
        {
            decimal totalInventario = obtenerTotalInventario(sku);
            if (totalInventario == 0)
                throw new ApplicationException(string.Format("{0}: no encontrado", sku));
            decimal totalDespachadas = obtenerTotalComprometidas(sku);
            decimal totalComprometidas = obtenerTotalDespachadas();

            var ubicaciones = ubicacionesService.getAll(sku);
            ReporteModel report = new ReporteModel() {
                disponibilidadNeta = totalInventario - totalComprometidas + totalDespachadas,
                totalInventarioComprometido = totalComprometidas + totalDespachadas + totalInventario,
                unidadesPorUbicacion = new List<UnidadesUbicacionModel>()
            };
            foreach (var ubicacion in ubicaciones)
                report.unidadesPorUbicacion.Add(new UnidadesUbicacionModel()
                {
                    ubicacion = ubicacion.ubicacion ?? "Sin Hubicacion",
                    cantidadActivo = ubicacion.on_hand_qty ?? 0,
                    cantidadReserva = ubicacion.number_1 ?? 0,
                    cantidadNoAlmacenada = ubicacion.ubicacion == null ? ubicacion.on_hand_qty ?? 0 : 0
                });
            return report;
        }

        private decimal obtenerTotalInventario(string sku) {
            var nventarios = ubicacionesService.getAll(sku);
            decimal totalInventario = 0;
            foreach (var inventario in nventarios)
                totalInventario += inventario.on_hand_qty != null ? (decimal)inventario.on_hand_qty : 0;
            return totalInventario;
        }
        private decimal obtenerTotalComprometidas(string sku) {
            var comprometidas = comprometidasService.getAll(sku);
            decimal totalComprometidas = 0;
            foreach (var comprometida in comprometidas)
                totalComprometidas += comprometida.qty_pend;
            return totalComprometidas;
        }
        private decimal obtenerTotalDespachadas() {
            var despachadas = despachadasService.getAll();
            decimal totalDespachadas = 0;
            foreach (var despacahada in despachadas)
                totalDespachadas += despacahada.co_desp != null ? (decimal)despacahada.co_desp : 0;
            return totalDespachadas;
        }
	}
}