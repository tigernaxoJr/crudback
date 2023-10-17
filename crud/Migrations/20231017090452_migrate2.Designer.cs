﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using crud.PostgreSQL;

#nullable disable

namespace crud.Migrations
{
    [DbContext(typeof(HISContext))]
    [Migration("20231017090452_migrate2")]
    partial class migrate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("crud.PostgreSQL.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("gender")
                        .HasColumnType("integer");

                    b.Property<string>("idno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            Name = "John Doe",
                            gender = 1,
                            idno = "1234567890"
                        },
                        new
                        {
                            PatientId = 2,
                            Name = "Jane Doe",
                            gender = 0,
                            idno = "0987654321"
                        },
                        new
                        {
                            PatientId = 3,
                            Name = "Alice Smith",
                            gender = 1,
                            idno = "1111111111"
                        },
                        new
                        {
                            PatientId = 4,
                            Name = "Bob Johnson",
                            gender = 0,
                            idno = "2222222222"
                        },
                        new
                        {
                            PatientId = 5,
                            Name = "Carol Brown",
                            gender = 1,
                            idno = "3333333333"
                        },
                        new
                        {
                            PatientId = 6,
                            Name = "David Wilson",
                            gender = 0,
                            idno = "4444444444"
                        },
                        new
                        {
                            PatientId = 7,
                            Name = "Eve Adams",
                            gender = 1,
                            idno = "5555555555"
                        },
                        new
                        {
                            PatientId = 8,
                            Name = "Frank Miller",
                            gender = 0,
                            idno = "6666666666"
                        },
                        new
                        {
                            PatientId = 9,
                            Name = "Grace Davis",
                            gender = 1,
                            idno = "7777777777"
                        },
                        new
                        {
                            PatientId = 10,
                            Name = "Harry White",
                            gender = 0,
                            idno = "8888888888"
                        },
                        new
                        {
                            PatientId = 11,
                            Name = "Isabel Thomas",
                            gender = 1,
                            idno = "9999999999"
                        },
                        new
                        {
                            PatientId = 12,
                            Name = "Jack Lee",
                            gender = 0,
                            idno = "7777777000"
                        },
                        new
                        {
                            PatientId = 13,
                            Name = "Karen Hall",
                            gender = 1,
                            idno = "5555555000"
                        },
                        new
                        {
                            PatientId = 14,
                            Name = "Larry King",
                            gender = 0,
                            idno = "3333333000"
                        },
                        new
                        {
                            PatientId = 15,
                            Name = "Megan Martin",
                            gender = 1,
                            idno = "1111111000"
                        },
                        new
                        {
                            PatientId = 16,
                            Name = "Nora Clark",
                            gender = 0,
                            idno = "2222222000"
                        },
                        new
                        {
                            PatientId = 17,
                            Name = "Oscar Young",
                            gender = 1,
                            idno = "4444444000"
                        },
                        new
                        {
                            PatientId = 18,
                            Name = "Pamela White",
                            gender = 0,
                            idno = "6666666000"
                        },
                        new
                        {
                            PatientId = 19,
                            Name = "Quincy Adams",
                            gender = 1,
                            idno = "8888888000"
                        },
                        new
                        {
                            PatientId = 20,
                            Name = "Robert Davis",
                            gender = 0,
                            idno = "1234567000"
                        },
                        new
                        {
                            PatientId = 21,
                            Name = "Sara Wilson",
                            gender = 1,
                            idno = "0987655000"
                        },
                        new
                        {
                            PatientId = 22,
                            Name = "Tom Johnson",
                            gender = 0,
                            idno = "3333333000"
                        },
                        new
                        {
                            PatientId = 23,
                            Name = "Ursula Smith",
                            gender = 1,
                            idno = "6666666000"
                        },
                        new
                        {
                            PatientId = 24,
                            Name = "Victor Lee",
                            gender = 0,
                            idno = "1111111000"
                        },
                        new
                        {
                            PatientId = 25,
                            Name = "Wendy Hall",
                            gender = 1,
                            idno = "5555555000"
                        },
                        new
                        {
                            PatientId = 26,
                            Name = "Xander Martin",
                            gender = 0,
                            idno = "8888888000"
                        },
                        new
                        {
                            PatientId = 27,
                            Name = "Yara Thomas",
                            gender = 1,
                            idno = "7777777000"
                        },
                        new
                        {
                            PatientId = 28,
                            Name = "Zane King",
                            gender = 0,
                            idno = "2222222000"
                        },
                        new
                        {
                            PatientId = 29,
                            Name = "Aaron Adams",
                            gender = 1,
                            idno = "4444444000"
                        },
                        new
                        {
                            PatientId = 30,
                            Name = "Bella Martin",
                            gender = 0,
                            idno = "1234567000"
                        },
                        new
                        {
                            PatientId = 31,
                            Name = "Chris White",
                            gender = 1,
                            idno = "0987655000"
                        },
                        new
                        {
                            PatientId = 32,
                            Name = "Daisy Hall",
                            gender = 0,
                            idno = "5555555000"
                        },
                        new
                        {
                            PatientId = 33,
                            Name = "Ethan King",
                            gender = 1,
                            idno = "6666666000"
                        },
                        new
                        {
                            PatientId = 34,
                            Name = "Fiona Davis",
                            gender = 0,
                            idno = "2222222000"
                        },
                        new
                        {
                            PatientId = 35,
                            Name = "George Wilson",
                            gender = 1,
                            idno = "1234567000"
                        },
                        new
                        {
                            PatientId = 36,
                            Name = "Hannah Lee",
                            gender = 0,
                            idno = "7777777000"
                        },
                        new
                        {
                            PatientId = 37,
                            Name = "Isaac Thomas",
                            gender = 1,
                            idno = "0987655000"
                        },
                        new
                        {
                            PatientId = 38,
                            Name = "Julia Smith",
                            gender = 0,
                            idno = "4444444000"
                        },
                        new
                        {
                            PatientId = 39,
                            Name = "Kai Adams",
                            gender = 1,
                            idno = "5555555000"
                        },
                        new
                        {
                            PatientId = 40,
                            Name = "Lily King",
                            gender = 0,
                            idno = "6666666000"
                        },
                        new
                        {
                            PatientId = 41,
                            Name = "Mike Davis",
                            gender = 1,
                            idno = "7777777000"
                        },
                        new
                        {
                            PatientId = 42,
                            Name = "Nina Martin",
                            gender = 0,
                            idno = "2222222000"
                        },
                        new
                        {
                            PatientId = 43,
                            Name = "Oliver Hall",
                            gender = 1,
                            idno = "1234567000"
                        },
                        new
                        {
                            PatientId = 44,
                            Name = "Penny Lee",
                            gender = 0,
                            idno = "0987655000"
                        },
                        new
                        {
                            PatientId = 45,
                            Name = "Quinn Thomas",
                            gender = 1,
                            idno = "4444444000"
                        },
                        new
                        {
                            PatientId = 46,
                            Name = "Rachel Smith",
                            gender = 0,
                            idno = "5555555000"
                        },
                        new
                        {
                            PatientId = 47,
                            Name = "Samuel Adams",
                            gender = 1,
                            idno = "1234567000"
                        },
                        new
                        {
                            PatientId = 48,
                            Name = "Tina Davis",
                            gender = 0,
                            idno = "0987655000"
                        },
                        new
                        {
                            PatientId = 49,
                            Name = "Ulysses Martin",
                            gender = 1,
                            idno = "6666666000"
                        },
                        new
                        {
                            PatientId = 50,
                            Name = "Victoria Wilson",
                            gender = 0,
                            idno = "7777777000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
