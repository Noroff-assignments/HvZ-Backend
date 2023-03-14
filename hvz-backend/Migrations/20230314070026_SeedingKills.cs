using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedingKills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kills",
                columns: new[] { "Id", "DeadStory", "GameId", "KillerId", "TimeDead", "VictimId" },
                values: new object[,]
                {
                    { 3, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 18, new DateTime(2023, 3, 11, 9, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 24, new DateTime(2023, 3, 11, 9, 55, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 5, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 1, new DateTime(2023, 3, 11, 10, 10, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 6, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 3, new DateTime(2023, 3, 11, 10, 16, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 7, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 3, new DateTime(2023, 3, 11, 10, 33, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 8, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 7, new DateTime(2023, 3, 11, 10, 47, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 9, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 9, new DateTime(2023, 3, 11, 10, 56, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 10, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 1, new DateTime(2023, 3, 11, 11, 17, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 11, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 18, new DateTime(2023, 3, 11, 11, 22, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 12, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 16, new DateTime(2023, 3, 11, 11, 38, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 13, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 11, new DateTime(2023, 3, 11, 11, 49, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 14, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 13, new DateTime(2023, 3, 11, 11, 51, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 15, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 36, new DateTime(2023, 3, 12, 9, 19, 0, 0, DateTimeKind.Unspecified), 66 },
                    { 16, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 36, new DateTime(2023, 3, 12, 9, 32, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 17, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 55, new DateTime(2023, 3, 12, 9, 44, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 18, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 66, new DateTime(2023, 3, 12, 9, 58, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 19, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 38, new DateTime(2023, 3, 12, 10, 16, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 20, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 50, new DateTime(2023, 3, 12, 10, 23, 0, 0, DateTimeKind.Unspecified), 68 },
                    { 21, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 36, new DateTime(2023, 3, 12, 10, 47, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 22, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 66, new DateTime(2023, 3, 12, 10, 50, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 23, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 68, new DateTime(2023, 3, 12, 11, 7, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 24, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 40, new DateTime(2023, 3, 12, 11, 27, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 25, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 60, new DateTime(2023, 3, 12, 11, 33, 0, 0, DateTimeKind.Unspecified), 65 },
                    { 26, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 50, new DateTime(2023, 3, 12, 11, 41, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 27, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 40, new DateTime(2023, 3, 12, 11, 44, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 28, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 68, new DateTime(2023, 3, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 29, "A lone human is hunted down and brutally killed by a ravenous zombie.", 2, 57, new DateTime(2023, 3, 12, 11, 52, 0, 0, DateTimeKind.Unspecified), 63 },
                    { 30, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 2, new DateTime(2023, 3, 29, 9, 13, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 31, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 2, new DateTime(2023, 3, 29, 9, 24, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 32, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 12, new DateTime(2023, 3, 29, 9, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 2, new DateTime(2023, 3, 29, 9, 55, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 34, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 15, new DateTime(2023, 3, 29, 10, 7, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 35, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 20, new DateTime(2023, 3, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 36, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 25, new DateTime(2023, 3, 29, 10, 20, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 37, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 2, new DateTime(2023, 3, 29, 10, 35, 0, 0, DateTimeKind.Unspecified), 64 },
                    { 38, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 8, new DateTime(2023, 3, 29, 10, 40, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 39, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 15, new DateTime(2023, 3, 29, 10, 47, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 40, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 44, new DateTime(2023, 3, 29, 11, 2, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 41, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 70, new DateTime(2023, 3, 29, 11, 16, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 42, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 64, new DateTime(2023, 3, 29, 11, 24, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 43, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 6, new DateTime(2023, 3, 29, 11, 41, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 44, "A lone human is hunted down and brutally killed by a ravenous zombie.", 3, 27, new DateTime(2023, 3, 29, 11, 49, 0, 0, DateTimeKind.Unspecified), 54 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 44);
        }
    }
}
