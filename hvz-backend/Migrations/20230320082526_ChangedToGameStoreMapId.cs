using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedToGameStoreMapId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Games_GameId",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Maps_GameId",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Maps");

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "MapId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "MapId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "MapId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "MapId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Games_MapId",
                table: "Games",
                column: "MapId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Maps_MapId",
                table: "Games",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Maps_MapId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_MapId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 4,
                column: "GameId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Maps_GameId",
                table: "Maps",
                column: "GameId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Games_GameId",
                table: "Maps",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
