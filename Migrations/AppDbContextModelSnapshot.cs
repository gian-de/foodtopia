﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using foodtopia.Database;

#nullable disable

namespace foodtopia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("foodtopia.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7cee8787-e599-4509-9aeb-e8bb72190338"),
                            ImagePath = "images/flags/afghanistan.svg",
                            Name = "Afghanistan"
                        },
                        new
                        {
                            Id = new Guid("b6d47cf7-19a2-4256-ad86-84fff7418908"),
                            ImagePath = "images/flags/albania.svg",
                            Name = "Albania"
                        },
                        new
                        {
                            Id = new Guid("40585d1b-fae1-49b3-a674-873c63c73c80"),
                            ImagePath = "images/flags/",
                            Name = "Algeria"
                        },
                        new
                        {
                            Id = new Guid("7ea18ce0-755c-4357-a927-616d0786a105"),
                            ImagePath = "images/flags/",
                            Name = "Andorra"
                        },
                        new
                        {
                            Id = new Guid("177a18a0-8bb5-4c73-a2b0-c5c4e9712587"),
                            ImagePath = "images/flags/",
                            Name = "Angola"
                        },
                        new
                        {
                            Id = new Guid("6bcd4a51-d473-4c84-89fa-989de172012f"),
                            ImagePath = "images/flags/",
                            Name = "Antigua & Barbuda"
                        },
                        new
                        {
                            Id = new Guid("cd73092b-952c-42fe-a344-91f44375d8f8"),
                            ImagePath = "images/flags/",
                            Name = "Argentina"
                        },
                        new
                        {
                            Id = new Guid("5f198f58-93d3-4914-83a1-42fcb7ef227f"),
                            ImagePath = "images/flags/",
                            Name = "Armenia"
                        },
                        new
                        {
                            Id = new Guid("6401c6b4-4928-4dc0-a50e-f098352947a3"),
                            ImagePath = "images/flags/",
                            Name = "Australia"
                        },
                        new
                        {
                            Id = new Guid("9d5f8eb4-d441-4a40-9520-8dbeec404e57"),
                            ImagePath = "images/flags/",
                            Name = "Austria"
                        },
                        new
                        {
                            Id = new Guid("51a9dd6b-40f7-461f-a33d-8a9ec8a7b0b0"),
                            ImagePath = "images/flags/",
                            Name = "Azerbaijan"
                        },
                        new
                        {
                            Id = new Guid("21b20b45-9abb-4a57-970e-05e6e250aa53"),
                            ImagePath = "images/flags/",
                            Name = "Bahamas"
                        },
                        new
                        {
                            Id = new Guid("00abf283-499b-42ae-8411-e63022d36dca"),
                            ImagePath = "images/flags/",
                            Name = "Bangladesh"
                        },
                        new
                        {
                            Id = new Guid("639404c3-fc78-454d-8af9-b3fd170cee73"),
                            ImagePath = "images/flags/",
                            Name = "Barbados"
                        },
                        new
                        {
                            Id = new Guid("441ab6d0-1b95-454d-b5d0-752ceea35c77"),
                            ImagePath = "images/flags/",
                            Name = "Belgium"
                        },
                        new
                        {
                            Id = new Guid("6ea31b49-c210-40f0-a496-baebb278d00d"),
                            ImagePath = "images/flags/",
                            Name = "Belize"
                        },
                        new
                        {
                            Id = new Guid("a4b34ce2-dc76-4925-a5e2-202d7261c1d7"),
                            ImagePath = "images/flags/",
                            Name = "Bolivia"
                        },
                        new
                        {
                            Id = new Guid("aa6e4e84-ccff-4add-882a-795cc5c6ee87"),
                            ImagePath = "images/flags/",
                            Name = "Brazil"
                        },
                        new
                        {
                            Id = new Guid("ad1a3e78-b9f2-402a-b17f-de47ed8e6619"),
                            ImagePath = "images/flags/",
                            Name = "Cameroon"
                        },
                        new
                        {
                            Id = new Guid("8cd91d08-f462-4f21-9aef-bfb82d2eed7b"),
                            ImagePath = "images/flags/",
                            Name = "Canada"
                        },
                        new
                        {
                            Id = new Guid("e1dbb76f-a844-4976-8fcb-cbd3d0c1bea8"),
                            ImagePath = "images/flags/",
                            Name = "Chile"
                        },
                        new
                        {
                            Id = new Guid("b57940fb-e430-4d3a-add6-393f72134551"),
                            ImagePath = "images/flags/",
                            Name = "China"
                        },
                        new
                        {
                            Id = new Guid("bfb41bad-30e2-43d5-a92b-b40cd5107930"),
                            ImagePath = "images/flags/",
                            Name = "Colombia"
                        },
                        new
                        {
                            Id = new Guid("210816a9-ccc0-475c-b7dc-3509526f330d"),
                            ImagePath = "images/flags/",
                            Name = "Costa Rica"
                        },
                        new
                        {
                            Id = new Guid("e69357c1-dcd1-4eb1-8533-ce965363975f"),
                            ImagePath = "images/flags/",
                            Name = "Croatia"
                        },
                        new
                        {
                            Id = new Guid("bb27262b-0abe-4958-81c6-fd7e901d00e4"),
                            ImagePath = "images/flags/",
                            Name = "Cuba"
                        },
                        new
                        {
                            Id = new Guid("56d8824b-d45d-4389-9d98-97dc2453677f"),
                            ImagePath = "images/flags/",
                            Name = "Denmark"
                        },
                        new
                        {
                            Id = new Guid("cd904d8f-24c4-4556-a05e-9a6a48e14e26"),
                            ImagePath = "images/flags/",
                            Name = "Dominican Republic"
                        },
                        new
                        {
                            Id = new Guid("aad7744c-19ac-4319-b2db-aa4c0d08bafe"),
                            ImagePath = "images/flags/",
                            Name = "Ecuador"
                        },
                        new
                        {
                            Id = new Guid("0b3d5686-84b1-4581-921d-d9f6a1a05189"),
                            ImagePath = "images/flags/",
                            Name = "Egypt"
                        },
                        new
                        {
                            Id = new Guid("d7c32ba8-2624-4f30-b3f1-848fdb9d2ebc"),
                            ImagePath = "images/flags/",
                            Name = "El Salvador"
                        },
                        new
                        {
                            Id = new Guid("181f113c-88dc-4a18-82f2-1a4270e82208"),
                            ImagePath = "images/flags/",
                            Name = "Fiji"
                        },
                        new
                        {
                            Id = new Guid("18a89b82-c167-45ef-af57-743c37da9f0e"),
                            ImagePath = "images/flags/",
                            Name = "Finland"
                        },
                        new
                        {
                            Id = new Guid("0dc6de2d-7d18-4484-af91-697a45f34421"),
                            ImagePath = "images/flags/",
                            Name = "France"
                        },
                        new
                        {
                            Id = new Guid("fede4eb6-107e-4fc0-ab6f-38beaacc7d51"),
                            ImagePath = "images/flags/",
                            Name = "Germany"
                        },
                        new
                        {
                            Id = new Guid("320231cb-c73e-433a-a5b1-638108dfc7da"),
                            ImagePath = "images/flags/",
                            Name = "Ghana"
                        },
                        new
                        {
                            Id = new Guid("6f56dd28-df8f-46ef-868e-a2a6f96491b1"),
                            ImagePath = "images/flags/",
                            Name = "Greece"
                        },
                        new
                        {
                            Id = new Guid("b567a994-b8d3-41ad-ba1a-139b993a9649"),
                            ImagePath = "images/flags/",
                            Name = "Guatemala"
                        },
                        new
                        {
                            Id = new Guid("61d203b9-131b-4aaa-bc8f-c0edfe5e6c26"),
                            ImagePath = "images/flags/",
                            Name = "Hungary"
                        },
                        new
                        {
                            Id = new Guid("0479c05f-7227-46e4-955b-ec710a784900"),
                            ImagePath = "images/flags/",
                            Name = "Iceland"
                        },
                        new
                        {
                            Id = new Guid("bd1b0815-e21d-4f1a-b7ae-f2026e81b219"),
                            ImagePath = "images/flags/",
                            Name = "India"
                        },
                        new
                        {
                            Id = new Guid("a2431d84-9fe9-4621-8524-7f90589e0916"),
                            ImagePath = "images/flags/",
                            Name = "Ireland"
                        },
                        new
                        {
                            Id = new Guid("559f68de-f6ce-4192-8479-4b6d91c19853"),
                            ImagePath = "images/flags/",
                            Name = "Israel"
                        },
                        new
                        {
                            Id = new Guid("5bcdf77d-cb16-4e91-841b-73c58a8bdff4"),
                            ImagePath = "images/flags/",
                            Name = "Italy"
                        },
                        new
                        {
                            Id = new Guid("94f07d65-9a5b-490c-b96b-3f1c0d7befa9"),
                            ImagePath = "images/flags/",
                            Name = "Jamaica"
                        },
                        new
                        {
                            Id = new Guid("79151635-acf6-483c-9c73-d7ae7af3ad83"),
                            ImagePath = "images/flags/",
                            Name = "Japan"
                        },
                        new
                        {
                            Id = new Guid("417f880a-e36e-4e56-ba61-562cdde1fc00"),
                            ImagePath = "images/flags/",
                            Name = "Kosovo"
                        },
                        new
                        {
                            Id = new Guid("b3761ff8-7744-462d-819d-8a4b7a98b642"),
                            ImagePath = "images/flags/",
                            Name = "Kuwait"
                        },
                        new
                        {
                            Id = new Guid("7ef5d217-1c8b-4bf0-a539-70d85a76d03d"),
                            ImagePath = "images/flags/",
                            Name = "Lithuania"
                        },
                        new
                        {
                            Id = new Guid("43ea2a42-f6f3-4041-a667-9da9cdd33587"),
                            ImagePath = "images/flags/",
                            Name = "Madagascar"
                        },
                        new
                        {
                            Id = new Guid("019e4ff6-c0b1-4e23-a0ff-092155cd680b"),
                            ImagePath = "images/flags/",
                            Name = "Malaysia"
                        },
                        new
                        {
                            Id = new Guid("d8500ac5-1337-4a88-95d8-067ce373acb2"),
                            ImagePath = "images/flags/",
                            Name = "Maldives"
                        },
                        new
                        {
                            Id = new Guid("5ab9cbed-70eb-4c24-8eef-94e2ff192e6f"),
                            ImagePath = "images/flags/",
                            Name = "Malta"
                        },
                        new
                        {
                            Id = new Guid("56ce7d6a-c317-4cc8-859b-c1be0666e904"),
                            ImagePath = "images/flags/",
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = new Guid("ff737d0c-62b6-4047-9d8d-a8948c57a7ca"),
                            ImagePath = "images/flags/",
                            Name = "Monaco"
                        },
                        new
                        {
                            Id = new Guid("f0aa0463-e447-44c2-b3e4-a666376ac46d"),
                            ImagePath = "images/flags/",
                            Name = "Morocco"
                        },
                        new
                        {
                            Id = new Guid("81c626c8-e07f-4389-8523-358f03af2ab6"),
                            ImagePath = "images/flags/",
                            Name = "Nepal"
                        },
                        new
                        {
                            Id = new Guid("6d458aca-9a8a-4a87-905d-12bff790534b"),
                            ImagePath = "images/flags/",
                            Name = "Netherlands"
                        },
                        new
                        {
                            Id = new Guid("992ac204-4543-4001-8c50-fc3941cbb222"),
                            ImagePath = "images/flags/",
                            Name = "New Zealand"
                        },
                        new
                        {
                            Id = new Guid("019b9b7f-6be3-40c1-8a58-6e9adfe7431f"),
                            ImagePath = "images/flags/",
                            Name = "Nigeria"
                        },
                        new
                        {
                            Id = new Guid("00034c83-8721-4c91-af54-5de2c09a7322"),
                            ImagePath = "images/flags/",
                            Name = "Norway"
                        },
                        new
                        {
                            Id = new Guid("7f7a2bf5-fb2d-40a1-870d-085fafcb4148"),
                            ImagePath = "images/flags/",
                            Name = "Pakistan"
                        },
                        new
                        {
                            Id = new Guid("bfa738be-1283-4f84-b09c-fded55a481d5"),
                            ImagePath = "images/flags/",
                            Name = "Palestine"
                        },
                        new
                        {
                            Id = new Guid("b05c73d2-0820-4b65-bb9f-b0976c8637a2"),
                            ImagePath = "images/flags/",
                            Name = "Panama"
                        },
                        new
                        {
                            Id = new Guid("81d14e04-13d4-41e7-b269-fbd3cc35e222"),
                            ImagePath = "images/flags/",
                            Name = "Peru"
                        },
                        new
                        {
                            Id = new Guid("e36145da-f776-48b1-9443-12ebddc055e6"),
                            ImagePath = "images/flags/",
                            Name = "Philippines"
                        },
                        new
                        {
                            Id = new Guid("052e7399-9e62-46a3-94bf-3f6f6402617c"),
                            ImagePath = "images/flags/",
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("188908db-a9cb-4ace-a323-b5e90302808f"),
                            ImagePath = "images/flags/",
                            Name = "Portugal"
                        },
                        new
                        {
                            Id = new Guid("b57b85f5-cdd3-4784-9df3-b1e3328d7a3c"),
                            ImagePath = "images/flags/",
                            Name = "Qatar"
                        },
                        new
                        {
                            Id = new Guid("d945981b-8dab-417c-afac-e7035c589d41"),
                            ImagePath = "images/flags/",
                            Name = "Russia"
                        },
                        new
                        {
                            Id = new Guid("7bd4f362-027f-4164-9d41-976369a07c2d"),
                            ImagePath = "images/flags/",
                            Name = "St. Kitts & Nevis"
                        },
                        new
                        {
                            Id = new Guid("5dd7177b-2f32-47a6-9977-4d590bc024db"),
                            ImagePath = "images/flags/",
                            Name = "Saudi Arabia"
                        },
                        new
                        {
                            Id = new Guid("563214fb-99b3-4ec7-a338-005bcfcfd384"),
                            ImagePath = "images/flags/",
                            Name = "Serbia"
                        },
                        new
                        {
                            Id = new Guid("94eaa5cf-c35a-480a-b900-34100a058069"),
                            ImagePath = "images/flags/",
                            Name = "South Africa"
                        },
                        new
                        {
                            Id = new Guid("27826286-8169-44e5-abd3-7c8a861f3fb0"),
                            ImagePath = "images/flags/",
                            Name = "South Korea"
                        },
                        new
                        {
                            Id = new Guid("b1724e47-04d5-4cdc-9f22-8e2d7466001a"),
                            ImagePath = "images/flags/",
                            Name = "Spain"
                        },
                        new
                        {
                            Id = new Guid("b05b6f1f-a9a4-4804-a5c4-ad9de7b27762"),
                            ImagePath = "images/flags/",
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = new Guid("e20eb7b7-bfd7-45de-ad11-b9b603708dfe"),
                            ImagePath = "images/flags/",
                            Name = "Thailand"
                        },
                        new
                        {
                            Id = new Guid("e26fdd13-118a-4993-b4eb-dc34ffc09f1f"),
                            ImagePath = "images/flags/",
                            Name = "Trinidad & Tobago"
                        },
                        new
                        {
                            Id = new Guid("d02863d3-dfc3-4c7d-b675-6d2ff3ef0f6c"),
                            ImagePath = "images/flags/",
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = new Guid("8dd3b3c5-18a8-4c0a-a7d5-bb59a85464f0"),
                            ImagePath = "images/flags/",
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = new Guid("88e5fcdc-51d0-4446-bba1-5120f8a292aa"),
                            ImagePath = "images/flags/",
                            Name = "UAE"
                        },
                        new
                        {
                            Id = new Guid("fa4043bb-87cc-4b87-8618-32767d0ba339"),
                            ImagePath = "images/flags/",
                            Name = "UK"
                        },
                        new
                        {
                            Id = new Guid("b930e53d-974f-4d02-881e-dddcb994ccfc"),
                            ImagePath = "images/flags/",
                            Name = "USA"
                        },
                        new
                        {
                            Id = new Guid("b8d953c3-b1a2-40d1-be30-1f549e5ad667"),
                            ImagePath = "images/flags/",
                            Name = "Venezuela"
                        },
                        new
                        {
                            Id = new Guid("de656598-e492-44b5-b652-2a971996fe52"),
                            ImagePath = "images/flags/",
                            Name = "Vietnam"
                        });
                });

            modelBuilder.Entity("foodtopia.Models.HeartedRecipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("HeartedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId", "RecipeId")
                        .IsUnique();

                    b.ToTable("HeartedRecipes");
                });

            modelBuilder.Entity("foodtopia.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("foodtopia.Models.Instruction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Step")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("foodtopia.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("DifficultyRating")
                        .HasColumnType("numeric");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ReviewedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TasteRating")
                        .HasColumnType("numeric");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("foodtopia.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CountryDetailsId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("DifficultyAverage")
                        .HasColumnType("numeric");

                    b.Property<int>("DifficultyReviewCount")
                        .HasColumnType("integer");

                    b.Property<int>("HeartCount")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TasteAverage")
                        .HasColumnType("numeric");

                    b.Property<int>("TasteReviewCount")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CountryDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("foodtopia.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(28)
                        .HasColumnType("character varying(28)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("\"Email\" IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("\"Username\" IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("foodtopia.Models.HeartedRecipe", b =>
                {
                    b.HasOne("foodtopia.Models.Recipe", "Recipe")
                        .WithMany("HeartedByUsers")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("foodtopia.Models.User", "User")
                        .WithMany("HeartedRecipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("foodtopia.Models.Ingredient", b =>
                {
                    b.HasOne("foodtopia.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("foodtopia.Models.Instruction", b =>
                {
                    b.HasOne("foodtopia.Models.Recipe", "Recipe")
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("foodtopia.Models.Rating", b =>
                {
                    b.HasOne("foodtopia.Models.Recipe", "Recipe")
                        .WithMany("Ratings")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("foodtopia.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("foodtopia.Models.Recipe", b =>
                {
                    b.HasOne("foodtopia.Models.Country", "CountryDetails")
                        .WithMany("Recipes")
                        .HasForeignKey("CountryDetailsId");

                    b.HasOne("foodtopia.Models.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryDetails");

                    b.Navigation("User");
                });

            modelBuilder.Entity("foodtopia.Models.Country", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("foodtopia.Models.Recipe", b =>
                {
                    b.Navigation("HeartedByUsers");

                    b.Navigation("Ingredients");

                    b.Navigation("Instructions");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("foodtopia.Models.User", b =>
                {
                    b.Navigation("HeartedRecipes");

                    b.Navigation("Ratings");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
