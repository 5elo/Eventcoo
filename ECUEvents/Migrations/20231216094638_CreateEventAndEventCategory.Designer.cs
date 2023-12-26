﻿// <auto-generated />
using System;
using ECUEvents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECUEvents.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231216094638_CreateEventAndEventCategory")]
    partial class CreateEventAndEventCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECUEvents.Models.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Brief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnOrder(1)
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Focus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(2);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.ToTable("ECUEvent_Event", (string)null);
                });

            modelBuilder.Entity("ECUEvents.Models.Lookups.LkpEventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnOrder(1)
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("Focus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ECUEvent_LKP_EventCategory", (string)null);
                });

            modelBuilder.Entity("ECUEvents.Models.Entities.Event", b =>
                {
                    b.HasOne("ECUEvents.Models.Lookups.LkpEventCategory", "EventCategory")
                        .WithMany("Events")
                        .HasForeignKey("EventCategoryId");

                    b.Navigation("EventCategory");
                });

            modelBuilder.Entity("ECUEvents.Models.Lookups.LkpEventCategory", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}