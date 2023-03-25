using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class MadeGameMaptoOneMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_MapId",
                table: "Games");

            migrationBuilder.CreateIndex(
                name: "IX_Games_MapId",
                table: "Games",
                column: "MapId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_MapId",
                table: "Games");

            migrationBuilder.CreateIndex(
                name: "IX_Games_MapId",
                table: "Games",
                column: "MapId",
                unique: true);
        }
    }
}
