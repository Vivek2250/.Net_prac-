﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using day21_task1.Data;

#nullable disable

namespace day21_task1.Migrations
{
    [DbContext(typeof(day21_task1Context))]
    partial class day21_task1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("day21_task1.Models.Calculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Num1")
                        .HasColumnType("int");

                    b.Property<int>("Num2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Calculator");
                });
#pragma warning restore 612, 618
        }
    }
}
