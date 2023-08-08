using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourism.Migrations
{
    /// <inheritdoc />
    public partial class pa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Packages",
                table: "Packages");

            migrationBuilder.RenameTable(
                name: "Packages",
                newName: "packages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_packages",
                table: "packages",
                column: "package_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_packages",
                table: "packages");

            migrationBuilder.RenameTable(
                name: "packages",
                newName: "Packages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Packages",
                table: "Packages",
                column: "package_id");
        }
    }
}
