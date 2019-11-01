using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "SquareMileage", "Terrain" },
                values: new object[] { 1, "The hottest, driest and lowest of all the national parks in the United States.", "Eastern California; Nevada", "Death Valley National Park", 5262, "Harsh desert, salt-flats, sand dunes, badlands, valleys, canyons, mountains" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "SquareMileage", "Terrain" },
                values: new object[] { 2, "The largest national park in the United States. This park includes a large portion of the Saint Elias Mountains, which include most of the highest peaks in the United States and Canada.", "Eastern region of South-central Alaska", "Wrangell-St. Elias National Park & Preserve", 20587, "Mountains, glaciers, rivers, tundra, forest, tidewaters, alpine" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "SquareMileage", "Terrain" },
                values: new object[] { 3, "Established in 1872, it was the first national park in the United States. The volcanic plumbing beneath the park is still active, giving energy to more than ten thousand hot springs, mud pots, terraces, and geysers.", "Wyoming, Montana, Idaho", "Yellowstone National Park", 3471, "Mountains, canyons, rivers, waterfalls, forests" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);
        }
    }
}
