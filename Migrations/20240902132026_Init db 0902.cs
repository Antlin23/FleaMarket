using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Initdb0902 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "2cd30798-c935-45d5-9016-6a529a74b4e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "c8a88fca-a3a6-491c-91dd-a3e1bd06a8b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b482ef5a-5323-4327-8efe-b80b906bdd19", "AQAAAAIAAYagAAAAEAUdePXF3D0/Ls/ZOcH27N6WCfIyipmkWMKvEckrmAds9Kt1Jcl8AHX4uqPd9jOSMg==", "0dd818da-8e81-4f58-8153-68ae29d0030f" });
        }
    }
}
