using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberiaUniversity.Migrations
{
    public partial class DropID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment");

            migrationBuilder.DropIndex(
                name: "IX_CourseAssignment_CourseID",
                table: "CourseAssignment");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CourseAssignment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment",
                columns: new[] { "CourseID", "InstructorID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CourseAssignment",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignment_CourseID",
                table: "CourseAssignment",
                column: "CourseID");
        }
    }
}
