using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApi.Migrations
{
    public partial class HotelModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Hotels",
                newName: "HotelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HotelID",
                table: "Hotels",
                newName: "HotelId");
        }
    }
}
