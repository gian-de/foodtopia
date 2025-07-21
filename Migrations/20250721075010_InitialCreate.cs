using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsGuest = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    SlugText = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    SlugNumber = table.Column<int>(type: "integer", nullable: false),
                    FullSlug = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VisibilityStatus = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    TasteAverage = table.Column<decimal>(type: "numeric", nullable: false),
                    DifficultyAverage = table.Column<decimal>(type: "numeric", nullable: false),
                    TasteReviewCount = table.Column<int>(type: "integer", nullable: false),
                    DifficultyReviewCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VisibilityStatus = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeartedPlaylists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartedPlaylists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeartedPlaylists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeartedPlaylists_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeartedRecipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartedRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeartedRecipes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeartedRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<decimal>(type: "numeric", nullable: false),
                    Measurement = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", maxLength: 600, nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistRecipes",
                columns: table => new
                {
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistRecipes", x => new { x.PlaylistId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_PlaylistRecipes_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TasteRating = table.Column<double>(type: "double precision", precision: 2, scale: 1, nullable: false),
                    DifficultyRating = table.Column<double>(type: "double precision", precision: 2, scale: 1, nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisibilityReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VisibilityStatus = table.Column<string>(type: "text", nullable: false),
                    ReviewFeedback = table.Column<string>(type: "text", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReviewedById = table.Column<Guid>(type: "uuid", nullable: true),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: true),
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisibilityReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_AspNetUsers_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("42d39e76-14b3-41e5-827d-317cc9bd16a4"), null, "Admin", "ADMIN" },
                    { new Guid("aaf339a6-d1de-47a9-8320-2cbb73af988c"), null, "User", "USER" },
                    { new Guid("f5ec44f6-aa4d-47b4-908b-4c04b3029534"), null, "Senior Admin", "SENIOR ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsGuest", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4f533a33-a555-4490-92e1-6046a789efb4"), 0, "2a8cd15e-67db-4f81-b07c-33fe9e5341ba", new DateTime(2025, 7, 21, 7, 50, 9, 714, DateTimeKind.Utc).AddTicks(1520), "ironfist@email.com", true, false, false, null, "IRONFIST@EMAIL.COM", "IRONFIST", "AQAAAAIAAYagAAAAENWYm5+nVImlxUlb47qVMOnPkhFBlrhizkER7UVlC14lF9yY3uBJ1uEVpK4xzeaCZA==", null, false, null, false, "IronFist" },
                    { new Guid("7ade051b-43be-4938-8942-507046ab759a"), 0, "0d004a6b-445b-4381-bb66-912dfbdf5b7c", new DateTime(2025, 7, 21, 7, 50, 9, 638, DateTimeKind.Utc).AddTicks(5520), "rocketraccoon@email.com", true, false, false, null, "ROCKETRACCOON@EMAIL.COM", "ROCKET", "AQAAAAIAAYagAAAAEKEcHSS00BV75PcLVa2XtDVRJ9ycvG/TFlP5bQTvvB36UeX2Q5skLXHJzLSmsNMQrQ==", null, false, null, false, "Rocket" },
                    { new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"), 0, "61dfa4e3-4d05-40ae-8f97-d1a6b9411b79", new DateTime(2025, 7, 21, 7, 50, 9, 598, DateTimeKind.Utc).AddTicks(5460), "adamwarlock@email.com", true, false, false, null, "ADAMWARLOCK@EMAIL.COM", "WARLOCK", "AQAAAAIAAYagAAAAEDEf0D/eXsN8MJtD3pJAXHSGhxEkQgx+CLX2TyD2ENIPhk3mhjEZC/P2BsuPjePFVQ==", null, false, null, false, "Warlock" },
                    { new Guid("afe80b95-1e55-4894-9507-81790f3d3424"), 0, "6de8adce-7c43-4157-86de-1dc0494548dd", new DateTime(2025, 7, 21, 7, 50, 9, 676, DateTimeKind.Utc).AddTicks(6340), "drstrange@email.com", true, false, false, null, "DRSTRANGE@EMAIL.COM", "DRSTRANGE", "AQAAAAIAAYagAAAAEHS70hB3erml500+m9e3u/7gfc3SxFvdkFHyGZdaZMZTVotfUd49K/8KMLWTfaQtBw==", null, false, null, false, "DrStrange" },
                    { new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"), 0, "28d3c06d-1881-4f85-a43a-c157b3408a5c", new DateTime(2025, 7, 21, 7, 50, 9, 557, DateTimeKind.Utc).AddTicks(8960), "spiderman@email.com", true, false, false, null, "SPIDERMAN@EMAIL.COM", "SPIDER-MAN", "AQAAAAIAAYagAAAAEIOXNQYbNe58EE1KtGnqTGhhzu5NUXQp2UIyZ7p8LmftvoyJO6kpeXlftw8Vgl38xw==", null, false, null, false, "Spider-man" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ImagePath", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("05472a5f-5c4c-4afc-bed2-d60a5b668823"), "images/flags/uk.svg", "UK", "united-kingdom" },
                    { new Guid("0898e080-716f-4413-91c4-e9c52c493834"), "images/flags/turkey.svg", "Turkey", "turkey" },
                    { new Guid("117df930-fe06-461a-8438-e0400ab4dd7d"), "images/flags/portugal.svg", "Portugal", "portugal" },
                    { new Guid("13e5d348-9fd9-4788-b33a-3ff80fd50ac1"), "images/flags/south_korea.svg", "South Korea", "south-korea" },
                    { new Guid("162452b8-5284-45ff-9001-ecd336021bec"), "images/flags/bolivia.svg", "Bolivia", "bolivia" },
                    { new Guid("1ad8de04-ac42-462d-b8ac-262f3f7870a2"), "images/flags/ecuador.svg", "Ecuador", "ecuador" },
                    { new Guid("1b42b510-ad24-4319-89d9-b104127c9f08"), "images/flags/fiji.svg", "Fiji", "fiji" },
                    { new Guid("1d5d4476-a20d-4160-b009-2a7f2565e0c2"), "images/flags/australia.svg", "Australia", "australia" },
                    { new Guid("1f5bebf3-8bde-4af8-b845-b340015a573d"), "images/flags/serbia.svg", "Serbia", "serbia" },
                    { new Guid("2268db96-ce3d-4a95-bf9e-36ba6b03baf3"), "images/flags/croatia.svg", "Croatia", "croatia" },
                    { new Guid("22d7e231-01a9-45bd-9577-f1ed0fd97448"), "images/flags/iceland.svg", "Iceland", "iceland" },
                    { new Guid("278eaffa-f980-40d2-b014-10c04163c52a"), "images/flags/russia.svg", "Russia", "russia" },
                    { new Guid("353cf522-3deb-4bbb-b77d-ad247ab09eba"), "images/flags/israel.svg", "Israel", "israel" },
                    { new Guid("3561c49c-ed61-4a3e-85f0-23b9c66f42ee"), "images/flags/sweden.svg", "Sweden", "sweden" },
                    { new Guid("36fa5cc9-e6a9-49cc-98d0-dd3c9aecce6c"), "images/flags/japan.svg", "Japan", "japan" },
                    { new Guid("3f551bca-b34c-48f0-af2d-05b5929b420b"), "images/flags/dominican_republic.svg", "Dominican Republic", "dominica-republic" },
                    { new Guid("492257fb-340d-4f89-aa3f-9952811826f7"), "images/flags/trinidad&tobago.svg", "Trinidad & Tobago", "trinidad-and-tobago" },
                    { new Guid("4b9baef3-b816-49b3-817c-f26abe012942"), "images/flags/south_africa.svg", "South Africa", "south-africa" },
                    { new Guid("4bbe3f9a-c384-4b9d-9cf7-c40c849aca45"), "images/flags/saudi_arabia.svg", "Saudi Arabia", "saudi-arabia" },
                    { new Guid("4bc794b1-5000-4dfd-9c9e-451d032744c8"), "images/flags/afghanistan.svg", "Afghanistan", "afghanistan" },
                    { new Guid("4c00e5af-921b-427c-962a-8e42fcd7db80"), "images/flags/france.svg", "France", "france" },
                    { new Guid("4ccef4c3-d822-483c-bddf-8bd11c55a3df"), "images/flags/kosovo.svg", "Kosovo", "kosovo" },
                    { new Guid("4e815088-0f45-4e2c-84b6-e878cbe1cbd0"), "images/flags/uae.svg", "UAE", "united-arab-emirates" },
                    { new Guid("4ff91cd7-c0cb-4e85-8027-d2ee67d20913"), "images/flags/norway.svg", "Norway", "norway" },
                    { new Guid("52ca5dd4-843a-4408-a450-de8d6756a62f"), "images/flags/nigeria.svg", "Nigeria", "nigeria" },
                    { new Guid("550054a5-1eb7-4468-b693-a1540a5d3131"), "images/flags/mexico.svg", "Mexico", "mexico" },
                    { new Guid("64c7e557-7a14-454b-97c5-bbcf4cb274dd"), "images/flags/brazil.svg", "Brazil", "brazil" },
                    { new Guid("66fb47e6-62ad-477a-bd36-06179278cef8"), "images/flags/jamaica.svg", "Jamaica", "jamaica" },
                    { new Guid("683b1e50-3f82-4310-93e5-00398707469f"), "images/flags/italy.svg", "Italy", "italy" },
                    { new Guid("689dcce4-f72b-4af0-9e48-f2961612a37c"), "images/flags/ireland.svg", "Ireland", "ireland" },
                    { new Guid("6b600158-b511-44bd-8a52-d4c88a78a1ca"), "images/flags/vietnam.svg", "Vietnam", "vietnam" },
                    { new Guid("6bdb128a-8c6c-4aba-8103-815ccc37ab3a"), "images/flags/algeria.svg", "Algeria", "algeria" },
                    { new Guid("71253609-c9b9-4035-ba34-bbf90646f31e"), "images/flags/belgium.svg", "Belgium", "belgium" },
                    { new Guid("71b7005d-0add-467b-b12f-8ecc8607e889"), "images/flags/costa_rica.svg", "Costa Rica", "costa-rica" },
                    { new Guid("7a5f9ebf-6d8e-4589-bbfb-d22739b1eb2b"), "images/flags/pakistan.svg", "Pakistan", "pakistan" },
                    { new Guid("7bcc9997-a600-4246-a86e-36517c82702d"), "images/flags/palestine.svg", "Palestine", "palestine" },
                    { new Guid("7ea1a850-1fed-48cd-9baa-24355f5b88fc"), "images/flags/venezuela.svg", "Venezuela", "venezuela" },
                    { new Guid("7ff86fe8-b9b6-485d-a244-59bfb9840160"), "images/flags/argentina.svg", "Argentina", "argentina" },
                    { new Guid("846d9792-33d6-42f9-aa56-a2ede3edf63b"), "images/flags/colombia.svg", "Colombia", "colombia" },
                    { new Guid("8a65d590-b35d-4445-8544-fc2c70fc3f54"), "images/flags/finland.svg", "Finland", "finland" },
                    { new Guid("910a64c2-a8ef-42a7-b1b6-c96a08f3332b"), "images/flags/poland.svg", "Poland", "poland" },
                    { new Guid("915b012d-b28a-44dc-b053-f2c6a86c8099"), "images/flags/ukraine.svg", "Ukraine", "ukraine" },
                    { new Guid("93a2792c-5349-4b14-abc2-b4781395c394"), "images/flags/thailand.svg", "Thailand", "thailand" },
                    { new Guid("9439fe2d-211a-4901-9e85-57392790b5cf"), "images/flags/austria.svg", "Austria", "austria" },
                    { new Guid("96fb7dd8-17f1-40fc-a328-6834b1818304"), "images/flags/azerbaijan.svg", "Azerbaijan", "azerbaijan" },
                    { new Guid("9dc8871d-c338-4e12-b119-dcef98a5e7fa"), "images/flags/egypt.svg", "Egypt", "egypt" },
                    { new Guid("9f4b3a8f-c053-4a14-8053-bca8f4465c33"), "images/flags/germany.svg", "Germany", "germany" },
                    { new Guid("9f758b38-4ce1-41ab-809d-a633f1be3aa6"), "images/flags/bahamas.svg", "Bahamas", "bahamas" },
                    { new Guid("a3a11f10-7372-4049-b791-4db177779ff5"), "images/flags/cameroon.svg", "Cameroon", "cameroon" },
                    { new Guid("b21f42b5-42b1-4f2e-98c4-714c29288f01"), "images/flags/angola.svg", "Angola", "angola" },
                    { new Guid("b6ab2925-6097-48cc-a7f7-d4ed8c2b256a"), "images/flags/greece.svg", "Greece", "greece" },
                    { new Guid("bdc127b4-8d7e-4fdc-822f-0da96c9aa7ff"), "images/flags/netherlands.svg", "Netherlands", "netherlands" },
                    { new Guid("be8e65a3-4281-4146-b391-4d2a132a5eb3"), "images/flags/hungary.svg", "Hungary", "hungary" },
                    { new Guid("c8d9ec81-a9a1-4299-ae80-45d6b1e9b012"), "images/flags/panama.svg", "Panama", "panama" },
                    { new Guid("ca309321-8afa-468f-8ace-8027b519e2dc"), "images/flags/peru.svg", "Peru", "peru" },
                    { new Guid("d088946a-b0cc-4616-a07c-19a2c22a7c3f"), "images/flags/el_salvador.svg", "El Salvador", "el-salvador" },
                    { new Guid("d137f377-8c33-4244-9b22-4f94b5336761"), "images/flags/qatar.svg", "Qatar", "qatar" },
                    { new Guid("d2f03586-3ac2-48a5-9745-398584df4dba"), "images/flags/philippines.svg", "Philippines", "philippines" },
                    { new Guid("ddd3dc5f-8b84-4435-a271-cd5dc2bd6406"), "images/flags/monaco.svg", "Monaco", "monaco" },
                    { new Guid("de5c696e-94f2-4516-a902-8015ad3007a1"), "images/flags/canada.svg", "Canada", "canada" },
                    { new Guid("e1c716b5-4bda-47b2-9955-920e263bec73"), "images/flags/spain.svg", "Spain", "spain" },
                    { new Guid("e1cb7738-f5a3-4bc5-a0cf-33115a3a2007"), "images/flags/kuwait.svg", "Kuwait", "kuwait" },
                    { new Guid("e514fbfe-eb2b-4d4e-aa22-a339b668c0ce"), "images/flags/guatemala.svg", "Guatemala", "guatemala" },
                    { new Guid("e5336ea0-d112-4058-8360-de0ec32def0d"), "images/flags/china.svg", "China", "china" },
                    { new Guid("e9ec5987-63c6-410d-a5a7-3a579d82edac"), "images/flags/denmark.svg", "Denmark", "denmark" },
                    { new Guid("eaf84701-b556-4455-9bf5-d6874c2da601"), "images/flags/ghana.svg", "Ghana", "ghana" },
                    { new Guid("ed13d446-9af2-44ef-9b9e-0e87c11c70ba"), "images/flags/andorra.svg", "Andorra", "andorra" },
                    { new Guid("ee759b85-8f29-42e7-a785-353f89e690dd"), "images/flags/cuba.svg", "Cuba", "cuba" },
                    { new Guid("ef4fbacb-619d-4b8c-96db-eb68ca6116ae"), "images/flags/armenia.svg", "Armenia", "armenia" },
                    { new Guid("f4eaf144-7d25-451f-886b-13805e41c0cf"), "images/flags/india.svg", "India", "india" },
                    { new Guid("f9e82082-7640-420c-8447-a09433a3bd00"), "images/flags/chile.svg", "Chile", "chile" },
                    { new Guid("fb93df64-04c7-4f02-9456-017c0d802b0e"), "images/flags/antigua_barbuda.svg", "Antigua & Barbuda", "antigua-and-barbuda" },
                    { new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), "images/flags/usa.svg", "USA", "usa" },
                    { new Guid("feecd4a1-2a0d-489e-8b1a-efed38f8ce8e"), "images/flags/morocco.svg", "Morocco", "morocco" },
                    { new Guid("ff8f1db8-8536-4396-90f9-4842ab99e4bc"), "images/flags/albania.svg", "Albania", "albania" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CountryId", "DifficultyAverage", "DifficultyReviewCount", "ImageUrl", "Name", "PublishedAt", "TasteAverage", "TasteReviewCount", "UserId", "VisibilityStatus" },
                values: new object[,]
                {
                    { new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), new Guid("4b9baef3-b816-49b3-817c-f26abe012942"), 0m, 0, "images/recipes/bobotie.jpg", "Bobotie", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470), 0m, 0, null, "public" },
                    { new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), new Guid("13e5d348-9fd9-4788-b33a-3ff80fd50ac1"), 0m, 0, "images/recipes/kimchi.jpg", "Kimchi", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480), 0m, 0, null, "public" },
                    { new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), 0m, 0, "images/recipes/classic_cheeseburger.jpg", "Classic Cheeseburger", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3440), 0m, 0, new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"), "public" },
                    { new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), new Guid("93a2792c-5349-4b14-abc2-b4781395c394"), 0m, 0, "images/recipes/pad_thai.jpg", "Pad Thai", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460), 0m, 0, new Guid("4f533a33-a555-4490-92e1-6046a789efb4"), "public" },
                    { new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), 0m, 0, "images/recipes/low_calorie_pizza.jpg", "Low calorie pizza", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(1110), 0m, 0, new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"), "public" },
                    { new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), new Guid("05472a5f-5c4c-4afc-bed2-d60a5b668823"), 0m, 0, "images/recipes/fish_and_chips.jpg", "Fish and Chips", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480), 0m, 0, null, "public" },
                    { new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), new Guid("f4eaf144-7d25-451f-886b-13805e41c0cf"), 0m, 0, "images/recipes/chicken_biryani.jpg", "Chicken Biryani", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450), 0m, 0, new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"), "public" },
                    { new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), new Guid("6b600158-b511-44bd-8a52-d4c88a78a1ca"), 0m, 0, "images/recipes/pho.jpg", "Pho", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460), 0m, 0, new Guid("4f533a33-a555-4490-92e1-6046a789efb4"), "public" },
                    { new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), new Guid("7a5f9ebf-6d8e-4589-bbfb-d22739b1eb2b"), 0m, 0, "images/recipes/butter_chicken.jpg", "Butter Chicken", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470), 0m, 0, null, "public" },
                    { new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), new Guid("e5336ea0-d112-4058-8360-de0ec32def0d"), 0m, 0, "images/recipes/peking_duck.jpg", "Peking Duck", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450), 0m, 0, new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"), "public" },
                    { new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), new Guid("0898e080-716f-4413-91c4-e9c52c493834"), 0m, 0, "images/recipes/kebab.jpg", "Kebab", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470), 0m, 0, null, "public" },
                    { new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), new Guid("b6ab2925-6097-48cc-a7f7-d4ed8c2b256a"), 0m, 0, "images/recipes/moussaka.jpg", "Moussaka", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480), 0m, 0, null, "public" },
                    { new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), new Guid("278eaffa-f980-40d2-b014-10c04163c52a"), 0m, 0, "images/recipes/beef_stroganoff.jpg", "Beef Stroganoff", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450), 0m, 0, new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"), "public" },
                    { new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), new Guid("64c7e557-7a14-454b-97c5-bbcf4cb274dd"), 0m, 0, "images/recipes/feijoada.png", "Feijoada", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460), 0m, 0, new Guid("7ade051b-43be-4938-8942-507046ab759a"), "unlisted" },
                    { new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), new Guid("550054a5-1eb7-4468-b693-a1540a5d3131"), 0m, 0, "images/recipes/tacos_al_pastor.jpg", "Tacos al Pastor", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450), 0m, 0, new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"), "public" },
                    { new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), new Guid("36fa5cc9-e6a9-49cc-98d0-dd3c9aecce6c"), 0m, 0, "images/recipes/sushi.jpg", "Sushi", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460), 0m, 0, new Guid("afe80b95-1e55-4894-9507-81790f3d3424"), "public" },
                    { new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), new Guid("ca309321-8afa-468f-8ace-8027b519e2dc"), 0m, 0, "images/recipes/ceviche.jpeg", "Ceviche", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470), 0m, 0, new Guid("4f533a33-a555-4490-92e1-6046a789efb4"), "public" },
                    { new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), new Guid("683b1e50-3f82-4310-93e5-00398707469f"), 0m, 0, "images/recipes/lasagna.jpg", "Lasagna", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490), 0m, 0, null, "public" },
                    { new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), new Guid("9dc8871d-c338-4e12-b119-dcef98a5e7fa"), 0m, 0, "images/recipes/shawarma.jpg", "Shawarma", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490), 0m, 0, null, "public" },
                    { new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), new Guid("4c00e5af-921b-427c-962a-8e42fcd7db80"), 0m, 0, "images/recipes/croissant.jpg", "Croissant", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490), 0m, 0, null, "public" },
                    { new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), new Guid("910a64c2-a8ef-42a7-b1b6-c96a08f3332b"), 0m, 0, "images/recipes/pierogi.jpg", "Pierogi", new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480), 0m, 0, null, "public" }
                });

            migrationBuilder.InsertData(
                table: "HeartedRecipes",
                columns: new[] { "Id", "HeartedAt", "RecipeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") },
                    { new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("91d587d6-a100-415b-859a-a2631dbfd12d") },
                    { new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") },
                    { new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), new Guid("91d587d6-a100-415b-859a-a2631dbfd12d") },
                    { new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") },
                    { new Guid("61939421-e5cf-4700-82f1-8d103387170f"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910), new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("afe80b95-1e55-4894-9507-81790f3d3424") },
                    { new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4520), new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") },
                    { new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910), new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("7ade051b-43be-4938-8942-507046ab759a") },
                    { new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910), new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("4f533a33-a555-4490-92e1-6046a789efb4") },
                    { new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") },
                    { new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"), new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900), new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17") }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Measurement", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("045ff37e-63c4-413b-9553-b6082ef70c3d"), "slices", "Cheddar cheese", 4m, new Guid("2b53f900-d736-4393-a585-1f6624c177b2") },
                    { new Guid("0bce1bf7-1cea-43de-9cee-d85e1eeeb89f"), "lbs", "Pork shoulder", 2m, new Guid("bc259740-607d-4a1d-9347-c38713669a6c") },
                    { new Guid("0df2e923-4f5b-4203-925a-7d2e38c72d1c"), "cups", "Black beans", 2m, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0") },
                    { new Guid("0fa36b10-e022-42aa-b4c1-73b81ce4e51d"), "cups", "Sushi rice", 2m, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a") },
                    { new Guid("17dbfc9b-cd68-4937-94b5-d23a36af1c13"), "pcs", "Shrimp", 12m, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd") },
                    { new Guid("1cf5b843-7d93-4f3c-846e-3f9b726ae2d3"), "lb", "Smoked sausage", 1m, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0") },
                    { new Guid("1e85b82a-0dcd-4c37-a9c9-123e8c3280d5"), "cup", "Hoisin sauce", 0.5m, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c") },
                    { new Guid("1f6c5e7a-4b8d-9a3f-7b2c-3f9e7a5d6b12"), "large head", "Napa cabbage", 1m, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f") },
                    { new Guid("2b55982b-11e6-4642-afa8-6c727382753f"), "cup", "Soy sauce", 0.25m, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a") },
                    { new Guid("2f743557-4f5f-4783-b3fc-a36a41888940"), "cups", "Basmati rice", 2m, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49") },
                    { new Guid("2f97b6d4-5c8a-4a1f-9e7d-3b4f6a91c78e"), "cup", "Tomato puree", 1m, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5") },
                    { new Guid("37dec78e-9dac-4a98-99f2-03f0de13facd"), "cup", "Yogurt", 1m, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49") },
                    { new Guid("3a6f9e7b-5c4d-8a1f-7b2d-6e5f9b7c3a12"), "cup", "Milk (warm)", 1m, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a") },
                    { new Guid("3c7b9e6f-5d4a-1a8f-7b2c-9f6a5b7e3f18"), "large", "Egg", 1m, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92") },
                    { new Guid("3f7a6b9e-5c4d-8a1f-7b2d-9e6a5f9b7c18"), "cups", "Ricotta cheese", 2m, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487") },
                    { new Guid("3f7b6d5a-9c4e-8a1f-7b2d-6a9e5f4c7b12"), "cloves", "Garlic cloves (minced)", 4m, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f") },
                    { new Guid("3f9b7e5a-6d4c-8a1f-7b2d-9f5c7a6e3b12"), "cup", "All-purpose flour", 1m, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28") },
                    { new Guid("4b6e9a3f-7d1c-5f2b-8a7d-3c5e7a9b6f18"), "cups", "All-purpose flour", 2m, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92") },
                    { new Guid("4e7a5c3f-9d6b-2f8b-7f3a-8b9c6a5d7f4e"), "cup", "Red onion (thinly sliced)", 1m, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9") },
                    { new Guid("4e7b6a3c-9f8d-5b2a-7f1c-6d3e5f9a7b18"), "slices", "Milk-soaked bread", 2m, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95") },
                    { new Guid("5a6e7f9c-3b4d-8a1f-7b2c-9e6a7f5c3b18"), "cup", "Béchamel sauce", 1m, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771") },
                    { new Guid("5b9a6f7e-4e3d-8a1f-7b2d-5a6e7f3b8f12"), "pound", "Beef tenderloin (cut into strips)", 1m, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0") },
                    { new Guid("5c4e7b9f-2d4a-8f3b-7b2c-9a5f6a7b3e12"), "pound", "Chicken thighs (boneless)", 1m, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a") },
                    { new Guid("5f7c9d4e-3b6a-8f2f-7f5a-9c6b4a7d3e8b"), "cup", "Cilantro (chopped)", 0.25m, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9") },
                    { new Guid("5f9a6e7b-3c4d-8a1f-7b2d-6b9e7f3a5c12"), "cups", "All-purpose flour", 3m, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a") },
                    { new Guid("61046199-47f5-4d3b-8834-1cb7b8464a82"), "pcs", "Burger buns", 4m, new Guid("2b53f900-d736-4393-a585-1f6624c177b2") },
                    { new Guid("61d3f2a9-7b6e-48d5-8f9c-7a2e9b34d7fa"), "lb", "Chicken thighs (cubed)", 1m, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5") },
                    { new Guid("697e9870-e247-411e-96f3-e56b8d21be1b"), "cups", "Flour", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("6a7b5c9e-3d4a-8f1e-7b2d-9e6b5a7c8f12"), "cup", "Sour cream", 1m, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0") },
                    { new Guid("6a7b9e5c-3f8d-4a1f-7c2d-9f5b7a6e3f12"), "cups", "Potatoes (mashed)", 2m, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92") },
                    { new Guid("6b8f35a9-9247-4b5d-8574-2f8b39e7c4b3"), "lbs", "Pork ribs", 1.5m, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0") },
                    { new Guid("6b9a7d4f-3e8c-5a1f-7b2d-9f5c7a4e3b18"), "tbsp", "Korean chili flakes (gochugaru)", 3m, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f") },
                    { new Guid("6ba75d76-24d6-404e-b437-4b8b44f97c74"), "cup", "Bean sprouts", 1m, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd") },
                    { new Guid("6f2c49e4-81f7-4d83-9f89-7a3b2f2a79db"), "small", "Onion (grated)", 1m, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9") },
                    { new Guid("6f3b9a7e-5d4c-1a8f-7b2c-9e6a5f7b3c18"), "cups", "Potatoes (cut into fries)", 4m, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28") },
                    { new Guid("6f48049f-e9bb-489c-b98a-f57c3c0212ed"), "cup", "Pineapple chunks", 1m, new Guid("bc259740-607d-4a1d-9347-c38713669a6c") },
                    { new Guid("6f9a5c7b-3e4d-8a1f-7b2d-9b6a5f7c3e12"), "pieces", "Lasagna noodles", 12m, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487") },
                    { new Guid("6f9c7b5a-3e4d-8a1f-7b2d-5a7e6f3b9c12"), "teaspoons", "Yeast", 2m, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a") },
                    { new Guid("7a5b9f6e-5c4d-8a1f-7b2c-9e7a5c9b6f18"), "cloves", "Garlic cloves (minced)", 3m, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a") },
                    { new Guid("7a6b9e5f-3c4d-8a1f-7b2d-9f6e7c5b3a18"), "cup", "Unsalted butter", 1m, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a") },
                    { new Guid("7b6f9c5e-3d4a-8a1f-7b2d-5e7c9a6f3b18"), "pound", "Ground beef", 1m, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487") },
                    { new Guid("7b9d6f3e-4a5c-8f2b-7d3a-9c6a4f5e8b7f"), "cup", "Lime juice", 1m, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9") },
                    { new Guid("7d4b6f82-5c93-2f8a-9e36-4b7c39e5d3f2"), "cups", "Beef broth", 4m, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab") },
                    { new Guid("7d9e6b2f-3a4c-8f1b-7a5f-6f9b4e0d7a38"), "tbsp", "Butter", 2m, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5") },
                    { new Guid("7e5b9c6a-4e3d-8a1f-7b2d-5f7a6b8c9f12"), "cups", "Mushrooms (sliced)", 2m, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0") },
                    { new Guid("7f6c3a9b-5e1d-4f9a-7b2c-9a8f4e7d6b13"), "cup", "Chopped onion", 1m, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95") },
                    { new Guid("830d8300-a1d6-408a-8ab3-99541fb423e3"), "pcs", "Lettuce leaves", 4m, new Guid("2b53f900-d736-4393-a585-1f6624c177b2") },
                    { new Guid("843d5c82-3a4b-4f8e-b746-389fbf68d1d1"), "pcs", "Scallions", 6m, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c") },
                    { new Guid("87f6815c-5992-4f7d-8a49-3f5183e556de"), "pcs", "Corn tortillas", 8m, new Guid("bc259740-607d-4a1d-9347-c38713669a6c") },
                    { new Guid("8a042d5b-5073-4f71-b823-ab102e3293ea"), "pcs", "Nori sheets", 4m, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a") },
                    { new Guid("8a7b5cd3-b432-4c96-8f4e-6d23b9cfe3d7"), "whole", "Duck", 1m, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c") },
                    { new Guid("8a7c5f3e-9b6d-4f1a-7b2c-6a9e7b5d3f18"), "pieces", "Cod fillets", 4m, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28") },
                    { new Guid("8a9f6b7e-5c4d-8a1f-7b2d-6e7a5f9c3e12"), "teaspoons", "Ground cumin", 2m, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a") },
                    { new Guid("8b9c7e6b-3f4d-8a1f-7b2d-6f7a5c8e9f12"), "medium", "Onion (chopped)", 1m, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0") },
                    { new Guid("8f5c3a7d-4b92-96e2-7f6b-3a49e2c5f8d7"), "lb", "Thinly sliced beef", 1m, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab") },
                    { new Guid("913a61c7-5f73-4900-a68b-637d6176f96e"), "cup", "Pad Thai sauce", 0.5m, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd") },
                    { new Guid("92fc04e6-7949-44ee-97ef-b795444a8e94"), "lb", "Chicken thighs", 1m, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49") },
                    { new Guid("9c4761af-93b6-45f5-b2d5-7a29f4d78163"), "tsp", "Ground cumin", 1m, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9") },
                    { new Guid("9d6f4b3a-7e8b-5c2f-3a9d-7b6a4e5f8c3f"), "lb", "Fresh fish (cubed)", 1m, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9") },
                    { new Guid("9e2b6f7c-3a5d-4b92-83e7-5c39f4a6d8f2"), "cup", "Bean sprouts", 1m, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab") },
                    { new Guid("9e3b7a5d-6a4f-1c8b-7f2d-3f6c5f7b9a18"), "tbsp", "Salt", 1m, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f") },
                    { new Guid("9e5a3f7b-6d4c-8a1f-7b2d-6a9e7f5c3b12"), "cups", "Vegetable oil", 2m, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28") },
                    { new Guid("9e5b7c6a-3f4d-8a1f-7b2d-5f6e7a9c3b18"), "cups", "Mozzarella cheese (shredded)", 2m, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487") },
                    { new Guid("9f5c3e7a-4d1b-6a8f-7b2c-7b9a6e3f5a18"), "cup", "Cheddar cheese (shredded)", 1m, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92") },
                    { new Guid("9f5d3a7c-1e8b-6a4f-7b9d-3f2e6c9a5f8a"), "tbsp", "Curry powder", 2m, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95") },
                    { new Guid("9f6b7e5c-3a4d-8a1f-7b2c-5e7a6f9b3c12"), "cups", "Tomatoes (diced)", 2m, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771") },
                    { new Guid("9f7e8c5b-3c4d-8a1f-7b2d-9e5f7a6c3b12"), "cup", "Yogurt (plain)", 1m, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a") },
                    { new Guid("a1c8a4d5-22dc-4b8e-a452-573fc9159f65"), "pcs", "Pancakes", 12m, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c") },
                    { new Guid("a1d3bbaf-1132-4111-b558-2e027fab8926"), "large", "Eggplants (sliced)", 2m, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771") },
                    { new Guid("a7c5d8f3-4b92-3f6a-96e7-5d2b7c39f4e6"), "oz", "Rice noodles", 8m, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab") },
                    { new Guid("a824a011-d517-43e2-8b80-9242324a0242"), "cup", "Adobo marinade", 1m, new Guid("bc259740-607d-4a1d-9347-c38713669a6c") },
                    { new Guid("b02357ad-7e58-448a-a65f-9c5d9e781f22"), "lb", "Ground lamb", 1m, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9") },
                    { new Guid("b1c7e5f4-91a8-4b3d-7f2e-6d9a5f8c301b"), "lb", "Ground beef", 1m, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95") },
                    { new Guid("b47e1f6a-8f3c-4a2d-91b7-6a9c58f7e302"), "cup", "Heavy cream", 0.5m, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5") },
                    { new Guid("b6bef407-688f-4948-8c62-84af05c4c7a6"), "lb", "Fresh salmon", 1m, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a") },
                    { new Guid("b7c9a5e6-3d4f-8a1f-7b2d-6f5e7a9b3c12"), "pound", "Ground lamb", 1m, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771") },
                    { new Guid("be8b28cc-b3ba-4d35-866e-5d4ce096a788"), "", "Egg", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("d8b26c49-5f7d-46c4-972b-7a5f8b3d26e5"), "pcs", "Bay leaves", 2m, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0") },
                    { new Guid("e1a9d4a8-6d34-41b8-bc70-1245a1e5f5a1"), "oz", "Rice noodles", 8m, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd") },
                    { new Guid("f639974d-9bf6-4efd-954c-5abec793ac11"), "cup", "Sauce", 1m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("f8b91c6a-3f2b-4217-b58d-9a38f6e0b277"), "tsp", "Salt", 0.5m, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9") },
                    { new Guid("fe728b6c-4c0a-4908-9596-8ed49bdae068"), "tbsp", "Biryani spices", 2m, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49") },
                    { new Guid("ffde08e9-ce76-4a6d-88c2-437205c0ad97"), "lb", "Ground beef", 1m, new Guid("2b53f900-d736-4393-a585-1f6624c177b2") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Text" },
                values: new object[,]
                {
                    { new Guid("03e9f8e6-539c-41e7-a041-8af500790ba7"), 5, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Assemble tacos with pork, pineapple, and toppings of choice." },
                    { new Guid("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"), 4, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Toast burger buns lightly on the grill." },
                    { new Guid("19e6a008-bc94-4bff-8fd7-8b633712f9b9"), 4, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes." },
                    { new Guid("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"), 2, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), "Cook black beans with bay leaves until tender." },
                    { new Guid("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"), 5, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), "Serve hot with white rice and orange slices." },
                    { new Guid("2470414b-0fb5-4714-807f-bd0e58961f2d"), 2, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Grill patties for 3-4 minutes per side." },
                    { new Guid("2ada858b-3049-488e-891e-7c4eca8ea28f"), 5, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Slice roll into bite-sized pieces and serve with soy sauce." },
                    { new Guid("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"), 1, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), "Cook rice noodles according to package instructions." },
                    { new Guid("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"), 2, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), "Cook eggplant slices in olive oil until soft and lightly browned." },
                    { new Guid("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"), 2, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), "Rinse the cabbage thoroughly to remove excess salt." },
                    { new Guid("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"), 4, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), "Fold the dough over the filling and pinch edges to seal." },
                    { new Guid("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"), 3, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), "Mix onions, ground beef, bread, and curry powder in a bowl." },
                    { new Guid("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"), 2, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), "Coat fish fillets with flour, then dip in batter." },
                    { new Guid("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"), 3, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), "Cook ground beef and season with garlic and spices." },
                    { new Guid("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"), 5, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), "Garnish with bean sprouts, herbs, and lime wedges." },
                    { new Guid("43f35046-194d-414c-909c-ec7a0fad643c"), 4, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Seal the pot with a lid and cook on low heat for 30 minutes." },
                    { new Guid("4980a006-6a16-4788-bc52-c1aab9215845"), 2, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Place a nori sheet on a bamboo mat." },
                    { new Guid("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"), 4, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), "Simmer on low heat for 10-15 minutes." },
                    { new Guid("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"), 4, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), "Pack the mixture tightly into a jar." },
                    { new Guid("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"), 4, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), "Fry the potato fries until crispy and golden." },
                    { new Guid("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"), 5, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), "Serve immediately with tortilla chips or on its own." },
                    { new Guid("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"), 3, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), "Sear sausage and pork ribs in a skillet." },
                    { new Guid("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"), 5, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), "Bake for 30-40 minutes until golden brown." },
                    { new Guid("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"), 2, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Cook basmati rice until half-cooked and drain." },
                    { new Guid("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"), 4, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), "Rest chicken for a few minutes, then slice thinly." },
                    { new Guid("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"), 3, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), "Spoon mashed potato and cheese filling onto each circle." },
                    { new Guid("5122c450-7627-47f4-a1cd-aa2fe8773ebf"), 2, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Grill pork until fully cooked and slightly charred." },
                    { new Guid("53774383-64e6-4fc6-a307-3316e2f2527d"), 5, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Assemble burgers with lettuce, patties, and toppings of choice." },
                    { new Guid("53c53fa8-b7c7-47aa-8bd4-6880cee51f01"), 7, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Let the pizza cool for at least 5 minutes and enjoy!" },
                    { new Guid("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"), 2, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), "Heat beef broth and bring to a gentle boil." },
                    { new Guid("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"), 5, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), "Serve over egg noodles or rice." },
                    { new Guid("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"), 5, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), "Top with béchamel sauce and bake for 30-40 minutes." },
                    { new Guid("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"), 3, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Slice the duck into thin pieces." },
                    { new Guid("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"), 1, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), "Mix flour, egg, and water to form a dough. Knead until smooth." },
                    { new Guid("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"), 4, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), "Toss everything together gently." },
                    { new Guid("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"), 1, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), "Melt butter in a skillet over medium heat." },
                    { new Guid("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"), 2, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), "Sauté onions in a skillet until translucent." },
                    { new Guid("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"), 5, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), "Bake for 35-40 minutes, then let rest before serving." },
                    { new Guid("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"), 1, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), "Dissolve yeast in warm milk and let it activate." },
                    { new Guid("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"), 4, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Add fresh salmon and roll tightly." },
                    { new Guid("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"), 4, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), "Shape into croissants and let them proof until doubled." },
                    { new Guid("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"), 1, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), "Chop cabbage and sprinkle with salt. Let it sit for 2 hours." },
                    { new Guid("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"), 3, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), "Add sliced red onion and cilantro to the marinated fish." },
                    { new Guid("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"), 3, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), "Fry the fish in hot oil until golden brown." },
                    { new Guid("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"), 1, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), "Mix yogurt, garlic, cumin, and olive oil to create marinade." },
                    { new Guid("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"), 4, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), "Layer noodles, ricotta, beef, and mozzarella in a baking dish." },
                    { new Guid("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"), 5, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Assemble pancakes with duck, scallions, and serve." },
                    { new Guid("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"), 4, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), "Combine meats with cooked beans and simmer." },
                    { new Guid("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"), 4, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), "Stir in sour cream and simmer for 5 minutes." },
                    { new Guid("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"), 5, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), "Serve with basmati rice or naan bread." },
                    { new Guid("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"), 2, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), "Add chicken and cook until browned." },
                    { new Guid("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"), 5, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Serve with flatbread, yogurt, and fresh vegetables." },
                    { new Guid("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"), 5, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), "Boil in salted water for 5-7 minutes, then serve warm." },
                    { new Guid("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"), 2, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Shape the mixture into long, thin patties or onto skewers." },
                    { new Guid("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"), 1, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), "Heat oil in a deep fryer or heavy skillet." },
                    { new Guid("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"), 2, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), "Sauté onions and mushrooms in the same pan." },
                    { new Guid("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"), 5, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Fluff rice and serve hot with raita." },
                    { new Guid("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"), 1, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), "Soak black beans in water overnight." },
                    { new Guid("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"), 2, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), "Mix flour, sugar, salt, and milk mixture into a dough." },
                    { new Guid("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"), 1, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), "Preheat the oven to 350°F (175°C)." },
                    { new Guid("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"), 3, new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), "Stir in tomato puree and heavy cream." },
                    { new Guid("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"), 5, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), "Serve with pita and your favorite toppings." },
                    { new Guid("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"), 3, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), "Add thinly sliced beef to the hot broth." },
                    { new Guid("7cc01c97-66e0-40e3-9e0b-67cb7e5bba8c"), 2, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Whisk until eggs form into a foam-like white texture." },
                    { new Guid("7d465672-a6a1-4981-af70-6f3d9754370a"), 3, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Chop grilled pork into bite-sized pieces." },
                    { new Guid("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"), 2, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), "Let the fish marinate in the lime juice for 10 minutes." },
                    { new Guid("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"), 5, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), "Ferment at room temperature for 3-5 days, then refrigerate." },
                    { new Guid("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"), 3, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), "Cook ground lamb with diced tomatoes and season to taste." },
                    { new Guid("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"), 1, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), "Preheat oven to 375°F (190°C)." },
                    { new Guid("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"), 5, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), "Bake at 400°F (200°C) until golden brown and flaky." },
                    { new Guid("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"), 1, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), "Preheat oven to 375°F (190°C)." },
                    { new Guid("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"), 3, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), "Add beef back into the pan and stir in beef broth." },
                    { new Guid("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"), 2, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), "Marinate chicken in the mixture for at least 2 hours." },
                    { new Guid("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"), 4, new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), "Combine cooked noodles and broth in a bowl." },
                    { new Guid("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"), 1, new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), "In a bowl, combine fish and lime juice." },
                    { new Guid("96e0bcb2-49f6-4745-8125-5c63e136f5b7"), 5, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Serve hot with lime wedges and crushed peanuts." },
                    { new Guid("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"), 4, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Cook kebabs for 3-4 minutes on each side until fully cooked." },
                    { new Guid("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"), 2, new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), "Cook lasagna noodles according to package instructions." },
                    { new Guid("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"), 3, new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), "Grill chicken on medium-high heat for about 5-7 minutes per side." },
                    { new Guid("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"), 4, new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), "Transfer the mixture to a greased baking dish." },
                    { new Guid("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"), 3, new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), "Fold butter into the dough and roll out several times." },
                    { new Guid("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"), 4, new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), "Layer eggplants and lamb mixture in a baking dish." },
                    { new Guid("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"), 2, new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), "Roll out dough and cut into circles using a cookie cutter." },
                    { new Guid("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"), 5, new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), "Serve fish and chips together with tartar sauce." },
                    { new Guid("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"), 3, new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), "Mix cabbage with chili flakes, garlic, and water to create a paste." },
                    { new Guid("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"), 1, new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), "Cook beef in a pan until browned, then set aside." },
                    { new Guid("a1d3bbaf-1132-4111-b558-2e027fab8926"), 1, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Crack eggs and add to mixing bowl." },
                    { new Guid("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"), 1, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Shape ground beef into four patties." },
                    { new Guid("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"), 2, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Cook shrimp in a hot wok until pink, then set aside." },
                    { new Guid("a8d91f07-ba9d-4bc2-a648-3e19e2863559"), 1, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Marinate pork in adobo sauce for 4 hours." },
                    { new Guid("aa70a518-abf1-40d5-b54f-13863ef82212"), 1, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Cook sushi rice and season with rice vinegar." },
                    { new Guid("b6790a8b-3c8a-4905-849b-d80ca468096f"), 3, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Layer chicken and rice in a pot, adding fried onions." },
                    { new Guid("bc6b146f-9f96-4e1f-8cc0-26b139d5ef1a"), 6, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place back into the over for 12-15 minutes." },
                    { new Guid("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"), 3, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Spread rice evenly on the nori, leaving an edge." },
                    { new Guid("c915df33-f7c6-4f55-ae59-9b8d1e36d446"), 4, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Stir in shrimp and bean sprouts." },
                    { new Guid("d0f47451-500b-45b5-bfdd-610c268e815b"), 3, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Place cheddar cheese slices on patties to melt." },
                    { new Guid("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"), 1, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Combine ground lamb, grated onion, cumin, and salt in a bowl." },
                    { new Guid("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"), 4, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Spread hoisin sauce on the pancakes." },
                    { new Guid("d9eac06b-58d7-41c2-b6db-6d14e98e3914"), 1, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Soak rice noodles in warm water until softened." },
                    { new Guid("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"), 2, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Roast the duck in the oven at 375°F until crispy." },
                    { new Guid("dbb31e0c-0758-40a2-a7fb-d7e2499befa0"), 3, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Add arrowroot starch to mixing bowl and other spices of your choosing." },
                    { new Guid("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"), 3, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Add soaked noodles to the wok with Pad Thai sauce." },
                    { new Guid("e662eb34-f212-424e-a5c5-186954c01f4a"), 5, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Layer the sauce, then the cheese and lastly the toppings." },
                    { new Guid("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"), 1, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Clean and dry the duck thoroughly." },
                    { new Guid("ebc08345-ecbc-43cc-a371-ed082f332976"), 1, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Marinate chicken with yogurt and spices for 2 hours." },
                    { new Guid("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"), 3, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Preheat grill or grill pan to medium-high heat." },
                    { new Guid("f7542ebf-4f93-4556-93ee-8a2184a7fddc"), 4, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Warm tortillas on a skillet or grill." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeartedPlaylists_PlaylistId",
                table: "HeartedPlaylists",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_HeartedPlaylists_UserId_PlaylistId",
                table: "HeartedPlaylists",
                columns: new[] { "UserId", "PlaylistId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeartedRecipes_RecipeId",
                table: "HeartedRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_HeartedRecipes_UserId_RecipeId",
                table: "HeartedRecipes",
                columns: new[] { "UserId", "RecipeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistRecipes_RecipeId",
                table: "PlaylistRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_FullSlug",
                table: "Playlists",
                column: "FullSlug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RecipeId",
                table: "Ratings",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CountryId",
                table: "Recipes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_PlaylistId",
                table: "VisibilityReviews",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_RecipeId",
                table: "VisibilityReviews",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_ReviewedById",
                table: "VisibilityReviews",
                column: "ReviewedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HeartedPlaylists");

            migrationBuilder.DropTable(
                name: "HeartedRecipes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "PlaylistRecipes");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "VisibilityReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
