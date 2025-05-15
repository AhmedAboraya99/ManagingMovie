using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MananagingMovie.Migrations
{
    /// <inheritdoc />
    public partial class dd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Directors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors",
                column: "NationalityId",
                unique: true,
                filter: "[NationalityId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors",
                column: "NationalityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Nationalities_NationalityId",
                table: "Directors",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
