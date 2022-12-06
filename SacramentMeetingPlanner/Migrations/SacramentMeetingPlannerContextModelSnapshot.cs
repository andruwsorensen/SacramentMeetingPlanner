﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Hymn", b =>
                {
                    b.Property<int>("HymnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HymnId"), 1L, 1);

                    b.Property<int>("HymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("HymnTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HymnId");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.Property<int>("SacramentMeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SacramentMeetingId"), 1L, 1);

                    b.Property<string>("Benediction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClosingHymnId")
                        .HasColumnType("int");

                    b.Property<string>("Conducting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IntermediateHymnId")
                        .HasColumnType("int");

                    b.Property<string>("Invocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningHymnId")
                        .HasColumnType("int");

                    b.Property<string>("Presiding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentalHymnId")
                        .HasColumnType("int");

                    b.HasKey("SacramentMeetingId");

                    b.HasIndex("ClosingHymnId");

                    b.HasIndex("IntermediateHymnId");

                    b.HasIndex("OpeningHymnId");

                    b.HasIndex("SacramentalHymnId");

                    b.ToTable("SacramentMeeting");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpeakerId"), 1L, 1);

                    b.Property<int>("SacramentMeetingId")
                        .HasColumnType("int");

                    b.Property<string>("SpeakerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Hymn", "ClosingHymn")
                        .WithMany()
                        .HasForeignKey("ClosingHymnId");

                    b.HasOne("SacramentMeetingPlanner.Models.Hymn", "IntermediateHymn")
                        .WithMany()
                        .HasForeignKey("IntermediateHymnId");

                    b.HasOne("SacramentMeetingPlanner.Models.Hymn", "OpeningHymn")
                        .WithMany()
                        .HasForeignKey("OpeningHymnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SacramentMeetingPlanner.Models.Hymn", "SacramentalHymn")
                        .WithMany()
                        .HasForeignKey("SacramentalHymnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClosingHymn");

                    b.Navigation("IntermediateHymn");

                    b.Navigation("OpeningHymn");

                    b.Navigation("SacramentalHymn");
                });
#pragma warning restore 612, 618
        }
    }
}
