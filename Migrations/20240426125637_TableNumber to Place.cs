using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class TableNumbertoPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "57bb42e8-fb9b-433b-bddf-eb879a1a7265");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "a53c3e2f-b876-47e6-9c76-5ee56173b972");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Place", "SecurityStamp" },
                values: new object[] { "4cc514a4-a175-4bb4-b517-82152347e679", "AQAAAAIAAYagAAAAEO0rvSOLHo/bHEdkSJ9ZXBfUsbWJUbAyXmhsPTSSjUREVixyfRDYR1SA3Pyi+YriXw==", null, "a54835d7-fca2-4139-b109-43234adb3ace" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "TableNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "6645179d-240a-482f-b351-ed661aa7901f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "d1a38594-b825-43bb-a41b-b4826d267155");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TableNumber" },
                values: new object[] { "3f851ae6-f00c-41d9-8604-4e061c7b5d7c", "AQAAAAIAAYagAAAAEGblo0eDml3GWEQ3Jf5KRWGOKVdBC321a/4K6rlBGJseSrUfRQSZ6sba6Pv+7nal3Q==", "7585fbbb-9cac-40e4-bf1e-88484a580419", null });
        }
    }
}
