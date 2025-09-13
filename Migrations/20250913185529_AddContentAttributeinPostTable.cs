using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_Site.Migrations
{
    /// <inheritdoc />
    public partial class AddContentAttributeinPostTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "tbl_Post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "tbl_Post");
        }
    }
}
