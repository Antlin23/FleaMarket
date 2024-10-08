using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Initdatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "3cec734a-f8ea-45b3-a455-c259709f1e3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1c66d40d-1d4e-4700-a2d2-720717128d9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd2d99e6-5657-4ae4-9e3e-280a8c6525ff", "AQAAAAIAAYagAAAAEHwW0yFGgIRMOcCK9rdzCKz0QNgprfwwRIw+3Tr75BG8/dKtol81u65yLdu3BtYOhQ==", "8971c03b-30a8-408c-b54a-7737ccd0ed8f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
