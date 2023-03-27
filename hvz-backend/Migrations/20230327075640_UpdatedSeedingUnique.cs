using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedingUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_MapId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "AmountPlayers",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "AmountPlayers",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "AmountPlayers",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "AmountPlayers",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643099999999997, 12.361269999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646357000000002, 12.421889999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643881999999998, 12.637560000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647599, 12.357810000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645328999999997, 12.46233 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642677999999997, 12.59675 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649118000000001, 12.50047 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648287000000003, 12.545820000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645980999999999, 12.52614 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641776999999998, 12.58544 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646194999999999, 12.63626 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642767999999997, 12.463559999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649718, 12.62091 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647818999999998, 12.66755 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648637999999998, 12.445080000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646389999999997, 12.67042 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643956000000003, 12.510149999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641734999999997, 12.54105 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642440999999998, 12.629110000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648542999999997, 12.682370000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647739000000001, 12.42708 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641782999999997, 12.623620000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643312999999999, 12.660030000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646887, 12.43755 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642341999999999, 12.29481 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646901999999997, 12.61218 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644401000000002, 12.33206 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647176999999999, 12.614570000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647126999999998, 12.347939999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645955000000001, 12.405860000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646526000000001, 12.662280000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645023999999999, 12.60324 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646785000000001, 12.65475 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645184, 12.269679999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644258000000001, 12.49132 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645797000000002, 12.661569999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646923999999999, 12.56429 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649616000000002, 12.500220000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649492000000002, 12.62576 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645041999999997, 12.346209999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647857999999999, 12.577439999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645763000000002, 12.263960000000001 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644745, 12.583679999999999 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648788000000003, 12.62778 });

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Radius",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Radius",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Radius",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Radius",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Radius",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Radius",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Radius",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Radius",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Radius",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Radius",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Radius",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Radius",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643500000000003, 12.237679999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644799999999996, 12.287129999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647100000000002, 12.43557 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645899999999997, 12.48296 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6432, 12.25722 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646799999999999, 12.347799999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643900000000002, 12.469469999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647599999999997, 12.42536 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642600000000002, 12.35295 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645099999999999, 12.54678 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642899999999997, 12.67 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645499999999998, 12.62989 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646700000000003, 12.56438 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6447, 12.643789999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646500000000003, 12.2925 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642499999999998, 12.460129999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648499999999999, 12.63017 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641800000000003, 12.50915 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645800000000001, 12.625030000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6417, 12.4069 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642200000000003, 12.43872 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649099999999997, 12.602600000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645200000000003, 12.32761 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641500000000001, 12.49126 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6462, 12.23889 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649700000000003, 12.439069999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644199999999998, 12.63495 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643099999999997, 12.403180000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6494, 12.5962 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648600000000002, 12.526759999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644500000000001, 12.65934 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641599999999997, 12.300039999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647500000000001, 12.615220000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643999999999998, 12.59066 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6479, 12.255470000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643500000000003, 12.237679999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644799999999996, 12.287129999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647100000000002, 12.43557 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645899999999997, 12.48296 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6432, 12.25722 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646799999999999, 12.347799999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643900000000002, 12.469469999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647599999999997, 12.42536 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642600000000002, 12.35295 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645099999999999, 12.54678 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642899999999997, 12.67 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645499999999998, 12.62989 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646700000000003, 12.56438 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6447, 12.643789999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646500000000003, 12.2925 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642499999999998, 12.460129999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648499999999999, 12.63017 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641800000000003, 12.50915 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645800000000001, 12.625030000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6417, 12.4069 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642200000000003, 12.43872 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649099999999997, 12.602600000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645200000000003, 12.32761 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641500000000001, 12.49126 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6462, 12.23889 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649700000000003, 12.439069999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644199999999998, 12.63495 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643099999999997, 12.403180000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6494, 12.5962 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648600000000002, 12.526759999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644500000000001, 12.65934 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641599999999997, 12.300039999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647500000000001, 12.615220000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643999999999998, 12.59066 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.6479, 12.255470000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644280999999999, 12.560840000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647011999999997, 12.531980000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641458999999998, 12.68234 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649614999999997, 12.29467 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645873000000002, 12.646559999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642377000000003, 12.421519999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645180000000003, 12.50769 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646549999999998, 12.36387 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642304000000003, 12.574059999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649596000000003, 12.26496 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645009999999999, 12.64626 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642232999999997, 12.536490000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644129, 12.34498 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646794, 12.670640000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648803999999998, 12.546110000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645417000000002, 12.369529999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644354999999997, 12.439209999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645570999999997, 12.40523 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643405000000001, 12.457560000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647139000000003, 12.4757 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644838, 12.31005 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648135000000003, 12.46468 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641616999999997, 12.572939999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648733999999997, 12.63134 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646774999999998, 12.64447 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642524000000002, 12.29176 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647041999999999, 12.511900000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646455000000003, 12.425560000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648730999999998, 12.28857 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647255999999999, 12.251049999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642223000000001, 12.38616 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642437000000001, 12.564209999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647275, 12.35027 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.641447999999997, 12.38627 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648224999999996, 12.65559 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649881999999998, 12.63941 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644596, 12.54533 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647924000000003, 12.649850000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643099999999997, 12.67812 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643085999999997, 12.62214 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648066999999998, 12.58765 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647945, 12.537419999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646982000000001, 12.32794 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648377000000004, 12.502129999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646231, 12.47391 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648924000000001, 12.62735 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646220999999997, 12.43281 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.649253999999999, 12.63527 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647449999999999, 12.558339999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648313999999999, 12.28895 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648791000000003, 12.53702 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644719000000002, 12.67788 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648617000000002, 12.57329 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646906999999999, 12.525980000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647917999999997, 12.506779999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.646428, 12.57047 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648944, 12.260009999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647840000000002, 12.62533 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645927, 12.642189999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648432, 12.475020000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645721999999999, 12.360910000000001 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648463, 12.438789999999999 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648874999999997, 12.37205 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.644204999999999, 12.28575 });

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 1,
                column: "ZombieVisible",
                value: false);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 2,
                column: "ZombieVisible",
                value: false);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 3,
                column: "ZombieVisible",
                value: false);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 4,
                column: "ZombieVisible",
                value: false);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648038999999997, 12.58672 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645367, 12.3729 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647910000000003, 12.67845 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648038999999997, 12.58672 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645367, 12.3729 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647910000000003, 12.67845 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648038999999997, 12.58672 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645367, 12.3729 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647910000000003, 12.67845 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.648038999999997, 12.58672 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.645367, 12.3729 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.647910000000003, 12.67845 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_MapId",
                table: "Games",
                column: "MapId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_MapId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "AmountPlayers",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "AmountPlayers",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "AmountPlayers",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "AmountPlayers",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Kills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Radius",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.27144 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.271445 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.642780000000002, 12.27144 });

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 1,
                column: "ZombieVisible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 2,
                column: "ZombieVisible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 3,
                column: "ZombieVisible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Safezones",
                keyColumn: "Id",
                keyValue: 4,
                column: "ZombieVisible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "TotalDead", "TotalPlayer" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 55.643242999999998, 12.270559 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_MapId",
                table: "Games",
                column: "MapId");
        }
    }
}
