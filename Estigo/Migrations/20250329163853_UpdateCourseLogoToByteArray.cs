using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseLogoToByteArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // First, add a temporary column
            migrationBuilder.AddColumn<byte[]>(
                name: "LogoTemp",
                table: "Courses",
                type: "varbinary(max)",
                nullable: true);

            // Drop the existing Logo column
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Courses");

            // Add the new Logo column
            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Courses",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the new Logo column
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Courses");

            // Add back the original string Logo column
            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
