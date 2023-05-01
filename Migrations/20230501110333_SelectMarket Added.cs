using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class SelectMarketAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectMarket",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectMarket",
                table: "Products");
        }
    }
}
