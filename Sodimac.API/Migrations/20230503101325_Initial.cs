using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sodimac.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_INV_CO_DESPACHADAS_N",
                columns: table => new
                {
                    id_co_despachadas = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    whse = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    item_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    co_desp = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: true),
                    fecha_actualizacion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    number_1 = table.Column<int>(type: "INTEGER", nullable: true),
                    number_2 = table.Column<int>(type: "INTEGER", maxLength: 18, nullable: true),
                    vchar_1 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    vchar_2 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_INV_CO_DESPACHADAS_N", x => x.id_co_despachadas);
                });

            migrationBuilder.CreateTable(
                name: "TBL_INV_NP_COMPROMETIDAS_N",
                columns: table => new
                {
                    id_np_comprometidas = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sticker = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    id_alm_ent = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    org_lvl_child = table.Column<int>(type: "INTEGER", maxLength: 12, nullable: false),
                    id_estado = table.Column<int>(type: "INTEGER", maxLength: 3, nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    qty_pend = table.Column<int>(type: "INTEGER", maxLength: 5, nullable: true),
                    sku_id = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    number_1 = table.Column<int>(type: "INTEGER", maxLength: 18, nullable: true),
                    number_2 = table.Column<int>(type: "INTEGER", maxLength: 18, nullable: true),
                    vchar_1 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    vchar_2 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_INV_NP_COMPROMETIDAS_N", x => x.id_np_comprometidas);
                });

            migrationBuilder.CreateTable(
                name: "TBL_INV_UBICACIONES_N",
                columns: table => new
                {
                    id_ubicacion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_item = table.Column<int>(type: "INTEGER", maxLength: 9, nullable: false),
                    whse = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    sku_id = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    prd_lvl_child = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ubicacion = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    fecha_actualizacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    on_hand_qty = table.Column<decimal>(type: "TEXT", precision: 23, scale: 5, nullable: true),
                    wms_locn_id = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    number_1 = table.Column<int>(type: "INTEGER", nullable: true),
                    number_2 = table.Column<int>(type: "INTEGER", maxLength: 18, nullable: true),
                    vchar_1 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    vchar_2 = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_INV_UBICACIONES_N", x => x.id_ubicacion);
                });

            migrationBuilder.InsertData(
                table: "TBL_INV_CO_DESPACHADAS_N",
                columns: new[] { "id_co_despachadas", "co_desp", "fecha_actualizacion", "item_name", "number_1", "number_2", "vchar_1", "vchar_2", "whse" },
                values: new object[,]
                {
                    { 1, 2m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa de roble", 1, 11, "V1", "V11", "WHSE 001" },
                    { 2, 3m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa de nogal", 2, 22, "V2", "V22", "WHSE 002" }
                });

            migrationBuilder.InsertData(
                table: "TBL_INV_NP_COMPROMETIDAS_N",
                columns: new[] { "id_np_comprometidas", "fecha_actualizacion", "id_alm_ent", "id_estado", "number_1", "number_2", "org_lvl_child", "qty_pend", "sku_id", "sticker", "vchar_1", "vchar_2" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11", 1, 1, 11, 1, 2, "SKU 01", "STK001", "1", "11" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22", 2, 2, 22, 2, 4, "SKU 02", "STK002", "2", "22" }
                });

            migrationBuilder.InsertData(
                table: "TBL_INV_UBICACIONES_N",
                columns: new[] { "id_ubicacion", "fecha_actualizacion", "id_item", "number_1", "number_2", "on_hand_qty", "prd_lvl_child", "sku_id", "ubicacion", "vchar_1", "vchar_2", "whse", "wms_locn_id" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 4, 6m, "PRD 01", "SKU 01", "Bodega Funza", "1", "11", "WHSE 01", "WMS 001" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 10, 12m, "PRD 02", "SKU 02", "Bodega Bogota", "2", "22", "WHSE 02", "WMS 002" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, 10, 20m, "PRD 03", "SKU 03", null, "3", "33", "WHSE 03", "WMS 003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_INV_CO_DESPACHADAS_N");

            migrationBuilder.DropTable(
                name: "TBL_INV_NP_COMPROMETIDAS_N");

            migrationBuilder.DropTable(
                name: "TBL_INV_UBICACIONES_N");
        }
    }
}
