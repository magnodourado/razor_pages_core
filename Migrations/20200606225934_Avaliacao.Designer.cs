﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20200606225934_Avaliacao")]
    partial class Avaliacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesMovie.Models.Filme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avaliacao");

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Genero");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.ToTable("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
