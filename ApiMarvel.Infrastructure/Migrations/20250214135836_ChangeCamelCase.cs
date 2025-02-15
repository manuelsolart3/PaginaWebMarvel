using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMarvel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCamelCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "identification",
                table: "User",
                newName: "Identification");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Identification",
                table: "User",
                newName: "identification");
        }
    }
}
