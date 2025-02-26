using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_01_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddStudCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => new { x.stud_ID, x.Course_ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudCourse");
        }
    }
}
