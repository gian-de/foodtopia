using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(28)", maxLength: 28, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    HeartCount = table.Column<int>(type: "integer", nullable: false),
                    TasteAverage = table.Column<decimal>(type: "numeric", nullable: false),
                    DifficultyAverage = table.Column<decimal>(type: "numeric", nullable: false),
                    TasteReviewCount = table.Column<int>(type: "integer", nullable: false),
                    DifficultyReviewCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CountryDetailsId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Countries_CountryDetailsId",
                        column: x => x.CountryDetailsId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                        name: "FK_HeartedRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeartedRecipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    Quantity = table.Column<decimal>(type: "numeric", nullable: false)
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
                    Step = table.Column<string>(type: "character varying(600)", maxLength: 600, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
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
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TasteRating = table.Column<decimal>(type: "numeric", nullable: false),
                    DifficultyRating = table.Column<decimal>(type: "numeric", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("07ee9280-69ba-4142-a263-35d20e3161d1"), "images/flags/", "Saudi Arabia" },
                    { new Guid("09ca6521-384e-4b6d-a689-5f5012f11919"), "images/flags/", "Antigua & Barbuda" },
                    { new Guid("09d0ab82-09f0-40ee-8b29-2c2319d29d75"), "images/flags/", "Barbados" },
                    { new Guid("0a745341-d82d-43a4-a6f3-09252694aaf7"), "images/flags/", "Russia" },
                    { new Guid("0bfb445a-879c-4a6f-b138-857d8a5745d1"), "images/flags/", "Poland" },
                    { new Guid("0d1ae416-d9f2-4458-8350-ec87b452b081"), "images/flags/", "Dominican Republic" },
                    { new Guid("13a22fad-69ab-4f3f-b428-fafd7e261a84"), "images/flags/", "South Korea" },
                    { new Guid("150f5f8a-cd01-435c-8cf2-723e18f3bd10"), "images/flags/", "St. Kitts & Nevis" },
                    { new Guid("15280df4-afa5-4180-a888-32827c8b6a5c"), "images/flags/", "Norway" },
                    { new Guid("15341fbf-9191-407b-b72f-f642e1a813c1"), "images/flags/", "Chile" },
                    { new Guid("158e4d2e-c671-4ca0-b59b-10245eefe159"), "images/flags/", "Ghana" },
                    { new Guid("1659ba44-39b4-45a4-acaa-6f73bbc635ed"), "images/flags/", "Belgium" },
                    { new Guid("166a0e70-f3a4-4eb1-8137-67196574afbe"), "images/flags/", "Malaysia" },
                    { new Guid("1a871b1e-ecbc-4628-9b10-6f9f8389e5f9"), "images/flags/", "Fiji" },
                    { new Guid("1b537870-67ef-4a3a-b329-76ac59385ea7"), "images/flags/", "Angola" },
                    { new Guid("1dc6fc92-b974-4254-b44f-3751b9e2ff15"), "images/flags/", "Guatemala" },
                    { new Guid("1ea87b72-f6dc-4ae7-8178-680a00e35209"), "images/flags/", "India" },
                    { new Guid("2700574b-325d-4729-bf51-34181a7fc9a5"), "images/flags/", "Denmark" },
                    { new Guid("2861d9eb-af3b-4b2b-a1e9-457928cbd382"), "images/flags/", "UK" },
                    { new Guid("28f70330-06c0-4145-819c-0cdbf2154e73"), "images/flags/", "Ukraine" },
                    { new Guid("29f6b556-3bbd-450f-a665-c7932cde5072"), "images/flags/", "Germany" },
                    { new Guid("2b676304-23f9-4091-b3b5-cc4db007c6e2"), "images/flags/", "Kuwait" },
                    { new Guid("31c49f1a-58e2-475b-b7c0-f24060e11f1f"), "images/flags/", "Argentina" },
                    { new Guid("35320a7c-2871-48fb-803b-8605e8c13f7a"), "images/flags/", "Albania" },
                    { new Guid("36f49998-c975-4a20-9b10-10f31ff163c5"), "images/flags/", "Thailand" },
                    { new Guid("393d2ef0-1c9e-46e2-bc5e-8659d772f610"), "images/flags/", "Monaco" },
                    { new Guid("3ab0fb8d-ec84-4459-bc8e-d456e65fe307"), "images/flags/", "Vietnam" },
                    { new Guid("3c0e48c9-f620-42db-a674-411690c12682"), "images/flags/", "Belize" },
                    { new Guid("3d6d8e11-1494-4c97-afb4-25915f3b0bf3"), "images/flags/", "Australia" },
                    { new Guid("3eacea80-41db-4ccd-9ecf-7a4610d0bfc1"), "images/flags/", "Peru" },
                    { new Guid("54ffa9e4-4da7-48b8-bc54-ceb3edb6666f"), "images/flags/", "Italy" },
                    { new Guid("57e9c9d8-7875-4b03-9cda-4bd56910a2d1"), "images/flags/", "Morocco" },
                    { new Guid("5c5a5cdc-b4c3-410b-9a32-b51299dcd8ef"), "images/flags/", "Kosovo" },
                    { new Guid("5dec25ff-c37e-411a-925d-87a13c22865c"), "images/flags/", "Andorra" },
                    { new Guid("5e3a7296-2e15-4ef0-8673-1b1519cafe1e"), "images/flags/", "Iceland" },
                    { new Guid("603c264d-202e-451a-9bb0-a1090e372a26"), "images/flags/", "Bolivia" },
                    { new Guid("614353d6-65e9-4d00-89d1-223db9cd1d74"), "images/flags/", "Turkey" },
                    { new Guid("62431615-841e-4c4d-a6c7-8d26ed889210"), "images/flags/", "Venezuela" },
                    { new Guid("65693655-2028-4828-86f2-4b3d53adc629"), "images/flags/", "Nigeria" },
                    { new Guid("6cc7411d-aa6c-4db6-86c2-8526691f0a3b"), "images/flags/", "Japan" },
                    { new Guid("6e5249f6-24d8-4c91-81ec-8edd4977f1e1"), "images/flags/", "Algeria" },
                    { new Guid("72c2be61-ef49-4a2e-b1d8-29051ebc84ee"), "images/flags/", "Azerbaijan" },
                    { new Guid("74f5c018-bb88-4e4f-8bc5-30cda421229e"), "images/flags/", "Canada" },
                    { new Guid("7aacc2ab-d361-4bf9-a433-34e26085b924"), "images/flags/", "Ireland" },
                    { new Guid("819993b4-2608-4713-adae-f6dc31c96404"), "images/flags/", "Armenia" },
                    { new Guid("86a4c6cd-276a-427b-b18d-eb6ff1d02112"), "images/flags/", "Cuba" },
                    { new Guid("87656d76-e254-45d6-8f1f-0bbfb2cf66fe"), "images/flags/", "Greece" },
                    { new Guid("9483c8e7-c416-4e22-bc93-fae0a6d79040"), "images/flags/", "Bangladesh" },
                    { new Guid("94d36556-0b7b-4651-8def-e10dd7690ae6"), "images/flags/", "El Salvador" },
                    { new Guid("9b55196d-e481-439f-a800-8d7b241cce15"), "images/flags/", "Afghanistan" },
                    { new Guid("9bbcb356-8d1c-43a9-a35e-574106dd3de4"), "images/flags/", "New Zealand" },
                    { new Guid("9bbd9235-2a37-4808-a01a-207686becf65"), "images/flags/", "Netherlands" },
                    { new Guid("a103d91f-c31e-4d4e-a90f-fe2de03f08d0"), "images/flags/", "Palestine" },
                    { new Guid("a125479c-8ceb-415d-b3cd-a2a787584020"), "images/flags/", "Jamaica" },
                    { new Guid("a1db2b32-b036-4beb-8e85-22a24abf1124"), "images/flags/", "Hungary" },
                    { new Guid("a387f335-32aa-4d67-a085-07e7e89d2f9f"), "images/flags/", "UAE" },
                    { new Guid("a5f1ce9d-eaab-4835-a7e8-931cc15b7ca1"), "images/flags/", "Croatia" },
                    { new Guid("ac09101e-0f9a-457c-b5c1-fb23f7b44f87"), "images/flags/", "Brazil" },
                    { new Guid("ac152e79-3387-4944-b741-2db9a047ee4a"), "images/flags/", "Trinidad & Tobago" },
                    { new Guid("b51eb071-9ae4-4155-b718-0fca506fa295"), "images/flags/", "Malta" },
                    { new Guid("b8237004-226f-4300-b37d-5aecc635eb02"), "images/flags/", "Finland" },
                    { new Guid("b964b7d1-5449-4015-a576-effb92367ceb"), "images/flags/", "South Africa" },
                    { new Guid("ba17c9d1-8dc5-46fa-a88b-8c28db1380ed"), "images/flags/", "Serbia" },
                    { new Guid("bc61ed18-2304-4fe6-b7ed-24549bf4b69d"), "images/flags/", "Bahamas" },
                    { new Guid("c43d2a02-229b-49c6-a247-778e600f4069"), "images/flags/", "Costa Rica" },
                    { new Guid("c5fe1053-9a7f-4dce-a18b-364afee2f5de"), "images/flags/", "Qatar" },
                    { new Guid("c9571bbf-8ede-4f04-9766-ca5cd510c975"), "images/flags/", "Ecuador" },
                    { new Guid("d0e7ae43-5b45-4220-9036-6f030943faf9"), "images/flags/", "Portugal" },
                    { new Guid("d28a0fab-65c7-4f86-98a2-68efaa1410ae"), "images/flags/", "Madagascar" },
                    { new Guid("d2eda5c7-748e-4c2f-b422-63226be1ffca"), "images/flags/", "Mexico" },
                    { new Guid("dd433e87-685e-4330-bfa7-33450c0bc56d"), "images/flags/", "USA" },
                    { new Guid("dfc255f1-8bc3-48e2-8cab-5cc0d9cc7e14"), "images/flags/", "Sweden" },
                    { new Guid("e1ae35f7-b39c-46ce-8963-e4837c512244"), "images/flags/", "Austria" },
                    { new Guid("e537ac8f-beca-4b5a-968c-d2fb7d01112e"), "images/flags/", "Maldives" },
                    { new Guid("e6e239f9-e494-48ab-bba8-e961b155a37c"), "images/flags/", "Israel" },
                    { new Guid("e7a46b4c-a4d2-41f0-9e7a-109c35308ee4"), "images/flags/", "Lithuania" },
                    { new Guid("e85d4770-d29b-4d7d-af22-df98c77e792c"), "images/flags/", "Nepal" },
                    { new Guid("eb6c92c3-53d9-4b59-b821-0c5fb010bbfd"), "images/flags/", "Egypt" },
                    { new Guid("ec55154f-656d-4a1d-bd98-8de616570ea1"), "images/flags/", "Philippines" },
                    { new Guid("f44d3041-ac29-424c-84e5-4aa2a695e3d6"), "images/flags/", "Spain" },
                    { new Guid("f473b9d1-aa2c-427e-bc95-245b3108c0be"), "images/flags/", "Panama" },
                    { new Guid("f67f1c9f-9a42-43d4-a27e-09b45fd30125"), "images/flags/", "Cameroon" },
                    { new Guid("fbb45dcd-a086-4f72-ae82-18bc840c6f12"), "images/flags/", "France" },
                    { new Guid("fc5557e2-e595-4b67-b6a8-64f1dbfc1444"), "images/flags/", "Pakistan" },
                    { new Guid("fcedc254-c22c-43af-8d9a-68db9d5496ec"), "images/flags/", "Colombia" },
                    { new Guid("fd5bdb39-365b-4338-adb1-af2e9d20b4f3"), "images/flags/", "China" }
                });

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
                name: "IX_Ratings_RecipeId",
                table: "Ratings",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CountryDetailsId",
                table: "Recipes",
                column: "CountryDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "\"Email\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "\"Username\" IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartedRecipes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
