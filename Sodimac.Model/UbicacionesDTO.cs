using System;

namespace Sodimac.Model
{
	public class UbicacionesDTO
	{
        public int id_ubicacion { get; set; }
        public int id_item { get; set; }
        public string whse { get; set; } = null!;
        public string sku_id { get; set; } = null!;
        public string prd_lvl_child { get; set; } = null!;
        public string? ubicacion { get; set; } = null!;
        public DateTime fecha_actualizacion { get; set; }
        public decimal? on_hand_qty { get; set; }
        public string? wms_locn_id { get; set; } = null!;
        public int? number_1 { get; set; }
        public int? number_2 { get; set; }
        public string? vchar_1 { get; set; }
        public string? vchar_2 { get; set; }
    }
}