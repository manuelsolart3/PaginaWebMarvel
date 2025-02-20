using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMarvel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteuniqueinReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comic_Reference",
                table: "Comic");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comic_Reference",
                table: "Comic",
                column: "Reference",
                unique: true);
        }
    }
}
