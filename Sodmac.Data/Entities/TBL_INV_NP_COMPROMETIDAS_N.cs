using System;
using System.ComponentModel.DataAnnotations;

namespace Sodmac.Data.Entities
{
	public class TBL_INV_NP_COMPROMETIDAS_N
	{
        [Key]
        [Required]
        public int id_np_comprometidas { get; set; }
        [MaxLength(200)]
        [Required]
        public string sticker { get; set; } = null!;
        [MaxLength(12)]
        [Required]
        public string id_alm_ent { get; set; } = null!;
        [MaxLength(12)]
        [Required]
        public int org_lvl_child { get; set; }
        [MaxLength(3)]
        [Required]
        public int id_estado { get; set; }
        [Required]
        public DateTime fecha_actualizacion { get; set; }
        [MaxLength(5)]
        public int? qty_pend { get; set; }
        [MaxLength(100)]
        public string? sku_id { get; set; }
        [MaxLength(18)]
        public int? number_1 { get; set; }
        [MaxLength(18)]
        public int? number_2 { get; set; }
        [MaxLength(2000)]
        public string? vchar_1 { get; set; }
        [MaxLength(2000)]
        public string? vchar_2 { get; set; }
    }
}