using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProj.Migrations
{
    /// <inheritdoc />
    public partial class hotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    hotel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotel_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hotel_phone = table.Column<long>(type: "bigint", nullable: false),
                    hotel_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detailed_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    room_types = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whats_nearby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policies = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.hotel_id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotel_id = table.Column<int>(type: "int", nullable: false),
                    room_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    room_price = table.Column<int>(type: "int", nullable: false),
                    room_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    room_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    availability = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
