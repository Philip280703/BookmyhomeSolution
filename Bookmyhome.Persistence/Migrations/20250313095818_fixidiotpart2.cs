using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookmyhome.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fixidiotpart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_postnummerOgByEF",
                table: "postnummerOgByEF");

            migrationBuilder.RenameTable(
                name: "postnummerOgByEF",
                newName: "PostnummerOgByEF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostnummerOgByEF",
                table: "PostnummerOgByEF",
                column: "Postnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresseEF_PostnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF",
                column: "PostnummerOgByPostnummer",
                principalTable: "PostnummerOgByEF",
                principalColumn: "Postnummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresseEF_PostnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostnummerOgByEF",
                table: "PostnummerOgByEF");

            migrationBuilder.RenameTable(
                name: "PostnummerOgByEF",
                newName: "postnummerOgByEF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_postnummerOgByEF",
                table: "postnummerOgByEF",
                column: "Postnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF",
                column: "PostnummerOgByPostnummer",
                principalTable: "postnummerOgByEF",
                principalColumn: "Postnummer");
        }
    }
}
