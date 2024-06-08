using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class FilesAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "cebf651f-774b-4850-a01e-3d162f1f6a0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "6fe47b0e-1026-4420-ac69-3d461ad9c298");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77775937-adc2-43d7-aefc-dfba1c26d98a", "AQAAAAIAAYagAAAAEPlm61mvckSKIc+F41CSMRPVQPfjDmB5fH2jaz1Y5e+Mzv/ooogrJNX6gnZuoZFxlQ==", "3da3a470-846b-4493-87f5-e5e16fce784c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "c0633788-c10a-456e-988c-4a6b27a4acb1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "cf229079-af64-4fbf-bec0-8acf1f16d5f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0355b21c-9cd4-47db-a443-80d73a89c647", "AQAAAAIAAYagAAAAENlXv48yDtFU4o6G6s9CeREqwWcxe86vuUBuvv4p9m9yYtqlULwwER8rYxIIGzJ3mQ==", "34df70c8-f8ce-4e94-bdcc-2134821fc90b" });
        }
    }
}
