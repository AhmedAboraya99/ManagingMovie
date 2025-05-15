using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MananagingMovie.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Nationalities_nationalityId",
                table: "Directors");

            migrationBuilder.RenameColumn(
                name: "nationalityId",
                table: "Directors",
                newName: "NationalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Directors_nationalityId",
                table: "Directors",
                newName: "IX_Directors_NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors");

            migrationBuilder.RenameColumn(
                name: "NationalityId",
                table: "Directors",
                newName: "nationalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors",
                newName: "IX_Directors_nationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Nationalities_nationalityId",
                table: "Directors",
                column: "nationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
