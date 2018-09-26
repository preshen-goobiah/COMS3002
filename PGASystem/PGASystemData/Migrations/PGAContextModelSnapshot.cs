﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PGASystemData;

namespace PGASystemData.Migrations
{
    [DbContext(typeof(PGAContext))]
    partial class PGAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PGASystemData.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("ProgrammeId");

                    b.Property<int?>("SupervisorId");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammeId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("PGASystemData.Models.ApplicationFiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApplicationId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("ApplicationFile");
                });

            modelBuilder.Entity("PGASystemData.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName");

                    b.HasKey("Id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("PGASystemData.Models.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ProgrammeName");

                    b.HasKey("Id");

                    b.ToTable("Programme");
                });

            modelBuilder.Entity("PGASystemData.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int?>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PGASystemData.Models.Application", b =>
                {
                    b.HasOne("PGASystemData.Models.Programme", "Programme")
                        .WithMany()
                        .HasForeignKey("ProgrammeId");

                    b.HasOne("PGASystemData.Models.User", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");
                });

            modelBuilder.Entity("PGASystemData.Models.ApplicationFiles", b =>
                {
                    b.HasOne("PGASystemData.Models.Application")
                        .WithMany("ApplicationFiles")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("PGASystemData.Models.User", b =>
                {
                    b.HasOne("PGASystemData.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");
                });
#pragma warning restore 612, 618
        }
    }
}
