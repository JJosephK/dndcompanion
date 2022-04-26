﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dnd.Models;

namespace dnd.Migrations
{
    [DbContext(typeof(CharacterContext))]
    partial class CharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("dnd.Models.Abilities.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Strength"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dexterity"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Constitution"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Intelligence"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Wisdom"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Charisma"
                        });
                });

            modelBuilder.Entity("dnd.Models.Alignments.Alignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alignments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lawful Good"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Neutral Good"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chaotic Good"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lawful Neutral"
                        },
                        new
                        {
                            Id = 5,
                            Name = "True Neutral"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chaotic Neutral"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Lawful Evil"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Neutral Evil"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Chaotic Evil"
                        });
                });

            modelBuilder.Entity("dnd.Models.Auth.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("dnd.Models.Characters.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArmorClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bonds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterLevel")
                        .HasColumnType("int");

                    b.Property<string>("CharacterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterRace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharismaVal")
                        .HasColumnType("int");

                    b.Property<int>("ConstitutionVal")
                        .HasColumnType("int");

                    b.Property<int>("CurrentHealth")
                        .HasColumnType("int");

                    b.Property<int>("DeathSaveFailure")
                        .HasColumnType("int");

                    b.Property<int>("DeathSaveSuccess")
                        .HasColumnType("int");

                    b.Property<int>("DexterityVal")
                        .HasColumnType("int");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<string>("Flaws")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HitDice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ideals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InitiativeVal")
                        .HasColumnType("int");

                    b.Property<int>("InspirationVal")
                        .HasColumnType("int");

                    b.Property<int>("IntelligenceVal")
                        .HasColumnType("int");

                    b.Property<string>("PersonalityTraits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProficiencyBonusVal")
                        .HasColumnType("int");

                    b.Property<string>("SavingThrows")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpeedVal")
                        .HasColumnType("int");

                    b.Property<int>("StrengthVal")
                        .HasColumnType("int");

                    b.Property<int>("TemporaryHealth")
                        .HasColumnType("int");

                    b.Property<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WisdomVal")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("dnd.Models.Classes.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Barbarian"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bard"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cleric"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Druid"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fighter"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Monk"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Paladin"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ranger"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Rogue"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sorcerer"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Warlock"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Wizard"
                        });
                });

            modelBuilder.Entity("dnd.Models.Races.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dragonborn"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dwarf"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Elf"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gnome"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Half-Elf"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Halfling"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Half-Orc"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Human"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tiefling"
                        });
                });

            modelBuilder.Entity("dnd.Models.Skills.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AbilityModifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AbilityModifier = "Dexterity",
                            Name = "Acrobatics"
                        },
                        new
                        {
                            Id = 2,
                            AbilityModifier = "Wisdom",
                            Name = "Animal Handling"
                        },
                        new
                        {
                            Id = 3,
                            AbilityModifier = "Intelligence",
                            Name = "Arcana"
                        },
                        new
                        {
                            Id = 4,
                            AbilityModifier = "Strength",
                            Name = "Athletics"
                        },
                        new
                        {
                            Id = 5,
                            AbilityModifier = "Charisma",
                            Name = "Deception"
                        },
                        new
                        {
                            Id = 6,
                            AbilityModifier = "Intelligence",
                            Name = "History"
                        },
                        new
                        {
                            Id = 7,
                            AbilityModifier = "Wisdom",
                            Name = "Insight"
                        },
                        new
                        {
                            Id = 8,
                            AbilityModifier = "Charisma",
                            Name = "Intimidation"
                        },
                        new
                        {
                            Id = 9,
                            AbilityModifier = "Intelligence",
                            Name = "Investigation"
                        },
                        new
                        {
                            Id = 10,
                            AbilityModifier = "Wisdom",
                            Name = "Medicine"
                        },
                        new
                        {
                            Id = 11,
                            AbilityModifier = "Intelligence",
                            Name = "Nature"
                        },
                        new
                        {
                            Id = 12,
                            AbilityModifier = "Wisdom",
                            Name = "Perception"
                        },
                        new
                        {
                            Id = 13,
                            AbilityModifier = "Charisma",
                            Name = "Performance"
                        },
                        new
                        {
                            Id = 14,
                            AbilityModifier = "Charisma",
                            Name = "Persuasion"
                        },
                        new
                        {
                            Id = 15,
                            AbilityModifier = "Intelligence",
                            Name = "Religion"
                        },
                        new
                        {
                            Id = 16,
                            AbilityModifier = "Dexterity",
                            Name = "Sleight of Hand"
                        },
                        new
                        {
                            Id = 17,
                            AbilityModifier = "Dexterity",
                            Name = "Stealth"
                        },
                        new
                        {
                            Id = 18,
                            AbilityModifier = "Wisdom",
                            Name = "Survival"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("dnd.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("dnd.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dnd.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("dnd.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
