using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment0.Migrations
{
    /// <inheritdoc />
    public partial class SiteUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "SiteUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteUserId",
                table: "Users",
                newName: "UserId");
        }
    }
}
