﻿// <auto-generated />
using System;
using ApplyApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplyApp.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    partial class CrmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplyApp.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("ApplyApp.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HRManagerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Thesis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("HRManagerId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("ApplyApp.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HRManagerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("HRManagerId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("ApplyApp.Models.HRManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HRManagers");
                });

            modelBuilder.Entity("ApplyApp.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HRManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HRManagerId");

                    b.ToTable("JobOffers");
                });

            modelBuilder.Entity("ApplyApp.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("JobOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("ApplyApp.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("HRManagerId")
                        .HasColumnType("int");

                    b.Property<int?>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<int>("Knowlegde")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("HRManagerId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ApplyApp.Models.Education", b =>
                {
                    b.HasOne("ApplyApp.Models.Candidate", "Candidate")
                        .WithMany("Educations")
                        .HasForeignKey("CandidateId");

                    b.HasOne("ApplyApp.Models.HRManager", "HRManager")
                        .WithMany("Educations")
                        .HasForeignKey("HRManagerId");
                });

            modelBuilder.Entity("ApplyApp.Models.Experience", b =>
                {
                    b.HasOne("ApplyApp.Models.Candidate", "Candidate")
                        .WithMany("Experiences")
                        .HasForeignKey("CandidateId");

                    b.HasOne("ApplyApp.Models.HRManager", "HRManager")
                        .WithMany("Experiences")
                        .HasForeignKey("HRManagerId");
                });

            modelBuilder.Entity("ApplyApp.Models.JobOffer", b =>
                {
                    b.HasOne("ApplyApp.Models.HRManager", "HRManager")
                        .WithMany("JobOffers")
                        .HasForeignKey("HRManagerId");
                });

            modelBuilder.Entity("ApplyApp.Models.Request", b =>
                {
                    b.HasOne("ApplyApp.Models.Candidate", "Candidate")
                        .WithMany("Requests")
                        .HasForeignKey("CandidateId");

                    b.HasOne("ApplyApp.Models.JobOffer", "JobOffer")
                        .WithMany("Requests")
                        .HasForeignKey("JobOfferId");
                });

            modelBuilder.Entity("ApplyApp.Models.Skill", b =>
                {
                    b.HasOne("ApplyApp.Models.Candidate", "Candidate")
                        .WithMany("Skills")
                        .HasForeignKey("CandidateId");

                    b.HasOne("ApplyApp.Models.HRManager", "HRManager")
                        .WithMany()
                        .HasForeignKey("HRManagerId");

                    b.HasOne("ApplyApp.Models.JobOffer", null)
                        .WithMany("Skills")
                        .HasForeignKey("JobOfferId");
                });
#pragma warning restore 612, 618
        }
    }
}
