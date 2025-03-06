using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookmyhome.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrugerEF",
                columns: table => new
                {
                    BrugerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efternavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Udlejer = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrugerEF", x => x.BrugerID);
                });

            migrationBuilder.CreateTable(
                name: "postnummerOgByEF",
                columns: table => new
                {
                    Postnummer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bynavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postnummerOgByEF", x => x.Postnummer);
                });

            migrationBuilder.CreateTable(
                name: "AresseEF",
                columns: table => new
                {
                    AdresseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Postnummer = table.Column<int>(type: "int", nullable: false),
                    Vejnavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Husnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostnummerOgByPostnummer = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AresseEF", x => x.AdresseID);
                    table.ForeignKey(
                        name: "FK_AresseEF_postnummerOgByEF_PostnummerOgByPostnummer",
                        column: x => x.PostnummerOgByPostnummer,
                        principalTable: "postnummerOgByEF",
                        principalColumn: "Postnummer");
                });

            migrationBuilder.CreateTable(
                name: "BoligEF",
                columns: table => new
                {
                    BoligID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresseID = table.Column<int>(type: "int", nullable: false),
                    PrisPrNat = table.Column<double>(type: "float", nullable: false),
                    HostBrugerID = table.Column<int>(type: "int", nullable: false),
                    BrugerID = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoligEF", x => x.BoligID);
                    table.ForeignKey(
                        name: "FK_BoligEF_AresseEF_AdresseID",
                        column: x => x.AdresseID,
                        principalTable: "AresseEF",
                        principalColumn: "AdresseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoligEF_BrugerEF_BrugerID",
                        column: x => x.BrugerID,
                        principalTable: "BrugerEF",
                        principalColumn: "BrugerID");
                });

            migrationBuilder.CreateTable(
                name: "AnmeldelseEF",
                columns: table => new
                {
                    AnmeldelseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<int>(type: "int", nullable: false),
                    BoligID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Kommentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnmeldelsesDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrugerID = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnmeldelseEF", x => x.AnmeldelseID);
                    table.ForeignKey(
                        name: "FK_AnmeldelseEF_BoligEF_BoligID",
                        column: x => x.BoligID,
                        principalTable: "BoligEF",
                        principalColumn: "BoligID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnmeldelseEF_BrugerEF_BrugerID",
                        column: x => x.BrugerID,
                        principalTable: "BrugerEF",
                        principalColumn: "BrugerID");
                });

            migrationBuilder.CreateTable(
                name: "BookingEF",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<int>(type: "int", nullable: false),
                    BoligID = table.Column<int>(type: "int", nullable: false),
                    StartDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SlutDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPris = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrugerID = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingEF", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_BookingEF_BoligEF_BoligID",
                        column: x => x.BoligID,
                        principalTable: "BoligEF",
                        principalColumn: "BoligID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingEF_BrugerEF_BrugerID",
                        column: x => x.BrugerID,
                        principalTable: "BrugerEF",
                        principalColumn: "BrugerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnmeldelseEF_BoligID",
                table: "AnmeldelseEF",
                column: "BoligID");

            migrationBuilder.CreateIndex(
                name: "IX_AnmeldelseEF_BrugerID",
                table: "AnmeldelseEF",
                column: "BrugerID");

            migrationBuilder.CreateIndex(
                name: "IX_AresseEF_PostnummerOgByPostnummer",
                table: "AresseEF",
                column: "PostnummerOgByPostnummer");

            migrationBuilder.CreateIndex(
                name: "IX_BoligEF_AdresseID",
                table: "BoligEF",
                column: "AdresseID");

            migrationBuilder.CreateIndex(
                name: "IX_BoligEF_BrugerID",
                table: "BoligEF",
                column: "BrugerID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingEF_BoligID",
                table: "BookingEF",
                column: "BoligID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingEF_BrugerID",
                table: "BookingEF",
                column: "BrugerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnmeldelseEF");

            migrationBuilder.DropTable(
                name: "BookingEF");

            migrationBuilder.DropTable(
                name: "BoligEF");

            migrationBuilder.DropTable(
                name: "AresseEF");

            migrationBuilder.DropTable(
                name: "BrugerEF");

            migrationBuilder.DropTable(
                name: "postnummerOgByEF");
        }
    }
}
