﻿// <auto-generated />
using System;
using Hattrick.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hattrick.Model.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20181227125446_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hattrick.Model.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Hattrick.Model.Position", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<long>("PlayerId");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Hattrick.Model.Position", b =>
                {
                    b.HasOne("Hattrick.Model.Player", "Players")
                        .WithMany("Positions")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
