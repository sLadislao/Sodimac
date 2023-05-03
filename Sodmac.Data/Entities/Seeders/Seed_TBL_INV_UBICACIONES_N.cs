using System;
using Microsoft.EntityFrameworkCore;

namespace Sodmac.Data.Entities.Seeders
{
	public class Seed_TBL_INV_UBICACIONES_N
	{
        public static TBL_INV_UBICACIONES_N U1 = new TBL_INV_UBICACIONES_N()
        {
            id_ubicacion = 1,
            id_item = 1,
            whse = "WHSE 01",
            sku_id = "SKU 01",
            prd_lvl_child = "PRD 01",
            ubicacion = "Bodega Funza",
            fecha_actualizacion = new DateTime(),
            on_hand_qty = 6,
            wms_locn_id = "WMS 001",
            number_1 = 2,
            number_2 = 4,
            vchar_1 = "1",
            vchar_2 = "11"
        };
        public static TBL_INV_UBICACIONES_N U2 = new TBL_INV_UBICACIONES_N()
        {
            id_ubicacion = 2,
            id_item = 2,
            whse = "WHSE 02",
            sku_id = "SKU 02",
            prd_lvl_child = "PRD 02",
            ubicacion = "Bodega Bogota",
            fecha_actualizacion = new DateTime(),
            on_hand_qty = 12,
            wms_locn_id = "WMS 002",
            number_1 = 2,
            number_2 = 10,
            vchar_1 = "2",
            vchar_2 = "22"
        };
        public static TBL_INV_UBICACIONES_N U3 = new TBL_INV_UBICACIONES_N()
        {
            id_ubicacion = 3,
            id_item = 2,
            whse = "WHSE 03",
            sku_id = "SKU 03",
            prd_lvl_child = "PRD 03",
            fecha_actualizacion = new DateTime(),
            on_hand_qty = 20,
            wms_locn_id = "WMS 003",
            number_1 = 10,
            number_2 = 10,
            vchar_1 = "3",
            vchar_2 = "33"
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_INV_UBICACIONES_N>().HasData(
                U1,
                U2,
                U3);
        }
    }
}

