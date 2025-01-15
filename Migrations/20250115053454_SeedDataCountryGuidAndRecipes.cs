using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCountryGuidAndRecipes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CountryId", "DifficultyAverage", "DifficultyReviewCount", "ImageUrl", "Name", "PublishedAt", "TasteAverage", "TasteReviewCount", "UserId" },
                values: new object[,]
                {
                    { new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"), new Guid("4b9baef3-b816-49b3-817c-f26abe012942"), 0m, 0, "images/recipes/bobotie.jpg", "Bobotie", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"), new Guid("13e5d348-9fd9-4788-b33a-3ff80fd50ac1"), 0m, 0, "images/recipes/kimchi.jpg", "Kimchi", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), new Guid("fc61634e-ea99-43d5-9657-26745fc53530"), 0m, 0, "images/recipes/classic_cheeseburger.jpg", "Classic Cheeseburger", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550), 0m, 0, null },
                    { new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), new Guid("93a2792c-5349-4b14-abc2-b4781395c394"), 0m, 0, "images/recipes/pad_thai.jpg", "Pad Thai", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"), new Guid("05472a5f-5c4c-4afc-bed2-d60a5b668823"), 0m, 0, "images/recipes/fish_and_chips.jpg", "Fish and Chips", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), new Guid("f4eaf144-7d25-451f-886b-13805e41c0cf"), 0m, 0, "images/recipes/chicken_biryani.jpg", "Chicken Biryani", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550), 0m, 0, null },
                    { new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"), new Guid("6b600158-b511-44bd-8a52-d4c88a78a1ca"), 0m, 0, "images/recipes/pho.jpg", "Pho", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"), new Guid("7a5f9ebf-6d8e-4589-bbfb-d22739b1eb2b"), 0m, 0, "images/recipes/butter_chicken.jpg", "Butter Chicken", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), new Guid("e5336ea0-d112-4058-8360-de0ec32def0d"), 0m, 0, "images/recipes/peking_duck.jpg", "Peking Duck", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), new Guid("0898e080-716f-4413-91c4-e9c52c493834"), 0m, 0, "images/recipes/kebab.jpg", "Kebab", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"), new Guid("b6ab2925-6097-48cc-a7f7-d4ed8c2b256a"), 0m, 0, "images/recipes/moussaka.jpg", "Moussaka", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null },
                    { new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"), new Guid("278eaffa-f980-40d2-b014-10c04163c52a"), 0m, 0, "images/recipes/beef_stroganoff.jpg", "Beef Stroganoff", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"), new Guid("64c7e557-7a14-454b-97c5-bbcf4cb274dd"), 0m, 0, "images/recipes/feijoada.jpg", "Feijoada", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), new Guid("550054a5-1eb7-4468-b693-a1540a5d3131"), 0m, 0, "images/recipes/tacos_al_pastor.jpg", "Tacos al Pastor", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550), 0m, 0, null },
                    { new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), new Guid("36fa5cc9-e6a9-49cc-98d0-dd3c9aecce6c"), 0m, 0, "images/recipes/sushi.jpg", "Sushi", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"), new Guid("ca309321-8afa-468f-8ace-8027b519e2dc"), 0m, 0, "images/recipes/ceviche.jpg", "Ceviche", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560), 0m, 0, null },
                    { new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"), new Guid("683b1e50-3f82-4310-93e5-00398707469f"), 0m, 0, "images/recipes/lasagna.jpg", "Lasagna", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580), 0m, 0, null },
                    { new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"), new Guid("9dc8871d-c338-4e12-b119-dcef98a5e7fa"), 0m, 0, "images/recipes/shawarma.jpg", "Shawarma", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580), 0m, 0, null },
                    { new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"), new Guid("4c00e5af-921b-427c-962a-8e42fcd7db80"), 0m, 0, "images/recipes/croissant.jpg", "Croissant", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580), 0m, 0, null },
                    { new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"), new Guid("910a64c2-a8ef-42a7-b1b6-c96a08f3332b"), 0m, 0, "images/recipes/pierogi.jpg", "Pierogi", new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570), 0m, 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 13, 3, 33, 1, 141, DateTimeKind.Utc).AddTicks(3940));
        }
    }
}
