using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySBank.Migrations
{
    public partial class personid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Users",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PersonID",
                table: "Users",
                newName: "IX_Users_PersonId");

            migrationBuilder.AlterColumn<long>(
                name: "PersonId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Users",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                newName: "IX_Users_PersonID");

            migrationBuilder.AlterColumn<long>(
                name: "PersonID",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
