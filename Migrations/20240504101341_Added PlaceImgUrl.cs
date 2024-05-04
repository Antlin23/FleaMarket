using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlaceImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlaceImgUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "6e5bbea8-a910-4e02-a456-221d4611a418");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1e078f64-c0a9-430b-8578-38dd9fb6065f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PlaceImgUrl", "SecurityStamp" },
                values: new object[] { "2632955f-fa02-4e24-bfb8-07f8dec4fd52", "AQAAAAIAAYagAAAAEPxvsK8iDaV4XkB1JPdVgV7ZrBQfvLJmwuaXGr4LYGh7W9xIVXJxjbntqedaDJ2a8w==", null, "73251435-aee6-416d-8323-d393a073f39e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceImgUrl",
                table: "AspNetUsers");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cc514a4-a175-4bb4-b517-82152347e679", "AQAAAAIAAYagAAAAEO0rvSOLHo/bHEdkSJ9ZXBfUsbWJUbAyXmhsPTSSjUREVixyfRDYR1SA3Pyi+YriXw==", "a54835d7-fca2-4139-b109-43234adb3ace" });
        }
    }
}
