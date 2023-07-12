using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarrisonsShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InStock",
                table: "Pies",
                newName: "IsPiInStock");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPiInStock",
                table: "Pies",
                newName: "InStock");
        }
    }
}
