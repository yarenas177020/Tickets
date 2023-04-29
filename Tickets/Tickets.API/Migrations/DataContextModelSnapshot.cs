﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.API.Data;

#nullable disable

namespace Tickets.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ticktets.Shared.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("TicketID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tribune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TicketID")
                        .IsUnique()
                        .HasFilter("[TicketID] IS NOT NULL");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
