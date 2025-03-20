﻿// <auto-generated />
using System;
using Bookmyhome.Persistence.ContextDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookmyhome.Persistence.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookmyhome.Domain.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresseID"));

                    b.Property<string>("Husnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postnummer")
                        .HasColumnType("int");

                    b.Property<int?>("PostnummerOgByPostnummer")
                        .HasColumnType("int");

                    b.Property<string>("Vejnavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("AdresseID");

                    b.HasIndex("PostnummerOgByPostnummer");

                    b.ToTable("AdresseEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Anmeldelse", b =>
                {
                    b.Property<int>("AnmeldelseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnmeldelseID"));

                    b.Property<DateTime>("AnmeldelsesDato")
                        .HasColumnType("datetime2");

                    b.Property<int>("BoligID")
                        .HasColumnType("int");

                    b.Property<int?>("BrugerID")
                        .HasColumnType("int");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<string>("Kommentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("AnmeldelseID");

                    b.HasIndex("BoligID");

                    b.HasIndex("BrugerID");

                    b.ToTable("AnmeldelseEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Bolig", b =>
                {
                    b.Property<int>("BoligID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BoligID"));

                    b.Property<int>("AdresseID")
                        .HasColumnType("int");

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BrugerID")
                        .HasColumnType("int");

                    b.Property<int>("HostBrugerID")
                        .HasColumnType("int");

                    b.Property<double>("PrisPrNat")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("BoligID");

                    b.HasIndex("AdresseID");

                    b.HasIndex("BrugerID");

                    b.ToTable("BoligEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("BoligID")
                        .HasColumnType("int");

                    b.Property<int?>("BrugerID")
                        .HasColumnType("int");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SlutDato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDato")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TotalPris")
                        .HasColumnType("float");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("BookingID");

                    b.HasIndex("BoligID");

                    b.HasIndex("BrugerID");

                    b.ToTable("BookingEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Bruger", b =>
                {
                    b.Property<int>("BrugerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrugerID"));

                    b.Property<string>("Efternavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TelefonNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Udlejer")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("BrugerID");

                    b.ToTable("BrugerEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.PostnummerOgBy", b =>
                {
                    b.Property<int>("Postnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Postnummer"));

                    b.Property<string>("Bynavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Postnummer");

                    b.ToTable("PostnummerOgByEF");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Adresse", b =>
                {
                    b.HasOne("Bookmyhome.Domain.Models.PostnummerOgBy", "PostnummerOgBy")
                        .WithMany()
                        .HasForeignKey("PostnummerOgByPostnummer");

                    b.Navigation("PostnummerOgBy");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Anmeldelse", b =>
                {
                    b.HasOne("Bookmyhome.Domain.Models.Bolig", "bolig")
                        .WithMany("AnmeldelseList")
                        .HasForeignKey("BoligID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookmyhome.Domain.Models.Bruger", "bruger")
                        .WithMany()
                        .HasForeignKey("BrugerID");

                    b.Navigation("bolig");

                    b.Navigation("bruger");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Bolig", b =>
                {
                    b.HasOne("Bookmyhome.Domain.Models.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookmyhome.Domain.Models.Bruger", "bruger")
                        .WithMany("BoligList")
                        .HasForeignKey("BrugerID");

                    b.Navigation("Adresse");

                    b.Navigation("bruger");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Booking", b =>
                {
                    b.HasOne("Bookmyhome.Domain.Models.Bolig", "bolig")
                        .WithMany("BookingList")
                        .HasForeignKey("BoligID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookmyhome.Domain.Models.Bruger", "bruger")
                        .WithMany("BookingList")
                        .HasForeignKey("BrugerID");

                    b.Navigation("bolig");

                    b.Navigation("bruger");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Bolig", b =>
                {
                    b.Navigation("AnmeldelseList");

                    b.Navigation("BookingList");
                });

            modelBuilder.Entity("Bookmyhome.Domain.Models.Bruger", b =>
                {
                    b.Navigation("BoligList");

                    b.Navigation("BookingList");
                });
#pragma warning restore 612, 618
        }
    }
}
