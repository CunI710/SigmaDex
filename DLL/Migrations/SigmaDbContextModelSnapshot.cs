﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(SigmaDbContext))]
    partial class SigmaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.SigmaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AverageHeight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AverageWeight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EvolutionLevel")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("NextStepId")
                        .HasColumnType("integer");

                    b.Property<int?>("PrevStepId")
                        .HasColumnType("integer");

                    b.Property<int>("Testosterone")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NextStepId")
                        .IsUnique();

                    b.HasIndex("PrevStepId")
                        .IsUnique();

                    b.ToTable("Sigmas");
                });

            modelBuilder.Entity("DataAccess.Entities.SigmaTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Desription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SigmaTypes");
                });

            modelBuilder.Entity("SigmaEntitySigmaTypeEntity", b =>
                {
                    b.Property<int>("SigmaTypesId")
                        .HasColumnType("integer");

                    b.Property<int>("TypesId")
                        .HasColumnType("integer");

                    b.HasKey("SigmaTypesId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("SigmaEntitySigmaTypeEntity");
                });

            modelBuilder.Entity("SigmaEntitySigmaTypeEntity1", b =>
                {
                    b.Property<int>("SigmaWeaknessesId")
                        .HasColumnType("integer");

                    b.Property<int>("WeaknessesId")
                        .HasColumnType("integer");

                    b.HasKey("SigmaWeaknessesId", "WeaknessesId");

                    b.HasIndex("WeaknessesId");

                    b.ToTable("SigmaEntitySigmaTypeEntity1");
                });

            modelBuilder.Entity("DataAccess.Entities.SigmaEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.SigmaEntity", "NextStep")
                        .WithOne()
                        .HasForeignKey("DataAccess.Entities.SigmaEntity", "NextStepId");

                    b.HasOne("DataAccess.Entities.SigmaEntity", "PrevStep")
                        .WithOne()
                        .HasForeignKey("DataAccess.Entities.SigmaEntity", "PrevStepId");

                    b.Navigation("NextStep");

                    b.Navigation("PrevStep");
                });

            modelBuilder.Entity("SigmaEntitySigmaTypeEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.SigmaEntity", null)
                        .WithMany()
                        .HasForeignKey("SigmaTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.SigmaTypeEntity", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SigmaEntitySigmaTypeEntity1", b =>
                {
                    b.HasOne("DataAccess.Entities.SigmaEntity", null)
                        .WithMany()
                        .HasForeignKey("SigmaWeaknessesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.SigmaTypeEntity", null)
                        .WithMany()
                        .HasForeignKey("WeaknessesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
