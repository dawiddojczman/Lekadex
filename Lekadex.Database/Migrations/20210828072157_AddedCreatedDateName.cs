using Microsoft.EntityFrameworkCore.Migrations;

namespace Lekadex.Database.Migrations
{
    public partial class AddedCreatedDateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Prescriptions",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Prescriptions",
                newName: "CreateDate");
        }
    }
}
