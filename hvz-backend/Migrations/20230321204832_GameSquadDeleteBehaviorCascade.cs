using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class GameSquadDeleteBehaviorCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squads_Games_GameId",
                table: "Squads");

            migrationBuilder.AddForeignKey(
                name: "FK_Squads_Games_GameId",
                table: "Squads",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squads_Games_GameId",
                table: "Squads");

            migrationBuilder.AddForeignKey(
                name: "FK_Squads_Games_GameId",
                table: "Squads",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
