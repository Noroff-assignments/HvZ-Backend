using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedingChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginTime", "EndTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginTime", "EndTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "EndTime",
                value: new DateTime(2023, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 9,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 10,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 11,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 12,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 13,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 14,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 16,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 17,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 18,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 19,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 20,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 21,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 22,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 23,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 24,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 25,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 26,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 27,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 28,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 29,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 31,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 32,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 33,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 34,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 35,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 36,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 37,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 38,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 39,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 40,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 41,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 42,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 43,
                column: "DeadStory",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 44,
                column: "DeadStory",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginTime", "EndTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginTime", "EndTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "EndTime",
                value: new DateTime(2023, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 9,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 10,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 11,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 12,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 13,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 14,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 16,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 17,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 18,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 19,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 20,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 21,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 22,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 23,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 24,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 25,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 26,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 27,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 28,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 29,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 31,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 32,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 33,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 34,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 35,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 36,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 37,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 38,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 39,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 40,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 41,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 42,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 43,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 44,
                column: "DeadStory",
                value: "A lone human is hunted down and brutally killed by a ravenous zombie.");
        }
    }
}
