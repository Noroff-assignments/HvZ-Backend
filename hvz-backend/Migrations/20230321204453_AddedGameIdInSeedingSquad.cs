using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedGameIdInSeedingSquad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 4,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 5,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 6,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 7,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 8,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 9,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 10,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 11,
                column: "GameId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 12,
                column: "GameId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 13,
                column: "GameId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 14,
                column: "GameId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 4,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 5,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 6,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 7,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 8,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 9,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 10,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 11,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 12,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 13,
                column: "GameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 14,
                column: "GameId",
                value: null);
        }
    }
}
