using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Sodmac.Data.Entities
{
    public class TBL_INV_UBICACIONES_N
    {
        [Key]
        [Required]
        public int id_ubicacion { get; set; }
        [MaxLength(9)]
        [Required]
        public int id_item { get; set; }
        [MaxLength(16)]
        [Required]
        public string whse { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public string sku_id { get; set; } = null!;
        [MaxLength(50)]
        [Required]
        public string prd_lvl_child { get; set; } = null!;
        [MaxLength(3)]
        public string? ubicacion { get; set; } = null!;
        [Required]
        public DateTime fecha_actualizacion { get; set; }
        [Precision(23, 5)]
		public decimal? on_hand_qty { get; set; }
        [MaxLength(10)]
        public string? wms_locn_id { get; set; } = null!;
        public int? number_1 { get; set; }
        [MaxLength(18)]
        public int? number_2 { get; set; }
        [MaxLength(2000)]
        public string? vchar_1 { get; set; }
        [MaxLength(2000)]
        public string? vchar_2 { get; set; }
    }
}