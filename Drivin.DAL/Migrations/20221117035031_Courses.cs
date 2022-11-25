using Microsoft.EntityFrameworkCore.Migrations;

namespace Drivin.DAL.Migrations
{
    public partial class Courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutomaticHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutomaticCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutomaticPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutomaticPhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighwayHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighwayCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighwayPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighwayPhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalPhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
