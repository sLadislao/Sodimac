using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Sodmac.Data.Entities
{
	public class TBL_INV_CO_DESPACHADAS_N
	{
		[Key]
        [Required]
        public int id_co_despachadas { get; set; }
        [MaxLength(16)]
        [Required]
        public string whse { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public string item_name { get; set; } = null!;
        [Precision(18, 2)]
        public decimal? co_desp { get; set; }
		public DateTime? fecha_actualizacion { get; set; }
        public int? number_1 { get; set; }
        [MaxLength(18)]
        public int? number_2 { get; set; }
        [MaxLength(2000)]
        public string? vchar_1 { get; set; }
        [MaxLength(2000)]
        public string? vchar_2 { get; set; }
    } 
}