using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class FM021601 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "730b38e0-2251-478d-9e9e-5858eaa87d51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "bddd1560-b84e-4682-b061-28528e8ec7a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "CompanyName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "ad5a4ba5-6656-4e48-a088-8c660467cd63", "AQAAAAIAAYagAAAAEPismtfmMXuQvB75cpe58/RzdG3LX115o93+lGtr4OO8Rx/RbZQeBv3+9MnqMsAxbw==", "4c263391-9fd1-4f34-9e93-d9b308deec13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "24c4d955-1152-43b1-95fe-f5bc6ffb1606");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1a9e5ab7-b673-4d29-8dbb-d9ed7bfdd1a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "080a3208-5dd5-41a2-b516-045770a60508", "AQAAAAIAAYagAAAAEAQHU5Vh+TYIArqzLKcbBBvpB+PUeRpKi1nnd9QL18jweTPozRD/5ZJDvsiIk9AHqw==", "e9796391-2da5-45bc-9447-f32405c08385" });
        }
    }
}
