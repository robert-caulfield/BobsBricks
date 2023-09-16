using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BobsBricks.Migrations
{
    /// <inheritdoc />
    public partial class AddPieceCountToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PieceCount",
                table: "Products",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PieceCount",
                table: "Products");
        }
    }
}
