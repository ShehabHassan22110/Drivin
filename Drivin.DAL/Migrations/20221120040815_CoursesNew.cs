using Microsoft.EntityFrameworkCore.Migrations;

namespace Drivin.DAL.Migrations
{
    public partial class CoursesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutomaticCaption",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AutomaticHeader",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AutomaticPhotoName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AutomaticPrice",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HighwayCaption",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HighwayHeader",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HighwayPhotoName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HighwayPrice",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "InternationalPrice",
                table: "Courses",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "InternationalPhotoName",
                table: "Courses",
                newName: "PhotoName");

            migrationBuilder.RenameColumn(
                name: "InternationalHeader",
                table: "Courses",
                newName: "Header");

            migrationBuilder.RenameColumn(
                name: "InternationalCaption",
                table: "Courses",
                newName: "Caption");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Courses",
                newName: "InternationalPrice");

            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "Courses",
                newName: "InternationalPhotoName");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Courses",
                newName: "InternationalHeader");

            migrationBuilder.RenameColumn(
                name: "Caption",
                table: "Courses",
                newName: "InternationalCaption");

            migrationBuilder.AddColumn<string>(
                name: "AutomaticCaption",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutomaticHeader",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutomaticPhotoName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutomaticPrice",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighwayCaption",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighwayHeader",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighwayPhotoName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighwayPrice",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
