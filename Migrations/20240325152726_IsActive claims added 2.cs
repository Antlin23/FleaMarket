using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class IsActiveclaimsadded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "40d0c233-3323-4847-b669-db4788bf0add");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "afa5ceec-f6f5-4a29-8551-5981685cc935");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd418c5-0936-4107-9f7d-49993eba7c0a", "AQAAAAIAAYagAAAAEPb8SEaa5A9TEM7cHMewzNVFJcTAXi8QD9b84lwt3ONfCxDaPcuDa9t4SciDUcKZWw==", "f1c494ab-bb49-4fb3-807f-d5954b84bbb7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
