using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DummyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countryStateWeather",
                columns: table => new
                {
                    SWMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countryStateWeather", x => x.SWMId);
                });

            migrationBuilder.CreateTable(
                name: "weather",
                columns: table => new
                {
                    WMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TemperatureC = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Humidity = table.Column<int>(type: "int", nullable: false),
                    WindSpeed = table.Column<double>(type: "float", nullable: false),
                    CountryStateWeatherModelSWMId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weather", x => x.WMId);
                    table.ForeignKey(
                        name: "FK_weather_countryStateWeather_CountryStateWeatherModelSWMId",
                        column: x => x.CountryStateWeatherModelSWMId,
                        principalTable: "countryStateWeather",
                        principalColumn: "SWMId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_weather_CountryStateWeatherModelSWMId",
                table: "weather",
                column: "CountryStateWeatherModelSWMId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "weather");

            migrationBuilder.DropTable(
                name: "countryStateWeather");
        }
    }
}
