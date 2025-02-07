using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCoreProject1.Migrations
{
    /// <inheritdoc />
    public partial class RemovedColumn3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Column3",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Column3",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
