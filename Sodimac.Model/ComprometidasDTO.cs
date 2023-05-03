using System;
namespace Sodimac.Model
{
	public class ComprometidasDTO
	{
        public int id_np_comprometidas { get; set; }
        public string sticker { get; set; } = null!;
        public string id_alm_ent { get; set; } = null!;
        public int org_lvl_child { get; set; }
        public int id_estado { get; set; }
        public DateTime fecha_actualizacion { get; set; }
        public int qty_pend { get; set; }
        public string sku_id { get; set; } = null!;
        public int number_1 { get; set; }
        public int number_2 { get; set; }
        public string vchar_1 { get; set; } = null!;
        public string vchar_2 { get; set; } = null!;
    }
}