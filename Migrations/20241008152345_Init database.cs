using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Initdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "fde76d7b-1089-4419-9b26-827150ca709a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "4f9167f6-8c1c-4b0a-ad6b-42616aa5c069");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "732aeaba-4479-4473-a79c-4d4eb77cdf7c", "AQAAAAIAAYagAAAAEM22pQ6cOurrlhGAGgVyhwtPhQUbFJIU5JZGz/sE+BAFUPYxlzi5qqQ2Z1nPvES0xw==", "25202f46-b3f2-43bb-a32d-a01568072dc3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "f03149e9-90eb-4fb4-ba2d-9dba9eb73c1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "ffc73379-bf37-4275-b44a-b6046e792729");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "093cdd2a-f186-41ed-b7e8-ef82dd6a6fdf", "AQAAAAIAAYagAAAAEHPlAfkVvNRW28X46UONzwMsuGvGYuHvnKD2kDlS85Tl85xWxcMtaAVd1iR4kYRWwQ==", "5fcaf78f-208c-4b3e-b056-54c4cd3f0bed" });
        }
    }
}
