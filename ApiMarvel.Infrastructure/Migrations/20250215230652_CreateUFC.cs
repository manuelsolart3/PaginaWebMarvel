using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMarvel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateUFC : Migration
    {
        /// <inheritdoc />
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.CreateTable(
                    name: "UserFavoriteComics",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                        UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ComicId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_UserFavoriteComics", x => x.Id);
                        table.ForeignKey(
                            name: "FK_UserFavoriteComics_Comic_ComicId",
                            column: x => x.ComicId,
                            principalTable: "Comic",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                        table.ForeignKey(
                            name: "FK_UserFavoriteComics_User_UserId",
                            column: x => x.UserId,
                            principalTable: "User",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    })
                    .Annotation("MySql:CharSet", "utf8mb4");

                migrationBuilder.CreateIndex(
                    name: "IX_UserFavoriteComics_ComicId",
                    table: "UserFavoriteComics",
                    column: "ComicId");

                migrationBuilder.CreateIndex(
                    name: "IX_UserFavoriteComics_UserId",
                    table: "UserFavoriteComics",
                    column: "UserId");
            }

            /// <inheritdoc />
            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "UserFavoriteComics");
            }
        }
    }
