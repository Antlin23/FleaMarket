using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class isActiveSelleradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActiveSeller",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "0bc36705-fad3-480a-8c90-080dd9a68d37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "abf47963-8b12-4d11-97cf-1c4b7ff89ac7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isActiveSeller" },
                values: new object[] { "126e7410-91a8-4f4e-a85d-7bc0fbd201ce", "AQAAAAIAAYagAAAAEKOz37LDBw22rh8pVBj83U2G5IST0J/3w1r2uUDWOPx2CmWqRgHcJedHy0q4XSeO6g==", "49758bc2-b8cb-47d7-96c7-aa910e0574db", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActiveSeller",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "c3e99375-71a3-4b07-9993-1b064d90d52a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "fdc9455d-3f5e-48e7-b7fe-c9e5bd7bdc7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e5842a-77dc-4c74-8739-864e574fe00a", "AQAAAAIAAYagAAAAELXxZ1kitJrj5TUz7iflR4nq8HN5EzYl67V9N28DZ32Vk7fEj0uLEfXL8dAeKJBdSg==", "e2c35fa7-8703-407e-b815-14cfc297ed6e" });
        }
    }
}
