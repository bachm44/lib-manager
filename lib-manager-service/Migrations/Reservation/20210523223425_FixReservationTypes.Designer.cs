﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using lib_manager.Database;

namespace lib_manager.Migrations.Reservation
{
    [DbContext(typeof(ReservationContext))]
    [Migration("20210523223425_FixReservationTypes")]
    partial class FixReservationTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("lib_manager.Models.ReservationModel", b =>
                {
                    b.Property<int>("reservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("bookId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("reservationEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("reservationStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.HasKey("reservationID");

                    b.ToTable("ReservationList");
                });
#pragma warning restore 612, 618
        }
    }
}
