using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCountryGuidAndRecipes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("d8b26c49-5f7d-46c4-972b-7a5f8b3d26e5"), "pcs", "Bay leaves", 2m, new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0") },
                    { new Guid("e1a9d4a8-6d34-41b8-bc70-1245a1e5f5a1"), "oz", "Rice noodles", 8m, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd") },
                    { new Guid("f8b91c6a-3f2b-4217-b58d-9a38f6e0b277"), "tsp", "Salt", 0.5m, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9") },
                    { new Guid("fe728b6c-4c0a-4908-9596-8ed49bdae068"), "tbsp", "Biryani spices", 2m, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49") },
                    { new Guid("ffde08e9-ce76-4a6d-88c2-437205c0ad97"), "lb", "Ground beef", 1m, new Guid("2b53f900-d736-4393-a585-1f6624c177b2") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Step" },
                values: new object[,]
                {
                    { new Guid("03e9f8e6-539c-41e7-a041-8af500790ba7"), 5, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Assemble tacos with pork, pineapple, and toppings of choice." },
                    { new Guid("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"), 4, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Toast burger buns lightly on the grill." },
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
                    { new Guid("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"), 1, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Shape ground beef into four patties." },
                    { new Guid("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"), 2, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Cook shrimp in a hot wok until pink, then set aside." },
                    { new Guid("a8d91f07-ba9d-4bc2-a648-3e19e2863559"), 1, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Marinate pork in adobo sauce for 4 hours." },
                    { new Guid("aa70a518-abf1-40d5-b54f-13863ef82212"), 1, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Cook sushi rice and season with rice vinegar." },
                    { new Guid("b6790a8b-3c8a-4905-849b-d80ca468096f"), 3, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Layer chicken and rice in a pot, adding fried onions." },
                    { new Guid("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"), 3, new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"), "Spread rice evenly on the nori, leaving an edge." },
                    { new Guid("c915df33-f7c6-4f55-ae59-9b8d1e36d446"), 4, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Stir in shrimp and bean sprouts." },
                    { new Guid("d0f47451-500b-45b5-bfdd-610c268e815b"), 3, new Guid("2b53f900-d736-4393-a585-1f6624c177b2"), "Place cheddar cheese slices on patties to melt." },
                    { new Guid("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"), 1, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Combine ground lamb, grated onion, cumin, and salt in a bowl." },
                    { new Guid("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"), 4, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Spread hoisin sauce on the pancakes." },
                    { new Guid("d9eac06b-58d7-41c2-b6db-6d14e98e3914"), 1, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Soak rice noodles in warm water until softened." },
                    { new Guid("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"), 2, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Roast the duck in the oven at 375°F until crispy." },
                    { new Guid("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"), 3, new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"), "Add soaked noodles to the wok with Pad Thai sauce." },
                    { new Guid("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"), 1, new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"), "Clean and dry the duck thoroughly." },
                    { new Guid("ebc08345-ecbc-43cc-a371-ed082f332976"), 1, new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"), "Marinate chicken with yogurt and spices for 2 hours." },
                    { new Guid("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"), 3, new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"), "Preheat grill or grill pan to medium-high heat." },
                    { new Guid("f7542ebf-4f93-4556-93ee-8a2184a7fddc"), 4, new Guid("bc259740-607d-4a1d-9347-c38713669a6c"), "Warm tortillas on a skillet or grill." }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 16, 20, 3, 16, 194, DateTimeKind.Utc).AddTicks(8960));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("045ff37e-63c4-413b-9553-b6082ef70c3d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0bce1bf7-1cea-43de-9cee-d85e1eeeb89f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0df2e923-4f5b-4203-925a-7d2e38c72d1c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0fa36b10-e022-42aa-b4c1-73b81ce4e51d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("17dbfc9b-cd68-4937-94b5-d23a36af1c13"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1cf5b843-7d93-4f3c-846e-3f9b726ae2d3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1e85b82a-0dcd-4c37-a9c9-123e8c3280d5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1f6c5e7a-4b8d-9a3f-7b2c-3f9e7a5d6b12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2b55982b-11e6-4642-afa8-6c727382753f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2f743557-4f5f-4783-b3fc-a36a41888940"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2f97b6d4-5c8a-4a1f-9e7d-3b4f6a91c78e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("37dec78e-9dac-4a98-99f2-03f0de13facd"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3a6f9e7b-5c4d-8a1f-7b2d-6e5f9b7c3a12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3c7b9e6f-5d4a-1a8f-7b2c-9f6a5b7e3f18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3f7a6b9e-5c4d-8a1f-7b2d-9e6a5f9b7c18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3f7b6d5a-9c4e-8a1f-7b2d-6a9e5f4c7b12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3f9b7e5a-6d4c-8a1f-7b2d-9f5c7a6e3b12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4b6e9a3f-7d1c-5f2b-8a7d-3c5e7a9b6f18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4e7a5c3f-9d6b-2f8b-7f3a-8b9c6a5d7f4e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4e7b6a3c-9f8d-5b2a-7f1c-6d3e5f9a7b18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5a6e7f9c-3b4d-8a1f-7b2c-9e6a7f5c3b18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5b9a6f7e-4e3d-8a1f-7b2d-5a6e7f3b8f12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5c4e7b9f-2d4a-8f3b-7b2c-9a5f6a7b3e12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5f7c9d4e-3b6a-8f2f-7f5a-9c6b4a7d3e8b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5f9a6e7b-3c4d-8a1f-7b2d-6b9e7f3a5c12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("61046199-47f5-4d3b-8834-1cb7b8464a82"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("61d3f2a9-7b6e-48d5-8f9c-7a2e9b34d7fa"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6a7b5c9e-3d4a-8f1e-7b2d-9e6b5a7c8f12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6a7b9e5c-3f8d-4a1f-7c2d-9f5b7a6e3f12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6b8f35a9-9247-4b5d-8574-2f8b39e7c4b3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6b9a7d4f-3e8c-5a1f-7b2d-9f5c7a4e3b18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6ba75d76-24d6-404e-b437-4b8b44f97c74"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f2c49e4-81f7-4d83-9f89-7a3b2f2a79db"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f3b9a7e-5d4c-1a8f-7b2c-9e6a5f7b3c18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f48049f-e9bb-489c-b98a-f57c3c0212ed"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f9a5c7b-3e4d-8a1f-7b2d-9b6a5f7c3e12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f9c7b5a-3e4d-8a1f-7b2d-5a7e6f3b9c12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7a5b9f6e-5c4d-8a1f-7b2c-9e7a5c9b6f18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7a6b9e5f-3c4d-8a1f-7b2d-9f6e7c5b3a18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7b6f9c5e-3d4a-8a1f-7b2d-5e7c9a6f3b18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7b9d6f3e-4a5c-8f2b-7d3a-9c6a4f5e8b7f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7d4b6f82-5c93-2f8a-9e36-4b7c39e5d3f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7d9e6b2f-3a4c-8f1b-7a5f-6f9b4e0d7a38"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7e5b9c6a-4e3d-8a1f-7b2d-5f7a6b8c9f12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7f6c3a9b-5e1d-4f9a-7b2c-9a8f4e7d6b13"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("830d8300-a1d6-408a-8ab3-99541fb423e3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("843d5c82-3a4b-4f8e-b746-389fbf68d1d1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("87f6815c-5992-4f7d-8a49-3f5183e556de"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8a042d5b-5073-4f71-b823-ab102e3293ea"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8a7b5cd3-b432-4c96-8f4e-6d23b9cfe3d7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8a7c5f3e-9b6d-4f1a-7b2c-6a9e7b5d3f18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8a9f6b7e-5c4d-8a1f-7b2d-6e7a5f9c3e12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8b9c7e6b-3f4d-8a1f-7b2d-6f7a5c8e9f12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8f5c3a7d-4b92-96e2-7f6b-3a49e2c5f8d7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("913a61c7-5f73-4900-a68b-637d6176f96e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("92fc04e6-7949-44ee-97ef-b795444a8e94"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9c4761af-93b6-45f5-b2d5-7a29f4d78163"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9d6f4b3a-7e8b-5c2f-3a9d-7b6a4e5f8c3f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9e2b6f7c-3a5d-4b92-83e7-5c39f4a6d8f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9e3b7a5d-6a4f-1c8b-7f2d-3f6c5f7b9a18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9e5a3f7b-6d4c-8a1f-7b2d-6a9e7f5c3b12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9e5b7c6a-3f4d-8a1f-7b2d-5f6e7a9c3b18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9f5c3e7a-4d1b-6a8f-7b2c-7b9a6e3f5a18"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9f5d3a7c-1e8b-6a4f-7b9d-3f2e6c9a5f8a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9f6b7e5c-3a4d-8a1f-7b2c-5e7a6f9b3c12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9f7e8c5b-3c4d-8a1f-7b2d-9e5f7a6c3b12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a1c8a4d5-22dc-4b8e-a452-573fc9159f65"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a1d3bbaf-1132-4111-b558-2e027fab8926"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a7c5d8f3-4b92-3f6a-96e7-5d2b7c39f4e6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a824a011-d517-43e2-8b80-9242324a0242"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b02357ad-7e58-448a-a65f-9c5d9e781f22"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b1c7e5f4-91a8-4b3d-7f2e-6d9a5f8c301b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b47e1f6a-8f3c-4a2d-91b7-6a9c58f7e302"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b6bef407-688f-4948-8c62-84af05c4c7a6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b7c9a5e6-3d4f-8a1f-7b2d-6f5e7a9b3c12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d8b26c49-5f7d-46c4-972b-7a5f8b3d26e5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e1a9d4a8-6d34-41b8-bc70-1245a1e5f5a1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f8b91c6a-3f2b-4217-b58d-9a38f6e0b277"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("fe728b6c-4c0a-4908-9596-8ed49bdae068"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ffde08e9-ce76-4a6d-88c2-437205c0ad97"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("03e9f8e6-539c-41e7-a041-8af500790ba7"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2470414b-0fb5-4714-807f-bd0e58961f2d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2ada858b-3049-488e-891e-7c4eca8ea28f"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("43f35046-194d-414c-909c-ec7a0fad643c"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4980a006-6a16-4788-bc52-c1aab9215845"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5122c450-7627-47f4-a1cd-aa2fe8773ebf"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("53774383-64e6-4fc6-a307-3316e2f2527d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d465672-a6a1-4981-af70-6f3d9754370a"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("96e0bcb2-49f6-4745-8125-5c63e136f5b7"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a8d91f07-ba9d-4bc2-a648-3e19e2863559"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("aa70a518-abf1-40d5-b54f-13863ef82212"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("b6790a8b-3c8a-4905-849b-d80ca468096f"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("c915df33-f7c6-4f55-ae59-9b8d1e36d446"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d0f47451-500b-45b5-bfdd-610c268e815b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d9eac06b-58d7-41c2-b6db-6d14e98e3914"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("ebc08345-ecbc-43cc-a371-ed082f332976"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f7542ebf-4f93-4556-93ee-8a2184a7fddc"));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 15, 5, 34, 53, 704, DateTimeKind.Utc).AddTicks(9570));
        }
    }
}
