using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class MarketNametoMarketId0415 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectMarket",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "MarketId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f851ae6-f00c-41d9-8604-4e061c7b5d7c", "AQAAAAIAAYagAAAAEGblo0eDml3GWEQ3Jf5KRWGOKVdBC321a/4K6rlBGJseSrUfRQSZ6sba6Pv+7nal3Q==", "7585fbbb-9cac-40e4-bf1e-88484a580419" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarketId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "SelectMarket",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "c0715f63-a668-4db8-9e14-b70709ad2096");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "a7402899-9617-49d2-9019-629f334b7ada");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63be9f6c-181c-410a-8605-6702b7030169", "AQAAAAIAAYagAAAAEKdbAzTlTUytVNa6AVqMEblKWHs07RYEvwrqA6eo7FcQEQy6fAIpAWvmn+j6yai9vg==", "68486237-7066-468b-8ca5-36feda6220b5" });
        }
    }
}
