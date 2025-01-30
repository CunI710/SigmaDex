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

            modelBuilder.Entity("DataAccess.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PermissionEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CreateSigma"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ReadSigma"
                        },
                        new
                        {
                            Id = 3,
                            Name = "UpdateSigma"
                        },
                        new
                        {
                            Id = 4,
                            Name = "DeleteSigma"
                        },
                        new
                        {
                            Id = 5,
                            Name = "CreateUser"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ReadUser"
                        },
                        new
                        {
                            Id = 7,
                            Name = "UpdateUser"
                        },
                        new
                        {
                            Id = 8,
                            Name = "DeleteUser"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Moder"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Professor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.RolePermissionEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissionEntity");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 7
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 6
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 4,
                            PermissionId = 2
                        });
                });

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

                    b.HasIndex("Id");

                    b.HasIndex("NextStepId")
                        .IsUnique();

                    b.HasIndex("PrevStepId");

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

                    b.HasIndex("Id");

                    b.ToTable("SigmaTypes");
                });

            modelBuilder.Entity("DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.UserRoleEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("UserRoleEntity");
                });

            modelBuilder.Entity("RoleEntityUserEntity", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleEntityUserEntity");
                });

            modelBuilder.Entity("SigmaEntitySigmaEntity", b =>
                {
                    b.Property<int>("AllEvolutionId")
                        .HasColumnType("integer");

                    b.Property<int>("SigmaEntityId")
                        .HasColumnType("integer");

                    b.HasKey("AllEvolutionId", "SigmaEntityId");

                    b.HasIndex("SigmaEntityId");

                    b.ToTable("SigmaEntitySigmaEntity");
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

            modelBuilder.Entity("DataAccess.Entities.RolePermissionEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.PermissionEntity", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.SigmaEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.SigmaEntity", "NextStep")
                        .WithOne()
                        .HasForeignKey("DataAccess.Entities.SigmaEntity", "NextStepId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataAccess.Entities.SigmaEntity", "PrevStep")
                        .WithMany()
                        .HasForeignKey("PrevStepId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("NextStep");

                    b.Navigation("PrevStep");
                });

            modelBuilder.Entity("RoleEntityUserEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SigmaEntitySigmaEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.SigmaEntity", null)
                        .WithMany()
                        .HasForeignKey("AllEvolutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.SigmaEntity", null)
                        .WithMany()
                        .HasForeignKey("SigmaEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
