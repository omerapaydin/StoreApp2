using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp2.Migrations
{
    /// <inheritdoc />
    public partial class CreateOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c73bfb36-4bb9-4673-b6d3-23a773cbe040", "AQAAAAIAAYagAAAAEJhwzdoi2I3yjyv/ahrpqPORhHmCOdn3za3S/YHEWIJjzIC+2nBmSwLYZdpMpmtP0A==", "39cf6825-9159-4fd6-b13c-974f98accc8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8d7c1bb-cf6d-48f5-90f5-97891aad473d", "AQAAAAIAAYagAAAAEPDqKD3Q0ZB55UpmjSr9T0AeFsS04S4XAQrP1QPSKng5lMR2gB7irq3IleTnVnjKJw==", "e013ccaa-ce99-45b9-9274-8f471de3dfc9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d428dace-bb6f-482b-be00-6b275f110a89", "AQAAAAIAAYagAAAAEKmA/C1OU+eQ0Ftg87ugFjyV0v2/1iOLSoszLGjwE4y3Ax3TSf/wr7iHKPjbr5Dw/g==", "f6005d77-956e-4a98-8023-6583226e1700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ec34b6-1735-4145-8e0e-5761501634b6", "AQAAAAIAAYagAAAAEKvkcRSXPekjannb4mN6/HvfC2YUwEgkcwse+xIB9C1rp/8FxJtzdtrISwgBsCaAuQ==", "e2cd5038-0bc0-4eb7-80c4-5111ce9919fb" });
        }
    }
}
