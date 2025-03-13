using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookmyhome.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdresseEFrettet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AresseEF");

            migrationBuilder.DropForeignKey(
                name: "FK_BoligEF_AresseEF_AdresseID",
                table: "BoligEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AresseEF",
                table: "AresseEF");

            migrationBuilder.RenameTable(
                name: "AresseEF",
                newName: "AdresseEF");

            migrationBuilder.RenameIndex(
                name: "IX_AresseEF_PostnummerOgByPostnummer",
                table: "AdresseEF",
                newName: "IX_AdresseEF_PostnummerOgByPostnummer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdresseEF",
                table: "AdresseEF",
                column: "AdresseID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF",
                column: "PostnummerOgByPostnummer",
                principalTable: "postnummerOgByEF",
                principalColumn: "Postnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_BoligEF_AdresseEF_AdresseID",
                table: "BoligEF",
                column: "AdresseID",
                principalTable: "AdresseEF",
                principalColumn: "AdresseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AdresseEF");

            migrationBuilder.DropForeignKey(
                name: "FK_BoligEF_AdresseEF_AdresseID",
                table: "BoligEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdresseEF",
                table: "AdresseEF");

            migrationBuilder.RenameTable(
                name: "AdresseEF",
                newName: "AresseEF");

            migrationBuilder.RenameIndex(
                name: "IX_AdresseEF_PostnummerOgByPostnummer",
                table: "AresseEF",
                newName: "IX_AresseEF_PostnummerOgByPostnummer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AresseEF",
                table: "AresseEF",
                column: "AdresseID");

            migrationBuilder.AddForeignKey(
                name: "FK_AresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                table: "AresseEF",
                column: "PostnummerOgByPostnummer",
                principalTable: "postnummerOgByEF",
                principalColumn: "Postnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_BoligEF_AresseEF_AdresseID",
                table: "BoligEF",
                column: "AdresseID",
                principalTable: "AresseEF",
                principalColumn: "AdresseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
