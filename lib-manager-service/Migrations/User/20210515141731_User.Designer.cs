﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using lib_manager.Database;

namespace lib_manager.Migrations.User
{
    [DbContext(typeof(UserContext))]
    [Migration("20210515141731_User")]
    partial class User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("lib_manager.Models.BookModel", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("authorName")
                        .HasColumnType("text");

                    b.Property<int>("bookCount")
                        .HasColumnType("integer");

                    b.Property<string>("bookTitle")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("language")
                        .HasColumnType("text");

                    b.Property<int>("pageCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("publicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("bookId");

                    b.ToTable("BookModel");

                    b.HasData(
                        new
                        {
                            bookId = 1,
                            authorName = "Friedrich Nietzsche",
                            bookCount = 0,
                            bookTitle = "Beyond Good And Evil",
                            description = "In Beyond Good and Evil, Nietzsche accuses past philosophers of lacking critical sense and blindly accepting dogmatic premises in their consideration of morality. Specifically, he accuses them of founding grand metaphysical systems upon the faith that the good man is the opposite of the evil man, rather than just a different expression of the same basic impulses that find more direct expression in the evil man. The work moves into the realm beyond good and evil in the sense of leaving behind the traditional morality which Nietzsche subjects to a destructive critique in favour of what he regards as an affirmative approach that fearlessly confronts the perspectival nature of knowledge and the perilous condition of the modern individual.",
                            language = "German",
                            pageCount = 939,
                            publicationDate = new DateTime(1886, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            bookId = 2,
                            authorName = "Franz Kafka",
                            bookCount = 0,
                            bookTitle = "The Metamorphosis",
                            description = "The Metamorphosis tells the story of salesman Gregor Samsa, who wakes one morning to find himself inexplicably transformed into a huge insect and subsequently struggles to adjust to this new condition.",
                            language = "German",
                            pageCount = 58,
                            publicationDate = new DateTime(1915, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("lib_manager.Models.UserModel", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.HasKey("username");

                    b.ToTable("UserList");

                    b.HasData(
                        new
                        {
                            username = "test1@gmail.com",
                            password = "123",
                            role = 0
                        },
                        new
                        {
                            username = "thepope@gmail.com",
                            password = "blessyou",
                            role = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
