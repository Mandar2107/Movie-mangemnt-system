﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieMangment.Models;

#nullable disable

namespace MovieMangment.Migrations
{
    [DbContext(typeof(dacdbcontext))]
    partial class dacdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieMangment.Models.Movie", b =>
                {
                    b.Property<int>("Movie_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Int")
                        .HasColumnName("Movie_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Movie_Id"), 1L, 1);

                    b.Property<string>("Actor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Actor");

                    b.Property<string>("Actress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Actress");

                    b.Property<string>("M_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("M_Name");

                    b.Property<int>("Rating")
                        .HasColumnType("Int")
                        .HasColumnName("Rating");

                    b.HasKey("Movie_Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieMangment.Models.user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Birtdate")
                        .HasColumnType("int")
                        .HasColumnName("Birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
