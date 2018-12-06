using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicLayer.Migrations
{
    public partial class addedUserRoleWithE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "Users",
                newName: "Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "Rol");
        }
    }
}
