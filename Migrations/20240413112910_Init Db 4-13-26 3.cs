using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitDb413263 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "bd44a682-0ed2-450b-b7a3-3057f28c8bd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "61d5ceea-41ec-4f42-8080-338facec9043");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaae80c3-fab7-42a1-a27c-ec314131826b", "AQAAAAIAAYagAAAAEJYoNFjHtcI5Z7pkYCDjdamfpr1xg9iLs49apz3kGIEFfoVHPeAWl2vFXetW5W6T7Q==", "eac637c3-f5fe-41a2-a01e-1c5329c3f0cb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "bc9c4108-2325-4222-8b3b-e3ef47c9cff9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "88c0d684-8791-4f98-99db-fcd2858a3034");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fe62616-714e-4ed5-b46a-84f65859a1ed", "AQAAAAIAAYagAAAAEMW4DORc110gcHtYg4LRvjcGQaKW8VglxL5moTayHEVQrlBungC/ArgZiiFDWBaFSw==", "91e8a131-8a94-489a-a062-70154c01b238" });
        }
    }
}
