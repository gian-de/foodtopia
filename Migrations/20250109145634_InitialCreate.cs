using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
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
                columns: new[] { "Id", "ImagePath", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("00d039ac-65ba-4c88-8776-e66d80aeda59"), "images/flags/vietnam.svg", "Vietnam", "vietnam" },
                    { new Guid("01f4ac5c-11cb-46a3-b455-4c27c05cdca9"), "images/flags/guatemala.svg", "Guatemala", "guatemala" },
                    { new Guid("038605c3-9499-4205-a0ac-f71ef43b47b3"), "images/flags/algeria.svg", "Algeria", "algeria" },
                    { new Guid("0a34bbde-21c7-4746-8714-721a0c0597b3"), "images/flags/uk.svg", "UK", "united-kingdom" },
                    { new Guid("13488b4b-539a-40ca-a40b-bea362bdbd1b"), "images/flags/norway.svg", "Norway", "norway" },
                    { new Guid("16ddc3e7-9748-477e-b7c0-8d503b992e2e"), "images/flags/saudi_arabia.svg", "Saudi Arabia", "saudi-arabia" },
                    { new Guid("18e8ff81-6234-4aa6-902e-69cefb26aca5"), "images/flags/finland.svg", "Finland", "finland" },
                    { new Guid("1d8a47a1-1130-4ad4-8f4d-4e3c300d89ec"), "images/flags/colombia.svg", "Colombia", "colombia" },
                    { new Guid("1dca600a-c5f0-45a9-be79-5e86b8b68f0e"), "images/flags/austria.svg", "Austria", "austria" },
                    { new Guid("20d93819-4e82-4eee-b56d-20f08d2e0c5b"), "images/flags/mexico.svg", "Mexico", "mexico" },
                    { new Guid("273719f6-22df-400b-99b8-6d499a7a2f9e"), "images/flags/nigeria.svg", "Nigeria", "nigeria" },
                    { new Guid("2ca071fb-0cd8-4962-b85c-7342f9353e43"), "images/flags/ukraine.svg", "Ukraine", "ukraine" },
                    { new Guid("31f03777-3e94-402d-b4eb-c7c6e9903108"), "images/flags/chile.svg", "Chile", "chile" },
                    { new Guid("33195fed-3b63-46fb-b49c-15f7caf6ed1c"), "images/flags/hungary.svg", "Hungary", "hungary" },
                    { new Guid("3a95d925-25cd-4073-bccb-78f58cc3fc4c"), "images/flags/denmark.svg", "Denmark", "denmark" },
                    { new Guid("3ddd41b8-7ba7-4945-9c00-0b496f0953af"), "images/flags/kosovo.svg", "Kosovo", "kosovo" },
                    { new Guid("413520ac-6f4b-45df-bd96-5e2aefed0be0"), "images/flags/japan.svg", "Japan", "japan" },
                    { new Guid("463671c5-fc34-4294-b600-92ced08b4a41"), "images/flags/croatia.svg", "Croatia", "croatia" },
                    { new Guid("48cb1fe1-dc53-4297-ab4c-d83b8515fbe5"), "images/flags/israel.svg", "Israel", "israel" },
                    { new Guid("4ffd1636-b9c1-47aa-b20e-0d02a5182348"), "images/flags/albania.svg", "Albania", "albania" },
                    { new Guid("5456e649-bf0a-4507-b60d-251aa750cc4c"), "images/flags/palestine.svg", "Palestine", "palestine" },
                    { new Guid("597558ac-0f1c-4eeb-8751-71bf881d3d78"), "images/flags/cameroon.svg", "Cameroon", "cameroon" },
                    { new Guid("59784003-0163-470e-8238-e63c2be3ebb0"), "images/flags/china.svg", "China", "china" },
                    { new Guid("63a80847-172c-41e9-b35f-40d8c1237ab1"), "images/flags/pakistan.svg", "Pakistan", "pakistan" },
                    { new Guid("63dee376-5006-44fc-a763-730cd9bbff8a"), "images/flags/canada.svg", "Canada", "canada" },
                    { new Guid("65284b4a-374a-4144-9509-3598b4c270fd"), "images/flags/peru.svg", "Peru", "peru" },
                    { new Guid("6e12219e-44e5-495a-8fbc-d0f74848014b"), "images/flags/bahamas.svg", "Bahamas", "bahamas" },
                    { new Guid("732f69b7-13c1-449c-ac71-502bb36512e8"), "images/flags/india.svg", "India", "india" },
                    { new Guid("76009c1d-0de7-44e7-a8ca-bd9d6a0a816b"), "images/flags/italy.svg", "Italy", "italy" },
                    { new Guid("779f2d29-d9da-46d8-a78f-e6ca5a393a5b"), "images/flags/venezuela.svg", "Venezuela", "venezuela" },
                    { new Guid("77bce5a9-8530-4a4c-92bf-1b922efaf625"), "images/flags/turkey.svg", "Turkey", "turkey" },
                    { new Guid("7a6b2878-a943-4d1f-b7ab-458caeb158e8"), "images/flags/ireland.svg", "Ireland", "ireland" },
                    { new Guid("7b1b2a17-156a-413d-b57e-c49fead48e22"), "images/flags/ghana.svg", "Ghana", "ghana" },
                    { new Guid("7f8cc654-9cea-46c9-af92-ae1ee272677a"), "images/flags/philippines.svg", "Philippines", "philippines" },
                    { new Guid("802f65b6-6c64-494f-a1eb-802d5cc594d6"), "images/flags/portugal.svg", "Portugal", "portugal" },
                    { new Guid("8249285d-6244-4de6-a79a-55ca989bed88"), "images/flags/afghanistan.svg", "Afghanistan", "afghanistan" },
                    { new Guid("8549307c-e92b-4c90-899c-35e67eb02732"), "images/flags/monaco.svg", "Monaco", "monaco" },
                    { new Guid("86c98c7f-35f2-44e7-b44c-a2603cfd17c2"), "images/flags/kuwait.svg", "Kuwait", "kuwait" },
                    { new Guid("86e7903b-1f81-4534-8f6a-1cb6b7ad5782"), "images/flags/serbia.svg", "Serbia", "serbia" },
                    { new Guid("8b8aab18-f234-4919-b233-e27e6485811e"), "images/flags/australia.svg", "Australia", "australia" },
                    { new Guid("8bd372dc-061f-4bfa-ae4e-53b726330f1b"), "images/flags/azerbaijan.svg", "Azerbaijan", "azerbaijan" },
                    { new Guid("8c7a2ce6-9f2f-4bdd-83d6-b24801310760"), "images/flags/germany.svg", "Germany", "germany" },
                    { new Guid("8ccb0c9f-5ade-4e99-b4e7-9e9809d20682"), "images/flags/poland.svg", "Poland", "poland" },
                    { new Guid("8ed7b64f-1a56-4d9d-ba35-fd2f83047f1e"), "images/flags/netherlands.svg", "Netherlands", "netherlands" },
                    { new Guid("8ffc8e08-3a94-4da1-a504-1cd3cb08eff5"), "images/flags/france.svg", "France", "france" },
                    { new Guid("902d5369-17e0-45b9-9367-9ced0cedeb6c"), "images/flags/angola.svg", "Angola", "angola" },
                    { new Guid("962dea70-2f53-4753-8ea4-52cbb31d4175"), "images/flags/brazil.svg", "Brazil", "brazil" },
                    { new Guid("96b22919-3f04-43b3-a4c2-f9691e523936"), "images/flags/jamaica.svg", "Jamaica", "jamaica" },
                    { new Guid("99e67deb-d8aa-48cf-b011-afc6e37ad21d"), "images/flags/costa_rica.svg", "Costa Rica", "costa-rica" },
                    { new Guid("9b880c26-de06-41b1-8579-e31b7c70ebef"), "images/flags/cuba.svg", "Cuba", "cuba" },
                    { new Guid("9c738db6-b1b0-4367-8173-30f60b8550fb"), "images/flags/qatar.svg", "Qatar", "qatar" },
                    { new Guid("9e42a217-8054-4cee-8b7a-087fe95a79f9"), "images/flags/argentina.svg", "Argentina", "argentina" },
                    { new Guid("9eb0882c-e56c-4a7e-8c03-e1997f1b787e"), "images/flags/iceland.svg", "Iceland", "iceland" },
                    { new Guid("a05f52e8-51f7-4626-8329-feb7f5cb5249"), "images/flags/south_korea.svg", "South Korea", "south-korea" },
                    { new Guid("a308e22f-bf3c-4787-97ba-ed2baf1db7ba"), "images/flags/armenia.svg", "Armenia", "armenia" },
                    { new Guid("a6ddb27c-0eba-4c64-b926-95a839ce03e8"), "images/flags/dominican_republic.svg", "Dominican Republic", "dominica-republic" },
                    { new Guid("b61f5b0d-a6b5-4189-9af2-3752028727ed"), "images/flags/thailand.svg", "Thailand", "thailand" },
                    { new Guid("beeb07ec-a1f2-474f-aaca-67e544db05b3"), "images/flags/antigua_barbuda.svg", "Antigua & Barbuda", "antigua-and-barbuda" },
                    { new Guid("bf94588a-8cb3-46d9-a17e-5878cdafe268"), "images/flags/panama.svg", "Panama", "panama" },
                    { new Guid("c28bd523-8245-46bf-83fa-8c1e95a764e4"), "images/flags/trinidad&tobago.svg", "Trinidad & Tobago", "trinidad-and-tobago" },
                    { new Guid("c3dbc242-ab34-4c47-9707-a2195187915e"), "images/flags/south_africa.svg", "South Africa", "south-africa" },
                    { new Guid("c7be5a6f-4a9a-4da4-8910-7e3f9355f3cb"), "images/flags/egypt.svg", "Egypt", "egypt" },
                    { new Guid("cf88669c-827f-463a-a6cf-75cb10faa93b"), "images/flags/el_salvador.svg", "El Salvador", "el-salvador" },
                    { new Guid("d37b096d-86dc-4deb-ba2a-ed067b1d3cc2"), "images/flags/russia.svg", "Russia", "russia" },
                    { new Guid("da874b21-e67c-4560-993b-e61c4ea282fd"), "images/flags/uae.svg", "UAE", "united-arab-emirates" },
                    { new Guid("dfe7829b-4d19-4db5-ae73-d896709e3d33"), "images/flags/spain.svg", "Spain", "spain" },
                    { new Guid("e60e384e-a7cf-411a-9362-76d0aeec619b"), "images/flags/belgium.svg", "Belgium", "belgium" },
                    { new Guid("eb014b54-2b8e-4ce8-ac17-d0b14c60e1ae"), "images/flags/greece.svg", "Greece", "greece" },
                    { new Guid("f1269377-754b-437e-b8e2-3c3b26d160d7"), "images/flags/fiji.svg", "Fiji", "fiji" },
                    { new Guid("f30dd8f5-4c4a-4eb4-b28d-0e559b1dea75"), "images/flags/sweden.svg", "Sweden", "sweden" },
                    { new Guid("f3e6e63c-a7a0-4090-9326-ccd5e2dc5008"), "images/flags/morocco.svg", "Morocco", "morocco" },
                    { new Guid("f79788fc-c9a9-4f15-9ea3-ce375205d15c"), "images/flags/andorra.svg", "Andorra", "andorra" },
                    { new Guid("f9899140-d549-4c9e-8d05-e12b5ea83623"), "images/flags/ecuador.svg", "Ecuador", "ecuador" },
                    { new Guid("fbbee294-de2d-4f6a-93ab-b6df3853e64a"), "images/flags/bolivia.svg", "Bolivia", "bolivia" },
                    { new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), "images/flags/usa.svg", "USA", "usa" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Role", "Username" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "deleted@placeholder.com", "Deleted", true, "Deleted", "deleted", "none", "deleted" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CountryId", "DifficultyAverage", "DifficultyReviewCount", "HeartCount", "ImageUrl", "Name", "PublishedAt", "TasteAverage", "TasteReviewCount", "UserId" },
                values: new object[] { new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), 0m, 0, 0, "images/recipes/low_calorie_pizza.jpg", "Low calorie pizza", new DateTime(2025, 1, 9, 14, 56, 34, 295, DateTimeKind.Utc).AddTicks(6180), 0m, 0, null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Measurement", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("624aaf79-8a0a-4e07-b7ae-3228ac6b8bd9"), "cups", "Flour", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("d3d4f946-ad13-4c2b-960e-9cea2cc38329"), "cup", "Sauce", 1m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("e393ee0f-750e-4073-b3d9-e63bf19ab5fe"), "", "Egg", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Step" },
                values: new object[,]
                {
                    { new Guid("5051f18a-8618-4beb-b97b-e8e624ab2200"), 2, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Whisk until eggs form into a foam-like white texture." },
                    { new Guid("60c30f84-d112-4c80-9837-e97600a43434"), 1, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Crack eggs and add to mixing bowl." },
                    { new Guid("95a60176-994b-42f7-a5e0-10dafa06da2f"), 3, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Add arrowroot starch to mixing bowl and other spices of your choosing." },
                    { new Guid("b4308569-9e4e-43c4-b211-329eadf3e62b"), 4, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes." },
                    { new Guid("d0468a9c-b3ef-42f8-823a-6fb4adb003ec"), 6, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place back into the over for 12-15 minutes." },
                    { new Guid("e45c3910-4120-4c3f-a73c-9fd7841ffbab"), 7, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Let the pizza cool for at least 5 minutes and enjoy!" },
                    { new Guid("ee9d51cd-6663-4fe0-8219-c4aa83967adc"), 5, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Layer the sauce, then the cheese and lastly the toppings." }
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
