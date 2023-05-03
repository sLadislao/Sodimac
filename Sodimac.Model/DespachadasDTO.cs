using System;

namespace Sodimac.Model
{
	public class DespachadasDTO
	{
        public int id_co_despachadas { get; set; }
        public string whse { get; set; } = null!;
        public string item_name { get; set; } = null!;
        public decimal? co_desp { get; set; }
        public DateTime? fecha_actualizacion { get; set; }
        public int? number_1 { get; set; }
        public int? number_2 { get; set; }
        public string? vchar_1 { get; set; }
        public string? vchar_2 { get; set; }
    }
}