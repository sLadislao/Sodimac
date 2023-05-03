using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Sodmac.Data.Entities.Seeders
{
	public class Seed_TBL_INV_CO_DESPACHADAS_N
	{
        public static TBL_INV_CO_DESPACHADAS_N D1 = new TBL_INV_CO_DESPACHADAS_N()
        {
            id_co_despachadas = 1,
            whse = "WHSE 001",
            item_name = "Mesa de roble",
            co_desp = 2,
            fecha_actualizacion = new DateTime(),
            number_1 = 1,
            number_2 = 11,
            vchar_1 = "V1",
            vchar_2 = "V11"
        };
        public static TBL_INV_CO_DESPACHADAS_N D2 = new TBL_INV_CO_DESPACHADAS_N()
        {
            id_co_despachadas = 2,
            whse = "WHSE 002",
            item_name = "Mesa de nogal",
            co_desp = 3,
            fecha_actualizacion = new DateTime(),
            number_1 = 2,
            number_2 = 22,
            vchar_1 = "V2",
            vchar_2 = "V22"
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_INV_CO_DESPACHADAS_N>().HasData(
                D1,
                D2);
        }
    }
}

