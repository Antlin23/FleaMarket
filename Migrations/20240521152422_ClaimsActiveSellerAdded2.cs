using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class ClaimsActiveSellerAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "f1b483a7-7e51-41e3-b6ec-8b9918656a0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "20fb0f41-079e-4baa-b744-f4068955d93e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2635f303-012d-4d5d-b966-846bcea9bad7", "AQAAAAIAAYagAAAAEHKZTcot/ha1QYGL/a3IsLisTW/gHuaM5rU2uLu13GcbmixPXAT+C+T4f6YnYdbirA==", "fd3c634f-0d14-4200-81cc-57ea070a436a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "7e810958-03fe-4e82-ad41-fd340d8eb113");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "27b91f62-2f9e-4090-9cba-6942c36d5814");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d1c926-708d-415c-b337-c75a65a53fc2", "AQAAAAIAAYagAAAAEOnz5GLO9VGeKx/aNjkmSlRUJiCdz5zlK318HNXj1MUMkKASdxVD2AdDi2V3TDwj1w==", "828457ef-e1b8-4e67-a88c-8e5e8a979fba" });
        }
    }
}
