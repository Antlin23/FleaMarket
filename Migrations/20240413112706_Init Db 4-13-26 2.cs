using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitDb413262 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "a2f6a41b-0857-437e-a1b8-e7841c52d00f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "767b7869-e2f1-4f31-b872-dfb15c7388b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b4f4a7-7109-434e-85ad-1a866f509806", "AQAAAAIAAYagAAAAEKRTuZfJk9OH260YfyKQf7TlnRiiaw5SwwOcPEB9oQOUfTzwYIHh52qsOkzn7rXjtw==", "af7a14b2-c70f-4be9-b74a-62878975349c" });
        }
    }
}
