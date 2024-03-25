using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class IsActiveclaimsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "a0430920-4bd4-4c42-8c5c-5c2d8f3a1f62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1556cef3-8793-48a5-a4f5-ccb5cadf798e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f04c2603-72c4-40ce-b96e-f5ff8ae439ef", "AQAAAAIAAYagAAAAEHjsa2sr/LDVm48J1Ijxq6KrQPVRcDz4EKsM234DOuBbl17W8VL7qvCh5RVOQdF47g==", "965b8aba-c1f4-4d78-8fd5-ae29852b72c4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
