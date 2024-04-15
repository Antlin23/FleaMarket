using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class TrueAdmin014 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63be9f6c-181c-410a-8605-6702b7030169", true, "AQAAAAIAAYagAAAAEKdbAzTlTUytVNa6AVqMEblKWHs07RYEvwrqA6eo7FcQEQy6fAIpAWvmn+j6yai9vg==", "68486237-7066-468b-8ca5-36feda6220b5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "62be59ae-e64e-42cb-97ec-579188ac626a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "9afbb2e6-5862-4a47-a387-9bf7af1bfe10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa91dc40-7a59-4978-b0f3-608a8ba2a539", false, "AQAAAAIAAYagAAAAEJ9se7JO2BeTqA3ZpUKNPx8vi070HYvPmd8ZMxfEQbuzO9jnRciJDGYRzG4YbPx/9g==", "675098f4-1a82-48f6-bde8-b3f3785f491f" });
        }
    }
}
