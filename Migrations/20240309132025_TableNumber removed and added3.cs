using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class TableNumberremovedandadded3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "TableNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TableNumber" },
                values: new object[] { "f5443e8c-0eba-4b4a-b00f-9cd3ee802719", "AQAAAAIAAYagAAAAEHhkLRxu7EVj6Nb3GZGlMXhtONsy6l5uK101zH6oOISTBkmQhmbvBz9mWsMW5Woc7Q==", "03e8ba2e-3729-4928-ada3-8d076fbb1b7b", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "TableNumber",
                table: "Products",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "52cd9436-547b-4d5e-bd7c-d68aea896955");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "cac43cfb-79be-4363-8aca-a9c7cce5c1c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd90cc89-4af1-4982-ab82-208095b3c72a", "AQAAAAIAAYagAAAAEOMMxMTr+//AJxofAUGnOcmFXCLqujdG29e/ki45Qwp2f+9ykYxJGpP8/rXxGr2IVA==", "d38a80c8-f2ee-4b58-83d2-ac4275629706" });
        }
    }
}
