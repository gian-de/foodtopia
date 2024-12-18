using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class MakeUserIdNullable : Migration
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
                    table.UniqueConstraint("AK_Countries_Name", x => x.Name);
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
                    CountryId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("05d7a713-e61c-4ab7-90be-6b1bb2509089"), "images/flags/ukraine.svg", "Ukraine" },
                    { new Guid("07867f2a-7d5e-480e-a4e5-7dd1186caf2a"), "images/flags/brazil.svg", "Brazil" },
                    { new Guid("09d4927f-d14f-410b-b720-778472b5d936"), "images/flags/monaco.svg", "Monaco" },
                    { new Guid("0a7d25bf-ef47-47f4-9d47-2f6a962ad381"), "images/flags/spain.svg", "Spain" },
                    { new Guid("0e2220a1-a387-485a-abb6-81d228fda70b"), "images/flags/algeria.svg", "Algeria" },
                    { new Guid("116f260f-1d41-4533-b174-190924d613bc"), "images/flags/india.svg", "India" },
                    { new Guid("12955bd6-5191-4a47-8ceb-f2bcc3755672"), "images/flags/canada.svg", "Canada" },
                    { new Guid("1407e08d-adc4-4bd0-b90a-a368ef264455"), "images/flags/poland.svg", "Poland" },
                    { new Guid("1781cc5f-844f-4b32-aa3d-15f4094aa6b7"), "images/flags/turkey.svg", "Turkey" },
                    { new Guid("18355537-d564-4e2d-9028-4ab5fd4d0663"), "images/flags/ghana.svg", "Ghana" },
                    { new Guid("19ec75dd-2522-4af2-9169-3cf1ebd79b84"), "images/flags/netherlands.svg", "Netherlands" },
                    { new Guid("255fd803-184a-4df6-bf0e-73d0ded3b80e"), "images/flags/argentina.svg", "Argentina" },
                    { new Guid("27f11b00-efca-4c71-8921-8097a6304aa9"), "images/flags/azerbaijan.svg", "Azerbaijan" },
                    { new Guid("2839f714-ae56-48bf-85a1-91c2f9044ea9"), "images/flags/russia.svg", "Russia" },
                    { new Guid("29b3c0f0-4c2f-49b5-b0c8-6ce426444f42"), "images/flags/bahamas.svg", "Bahamas" },
                    { new Guid("2bca4877-4d27-4138-8a04-3d10614b4de8"), "images/flags/fiji.svg", "Fiji" },
                    { new Guid("2e2b57fa-d5cd-4bce-ad2b-6bc94c15b9f4"), "images/flags/trinidad&tobago.svg", "Trinidad & Tobago" },
                    { new Guid("2fca22ea-bbc0-499b-92f2-5384ba2ea61b"), "images/flags/afghanistan.svg", "Afghanistan" },
                    { new Guid("350bdba7-99a7-4d7e-852d-2d1453a1ed53"), "images/flags/bolivia.svg", "Bolivia" },
                    { new Guid("3c9434d1-1884-4c00-817c-f181c3c3979f"), "images/flags/japan.svg", "Japan" },
                    { new Guid("409c302a-57e7-4714-8b46-41c5cd187943"), "images/flags/serbia.svg", "Serbia" },
                    { new Guid("49d83e81-2b57-42f1-9ccb-59c8649289c4"), "images/flags/belgium.svg", "Belgium" },
                    { new Guid("49fe25ac-6e3e-47be-9ee3-b00715623d78"), "images/flags/south_africa.svg", "South Africa" },
                    { new Guid("4d617cd9-dc30-4980-ba34-a6ef92d71305"), "images/flags/philippines.svg", "Philippines" },
                    { new Guid("517c7852-34d4-4c17-9c9f-380d0ad58b0d"), "images/flags/kosovo.svg", "Kosovo" },
                    { new Guid("56854093-8823-4c5f-ae57-ab3f1c23bd05"), "images/flags/iceland.svg", "Iceland" },
                    { new Guid("597e4e1c-8aab-4c16-933c-6f06ffc4c677"), "images/flags/armenia.svg", "Armenia" },
                    { new Guid("5a39dcb5-e72a-46b1-9776-579b283947fe"), "images/flags/chile.svg", "Chile" },
                    { new Guid("5c182102-9ba9-4f39-818a-024981d34f00"), "images/flags/el_salvador.svg", "El Salvador" },
                    { new Guid("62d0987a-ff47-4279-84fb-b9c7b0d27db7"), "images/flags/colombia.svg", "Colombia" },
                    { new Guid("65be717d-d2fb-4ea6-b894-99e9f0091a49"), "images/flags/portugal.svg", "Portugal" },
                    { new Guid("68d5a5c9-4c5c-4cbb-a2b5-c4f28ed5ba50"), "images/flags/china.svg", "China" },
                    { new Guid("6a65cf6c-fe8b-4a96-bf8b-dde132c01652"), "images/flags/antigua_barbuda.svg", "Antigua & Barbuda" },
                    { new Guid("6d75dfd4-e735-4b52-90f0-11db4026762b"), "images/flags/israel.svg", "Israel" },
                    { new Guid("70f350bf-721a-45aa-9512-e3b27d64599f"), "images/flags/vietnam.svg", "Vietnam" },
                    { new Guid("744f2c22-0cc7-4b61-ae9f-1ce6e4b432a1"), "images/flags/france.svg", "France" },
                    { new Guid("76c55869-0e8b-4804-8b67-dfecaf56b846"), "images/flags/kuwait.svg", "Kuwait" },
                    { new Guid("785dbf4a-e576-4d45-b33f-d9be9542675d"), "images/flags/uk.svg", "UK" },
                    { new Guid("7c39b830-2f46-49ac-b7ce-4cb16207046d"), "images/flags/sweden.svg", "Sweden" },
                    { new Guid("807f96fe-858d-4009-a35a-e35d4074c193"), "images/flags/dominican_republic.svg", "Dominican Republic" },
                    { new Guid("8692f9e9-363c-445e-83f5-bf6c6231154c"), "images/flags/thailand.svg", "Thailand" },
                    { new Guid("8cde6ca5-02d5-4da5-9a06-06fc361233db"), "images/flags/venezuela.svg", "Venezuela" },
                    { new Guid("8fa6fc4f-c00b-4fb7-ae57-fe7841761884"), "images/flags/albania.svg", "Albania" },
                    { new Guid("91a34f35-6749-4163-b4a3-7a98fa48618a"), "images/flags/panama.svg", "Panama" },
                    { new Guid("92cfe5b1-7d66-4596-a030-b7110e3df687"), "images/flags/uae.svg", "UAE" },
                    { new Guid("94d63849-bc52-491c-9cc1-4b381e92fb3a"), "images/flags/cameroon.svg", "Cameroon" },
                    { new Guid("99c82d1b-f546-48a3-99b6-b80ca7b42c96"), "images/flags/costa_rica.svg", "Costa Rica" },
                    { new Guid("9ed2ea24-df1e-41d4-8687-a07ae10b4f84"), "images/flags/jamaica.svg", "Jamaica" },
                    { new Guid("a70e2845-69cb-4def-a566-af8a3a4cf79e"), "images/flags/qatar.svg", "Qatar" },
                    { new Guid("ac0b2046-ebf5-4ee2-ad0f-6a16a0bed644"), "images/flags/egypt.svg", "Egypt" },
                    { new Guid("b41e0122-f06f-4e71-9d71-4d5b5ed9e60c"), "images/flags/peru.svg", "Peru" },
                    { new Guid("ba982e45-1dcd-4f0a-8dfa-d8ae817d8f3f"), "images/flags/saudi_arabia.svg", "Saudi Arabia" },
                    { new Guid("bad06bd8-61a7-405a-adfd-5f936c6cfc76"), "images/flags/denmark.svg", "Denmark" },
                    { new Guid("bbec73c1-7ebb-4863-a76d-33485fa86345"), "images/flags/nigeria.svg", "Nigeria" },
                    { new Guid("befb4bb8-04c7-4ba0-983d-ac4719063689"), "images/flags/morocco.svg", "Morocco" },
                    { new Guid("bf489e3b-36ac-4fde-87b4-3b16bf909569"), "images/flags/ecuador.svg", "Ecuador" },
                    { new Guid("c4866ece-fbc6-4be7-87d8-7c2bcfe76316"), "images/flags/mexico.svg", "Mexico" },
                    { new Guid("c4a15fd5-edec-42ea-939e-26981eb24ceb"), "images/flags/palestine.svg", "Palestine" },
                    { new Guid("c4dbeccd-a4e8-4993-b372-5f74bcb41eed"), "images/flags/finland.svg", "Finland" },
                    { new Guid("c4f8b8f2-8fc4-43d5-bde2-b0e6f8af79d6"), "images/flags/south_korea.svg", "South Korea" },
                    { new Guid("cb5c7f72-a8e2-4a3c-8229-6858dfc740c7"), "images/flags/pakistan.svg", "Pakistan" },
                    { new Guid("ccd520bc-8a21-432a-94bf-1598d9c740ff"), "images/flags/angola.svg", "Angola" },
                    { new Guid("d167c871-d2ae-41d9-b10c-c516f1d84fb7"), "images/flags/australia.svg", "Australia" },
                    { new Guid("d62509d3-1bf3-4d4f-94ee-6f09d19d250e"), "images/flags/cuba.svg", "Cuba" },
                    { new Guid("df134ef8-3da0-4d5e-9798-b03c3c9a561a"), "images/flags/usa.svg", "USA" },
                    { new Guid("dfef74ad-e435-4f3a-b4bd-93912f1acc5d"), "images/flags/hungary.svg", "Hungary" },
                    { new Guid("e0cafa7a-8fe1-453c-a6d9-cf53d4dbc222"), "images/flags/italy.svg", "Italy" },
                    { new Guid("e26e315a-2117-42d8-8e93-000030491915"), "images/flags/andorra.svg", "Andorra" },
                    { new Guid("e4ffcaa8-8302-4bd2-869e-9bed049ecf22"), "images/flags/austria.svg", "Austria" },
                    { new Guid("ef5aefb0-d64f-477a-bcf4-0cd6db5e5181"), "images/flags/greece.svg", "Greece" },
                    { new Guid("f3025efc-b63c-4f04-96be-63fc1e398a6e"), "images/flags/croatia.svg", "Croatia" },
                    { new Guid("f519ccb2-80a7-4a43-bb3a-e969e1d401aa"), "images/flags/germany.svg", "Germany" },
                    { new Guid("f8732488-3859-4a12-ab84-0fb37b4f54bb"), "images/flags/norway.svg", "Norway" },
                    { new Guid("fd5cb089-fe28-4ca5-825c-56dfcbe4e7f8"), "images/flags/guatemala.svg", "Guatemala" },
                    { new Guid("fe2d3db0-e088-431c-bf87-54f571b95420"), "images/flags/ireland.svg", "Ireland" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Role", "Username" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "deleted@placeholder.com", "Deleted", true, "Deleted", "deleted", "none", "deleted" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CountryId", "DifficultyAverage", "DifficultyReviewCount", "HeartCount", "ImageUrl", "Name", "PublishedAt", "TasteAverage", "TasteReviewCount", "UserId" },
                values: new object[] { new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "USA", 0m, 0, 0, "images/recipes/low_calorie_pizza.jpg", "Low calorie pizza", new DateTime(2024, 12, 18, 12, 6, 44, 640, DateTimeKind.Utc).AddTicks(2260), 0m, 0, null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Measurement", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("3fe7ee1c-90a0-48ed-83fa-e6bed58d9715"), "cups", "Flour", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("5a348ad9-d468-4c33-b081-a90650f8c2a9"), "", "Egg", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("c37bed49-2246-4362-89be-c7ed09162da5"), "cup", "Sauce", 1m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Step" },
                values: new object[,]
                {
                    { new Guid("1760ab81-141b-4db6-974b-04f66907a597"), 4, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes." },
                    { new Guid("23d32871-5d19-406c-995c-0aef0905fb3e"), 6, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place back into the over for 12-15 minutes." },
                    { new Guid("2dd0172c-d2a2-450f-8776-1cc199c3951e"), 5, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Layer the sauce, then the cheese and lastly the toppings." },
                    { new Guid("b16f1311-dd43-44f6-976b-65ad4c959e20"), 2, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Whisk until eggs form into a foam-like white texture." },
                    { new Guid("c105b1a5-2def-4c87-8793-895321767db3"), 3, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Add arrowroot starch to mixing bowl and other spices of your choosing." },
                    { new Guid("c87e1ec0-f9a9-48d5-bd68-104869e7b5cb"), 7, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Let the pizza cool for at least 5 minutes and enjoy!" },
                    { new Guid("c9e6a26d-a292-4faa-b8fa-c4bbfa9fc20a"), 1, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Crack eggs and add to mixing bowl." }
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
                name: "IX_Recipes_CountryId",
                table: "Recipes",
                column: "CountryId");

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
