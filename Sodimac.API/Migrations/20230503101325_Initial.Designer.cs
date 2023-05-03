﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sodmac.Data;

#nullable disable

namespace Sodimac.API.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230503101325_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Sodmac.Data.Entities.TBL_INV_CO_DESPACHADAS_N", b =>
                {
                    b.Property<int>("id_co_despachadas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("co_desp")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("fecha_actualizacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("item_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("number_1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("number_2")
                        .HasMaxLength(18)
                        .HasColumnType("INTEGER");

                    b.Property<string>("vchar_1")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("vchar_2")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("whse")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.HasKey("id_co_despachadas");

                    b.ToTable("TBL_INV_CO_DESPACHADAS_N");

                    b.HasData(
                        new
                        {
                            id_co_despachadas = 1,
                            co_desp = 2m,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            item_name = "Mesa de roble",
                            number_1 = 1,
                            number_2 = 11,
                            vchar_1 = "V1",
                            vchar_2 = "V11",
                            whse = "WHSE 001"
                        },
                        new
                        {
                            id_co_despachadas = 2,
                            co_desp = 3m,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            item_name = "Mesa de nogal",
                            number_1 = 2,
                            number_2 = 22,
                            vchar_1 = "V2",
                            vchar_2 = "V22",
                            whse = "WHSE 002"
                        });
                });

            modelBuilder.Entity("Sodmac.Data.Entities.TBL_INV_NP_COMPROMETIDAS_N", b =>
                {
                    b.Property<int>("id_np_comprometidas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha_actualizacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("id_alm_ent")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("id_estado")
                        .HasMaxLength(3)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("number_1")
                        .HasMaxLength(18)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("number_2")
                        .HasMaxLength(18)
                        .HasColumnType("INTEGER");

                    b.Property<int>("org_lvl_child")
                        .HasMaxLength(12)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("qty_pend")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.Property<string>("sku_id")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("sticker")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("vchar_1")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("vchar_2")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.HasKey("id_np_comprometidas");

                    b.ToTable("TBL_INV_NP_COMPROMETIDAS_N");

                    b.HasData(
                        new
                        {
                            id_np_comprometidas = 1,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            id_alm_ent = "11",
                            id_estado = 1,
                            number_1 = 1,
                            number_2 = 11,
                            org_lvl_child = 1,
                            qty_pend = 2,
                            sku_id = "SKU 01",
                            sticker = "STK001",
                            vchar_1 = "1",
                            vchar_2 = "11"
                        },
                        new
                        {
                            id_np_comprometidas = 2,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            id_alm_ent = "22",
                            id_estado = 2,
                            number_1 = 2,
                            number_2 = 22,
                            org_lvl_child = 2,
                            qty_pend = 4,
                            sku_id = "SKU 02",
                            sticker = "STK002",
                            vchar_1 = "2",
                            vchar_2 = "22"
                        });
                });

            modelBuilder.Entity("Sodmac.Data.Entities.TBL_INV_UBICACIONES_N", b =>
                {
                    b.Property<int>("id_ubicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha_actualizacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_item")
                        .HasMaxLength(9)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("number_1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("number_2")
                        .HasMaxLength(18)
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("on_hand_qty")
                        .HasPrecision(23, 5)
                        .HasColumnType("TEXT");

                    b.Property<string>("prd_lvl_child")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("sku_id")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ubicacion")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("vchar_1")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("vchar_2")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("whse")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("wms_locn_id")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("id_ubicacion");

                    b.ToTable("TBL_INV_UBICACIONES_N");

                    b.HasData(
                        new
                        {
                            id_ubicacion = 1,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            id_item = 1,
                            number_1 = 2,
                            number_2 = 4,
                            on_hand_qty = 6m,
                            prd_lvl_child = "PRD 01",
                            sku_id = "SKU 01",
                            ubicacion = "Bodega Funza",
                            vchar_1 = "1",
                            vchar_2 = "11",
                            whse = "WHSE 01",
                            wms_locn_id = "WMS 001"
                        },
                        new
                        {
                            id_ubicacion = 2,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            id_item = 2,
                            number_1 = 2,
                            number_2 = 10,
                            on_hand_qty = 12m,
                            prd_lvl_child = "PRD 02",
                            sku_id = "SKU 02",
                            ubicacion = "Bodega Bogota",
                            vchar_1 = "2",
                            vchar_2 = "22",
                            whse = "WHSE 02",
                            wms_locn_id = "WMS 002"
                        },
                        new
                        {
                            id_ubicacion = 3,
                            fecha_actualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            id_item = 2,
                            number_1 = 10,
                            number_2 = 10,
                            on_hand_qty = 20m,
                            prd_lvl_child = "PRD 03",
                            sku_id = "SKU 03",
                            vchar_1 = "3",
                            vchar_2 = "33",
                            whse = "WHSE 03",
                            wms_locn_id = "WMS 003"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
