﻿// <auto-generated />
using AbsenderAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AbsenderAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AbsenderAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("GroupeIdGroupe");

                    b.Property<int>("IdContact");

                    b.Property<string>("IdNationalUser");

                    b.Property<string>("IdUniversitaireUser");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PhotoProfilUser");

                    b.Property<string>("PrivilegeUser");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GroupeIdGroupe");

                    b.HasIndex("IdContact");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Absence", b =>
                {
                    b.Property<int>("IdAbsence")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMatiere");

                    b.Property<string>("IdUtilisateur");

                    b.Property<string>("MessageAbsence");

                    b.Property<int>("TauxAbsence");

                    b.HasKey("IdAbsence");

                    b.HasIndex("IdMatiere");

                    b.HasIndex("IdUtilisateur");

                    b.ToTable("Absence");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Contact", b =>
                {
                    b.Property<int>("IdContact")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassificationContact");

                    b.Property<string>("TypeContact");

                    b.Property<string>("ValeurContact");

                    b.HasKey("IdContact");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Filiere", b =>
                {
                    b.Property<int>("IdFiliere")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesignationFiliere");

                    b.Property<string>("DesignationOption");

                    b.Property<string>("TagFiliere");

                    b.Property<string>("TagOption");

                    b.HasKey("IdFiliere");

                    b.ToTable("Filiere");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Groupe", b =>
                {
                    b.Property<int>("IdGroupe")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesignationGroupe");

                    b.Property<bool>("EstCoursSoire");

                    b.Property<int>("IdFiliere");

                    b.Property<string>("NombreEtudiant");

                    b.HasKey("IdGroupe");

                    b.HasIndex("IdFiliere");

                    b.ToTable("Groupe");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Matiere", b =>
                {
                    b.Property<int>("IdMatiere")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesignationMatiere");

                    b.Property<int>("IdModule");

                    b.Property<int>("TauxTolereModule");

                    b.HasKey("IdMatiere");

                    b.HasIndex("IdModule");

                    b.ToTable("Matiere");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Module", b =>
                {
                    b.Property<int>("IdModule")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesignationModule");

                    b.Property<int?>("FiliereIdFiliere");

                    b.HasKey("IdModule");

                    b.HasIndex("FiliereIdFiliere");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Salle", b =>
                {
                    b.Property<int>("IdSalle")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesignationSalle");

                    b.HasKey("IdSalle");

                    b.ToTable("Salle");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Seance", b =>
                {
                    b.Property<int>("IdSseance")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HeureSeance");

                    b.Property<int>("IdFiliere");

                    b.Property<int?>("IdGroupe");

                    b.Property<string>("IdProfesseur");

                    b.Property<int>("IdSalle");

                    b.HasKey("IdSseance");

                    b.HasIndex("IdGroupe");

                    b.HasIndex("IdProfesseur");

                    b.HasIndex("IdSalle");

                    b.ToTable("Seance");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AbsenderAPI.Models.ApplicationUser", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Groupe")
                        .WithMany("EtudiantsFiliere")
                        .HasForeignKey("GroupeIdGroupe");

                    b.HasOne("AbsenderAPI.Models.UniversityModels.Contact", "ContactUtilisateur")
                        .WithMany()
                        .HasForeignKey("IdContact")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Absence", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Matiere", "Matiere")
                        .WithMany()
                        .HasForeignKey("IdMatiere")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AbsenderAPI.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("IdUtilisateur");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Groupe", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Filiere", "FiliereGroupe")
                        .WithMany()
                        .HasForeignKey("IdFiliere")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Matiere", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Module", "ModuleMatiere")
                        .WithMany()
                        .HasForeignKey("IdModule")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Module", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Filiere")
                        .WithMany("ModuleAssocies")
                        .HasForeignKey("FiliereIdFiliere");
                });

            modelBuilder.Entity("AbsenderAPI.Models.UniversityModels.Seance", b =>
                {
                    b.HasOne("AbsenderAPI.Models.UniversityModels.Groupe", "GroupeSeance")
                        .WithMany()
                        .HasForeignKey("IdGroupe");

                    b.HasOne("AbsenderAPI.Models.ApplicationUser", "ProfesseurSeance")
                        .WithMany()
                        .HasForeignKey("IdProfesseur");

                    b.HasOne("AbsenderAPI.Models.UniversityModels.Salle", "SalleSeance")
                        .WithMany()
                        .HasForeignKey("IdSalle")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AbsenderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AbsenderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AbsenderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AbsenderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
