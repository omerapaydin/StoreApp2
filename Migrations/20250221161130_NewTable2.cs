using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp2.Migrations
{
    /// <inheritdoc />
    public partial class NewTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f30a88-efe2-42d1-b871-4df1d84aa293", "AQAAAAIAAYagAAAAEKozUb6rV6SZD2rtILcMa/dZMyp3yxJWiIphnVlcbe8N1tK9BP7wvpPcKcPhD74bCw==", "4c1c1597-240b-4e6c-ae9d-f70fbd87a16e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1edb836f-b7db-4c07-9954-6127c322a005", "AQAAAAIAAYagAAAAEECNh/1yKR6scCZJDzipxgCnFjetd2n6WIDfYY3EfyUTJ6uRsj+/zwSuB3sGp+99kw==", "ecc02cdb-8ca0-4cfd-bfdb-7832566e1fa9" });
        }
    }
}
