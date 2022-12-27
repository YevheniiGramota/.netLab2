using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Release",
                table: "Productions",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Release",
                value: new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Release",
                value: new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Release",
                value: new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Release",
                value: new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Release",
                value: new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Release",
                value: new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Release",
                value: new DateTime(2010, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Release",
                value: new DateTime(2016, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Release",
                value: new DateTime(2017, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Release",
                value: new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 355,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 861,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 983,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Release",
                table: "Productions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Release",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 355,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 861,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 983,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });
        }
    }
}
