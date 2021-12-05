﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppApi.Models;

namespace WebAppApi.Migrations
{
    [DbContext(typeof(CustomerDBContext))]
    [Migration("20211204191616_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppApi.Models.DCandidate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("mobile")
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("DCandidates");
                });
#pragma warning restore 612, 618
        }
    }
}
