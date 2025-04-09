﻿// <auto-generated />
using BaseRepository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseRepository.Migrations
{
    [DbContext(typeof(LearnDbContext))]
    [Migration("20250409053830_Creae Table ")]
    partial class CreaeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaseRepository.Models.MstRegistration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistrationId"));

                    b.Property<string>("Address")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Message")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId");

                    b.ToTable("MstRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
