﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SomeeDeps.Infrastructure.Data;

#nullable disable

namespace SomeeDeps.Infrastructure.Migrations
{
    [DbContext(typeof(SomeeDepsContext))]
    [Migration("20221229014319_InitialDbCreation")]
    partial class InitialDbCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SomeeDeps.Infrastructure.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDone = false,
                            Title = "Continue the capstone project on year 2023"
                        },
                        new
                        {
                            Id = 2,
                            IsDone = true,
                            Title = "Celebrate Christmas with family."
                        },
                        new
                        {
                            Id = 3,
                            IsDone = false,
                            Title = "Create website tomorrow!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}