using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitDb413264 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa91dc40-7a59-4978-b0f3-608a8ba2a539", "AQAAAAIAAYagAAAAEJ9se7JO2BeTqA3ZpUKNPx8vi070HYvPmd8ZMxfEQbuzO9jnRciJDGYRzG4YbPx/9g==", "675098f4-1a82-48f6-bde8-b3f3785f491f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "bd44a682-0ed2-450b-b7a3-3057f28c8bd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "61d5ceea-41ec-4f42-8080-338facec9043");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaae80c3-fab7-42a1-a27c-ec314131826b", "AQAAAAIAAYagAAAAEJYoNFjHtcI5Z7pkYCDjdamfpr1xg9iLs49apz3kGIEFfoVHPeAWl2vFXetW5W6T7Q==", "eac637c3-f5fe-41a2-a01e-1c5329c3f0cb" });
        }
    }
}
