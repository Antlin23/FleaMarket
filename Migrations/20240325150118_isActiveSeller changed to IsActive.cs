using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class isActiveSellerchangedtoIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActiveSeller",
                table: "AspNetUsers",
                newName: "IsActiveSeller");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "5c652248-ece5-46e6-8c8b-4ccf975891b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "711e0836-e009-42d0-97f0-6e2712b29af7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78e5a660-468b-4d18-a32d-26a05523757c", "AQAAAAIAAYagAAAAENZLr8JLXoN6YBHTIaakeJoDe++Egks2ldbmacM/LN7Jt0x03Rjfuw+1cPaZhxeX0w==", "5d508548-c4a0-4ad2-a94c-0d0b1ce02511" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActiveSeller",
                table: "AspNetUsers",
                newName: "isActiveSeller");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126e7410-91a8-4f4e-a85d-7bc0fbd201ce", "AQAAAAIAAYagAAAAEKOz37LDBw22rh8pVBj83U2G5IST0J/3w1r2uUDWOPx2CmWqRgHcJedHy0q4XSeO6g==", "49758bc2-b8cb-47d7-96c7-aa910e0574db" });
        }
    }
}
