using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Updatingforclaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "28ca433e-0a38-4cc1-b415-6bd1c6eec4b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "e97801c2-1816-43d6-9d46-e87d6c580be5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5443e8c-0eba-4b4a-b00f-9cd3ee802719", "AQAAAAIAAYagAAAAEHhkLRxu7EVj6Nb3GZGlMXhtONsy6l5uK101zH6oOISTBkmQhmbvBz9mWsMW5Woc7Q==", "03e8ba2e-3729-4928-ada3-8d076fbb1b7b" });
        }
    }
}
