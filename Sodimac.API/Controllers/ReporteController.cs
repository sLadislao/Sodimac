using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sodimac.Business;
using Sodimac.Business.Interfaces;
using Sodimac.Model;
using Sodimac.Model.Reporte;

namespace Sodimac.API.Controllers
{
    [ApiController]
    [Route("api/Reporte")]
    public class ReporteController : ControllerBase
    {
        private readonly ReporteBL bl;
        public ReporteController(
            IComprometidasService comprometidasService,
            IDespachadasService despachadasService,
            IUbicacionesService ubicacionesService
            )
        {
            bl = new ReporteBL(comprometidasService, despachadasService, ubicacionesService);
        }

        [HttpGet("")]
        [HttpGet("{sku}")]
        public ActionResult DisponibilidadNeta(string sku = "")
        {
            try
            {
                return Ok(bl.obtenerReporte(sku));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}

