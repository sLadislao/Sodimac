using System;
using Microsoft.EntityFrameworkCore;

namespace Sodmac.Data.Entities.Seeders
{
	public class Seed_TBL_INV_NP_COMPROMETIDAS_N
    {
        public static TBL_INV_NP_COMPROMETIDAS_N I1 = new TBL_INV_NP_COMPROMETIDAS_N()
        {
            id_np_comprometidas = 1,
            sticker = "STK001",
            id_alm_ent = "11",
            org_lvl_child = 1,
            id_estado = 1,
            fecha_actualizacion = new DateTime(),
            qty_pend = 2,
            sku_id = "SKU 01",
            number_1 = 1,
            number_2 = 11,
            vchar_1 = "1",
            vchar_2 = "11",
        };
        public static TBL_INV_NP_COMPROMETIDAS_N I2 = new TBL_INV_NP_COMPROMETIDAS_N()
        {
            id_np_comprometidas = 2,
            sticker = "STK002",
            id_alm_ent = "22",
            org_lvl_child = 2,
            id_estado = 2,
            fecha_actualizacion = new DateTime(),
            qty_pend = 4,
            sku_id = "SKU 02",
            number_1 = 2,
            number_2 = 22,
            vchar_1 = "2",
            vchar_2 = "22",
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_INV_NP_COMPROMETIDAS_N>().HasData(
                I1,
                I2);
        }
    }
}

