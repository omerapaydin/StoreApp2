using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e68e184-bbb2-47e7-81c9-351b1665a92b", "AQAAAAIAAYagAAAAECLlh5L/K20E19y62XnbAuEnSmJToKkXoyT6duDY5eAhcUgOJy1hCslg+ly2QxRMjg==", "1cca700f-51b0-4fb0-83fc-1c72c8bc8321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "305ceca4-ffcc-4f42-83a2-0c08fc7b222f", "AQAAAAIAAYagAAAAEKJ1lYt6iI3igbocwspOsVTLtLZss21i1vDp64Lb5X4Rl4ij1FkjDxyio2WN2d6dxg==", "a2dc3ada-5d17-4b87-922b-a532a95ea416" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75f5d5bb-8468-4d04-804d-9df6851470ef", "AQAAAAIAAYagAAAAEJGSuMkwYyqIKAjPL6jJs+It9PvmDteFAD4OeyA1fp5NOU2jBeFveaxzY0vxWUqSDw==", "7dd2e35e-416e-44e6-9a6d-8562ca3c88f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ec8fb2b-3246-490f-b50f-252418178511", "AQAAAAIAAYagAAAAEIwvT2f3oWxM10tHaK6NYOhFCor2mj8EavNj08x+JSwJJrwl20H2cU+CNJSBkAZasA==", "01372621-1f4a-4a11-8562-8aef64174c70" });
        }
    }
}
