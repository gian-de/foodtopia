using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class renameInstructionCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Step",
                table: "Instructions");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Instructions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("03e9f8e6-539c-41e7-a041-8af500790ba7"),
                column: "Text",
                value: "Assemble tacos with pork, pineapple, and toppings of choice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"),
                column: "Text",
                value: "Toast burger buns lightly on the grill.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("19e6a008-bc94-4bff-8fd7-8b633712f9b9"),
                column: "Text",
                value: "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"),
                column: "Text",
                value: "Cook black beans with bay leaves until tender.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"),
                column: "Text",
                value: "Serve hot with white rice and orange slices.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2470414b-0fb5-4714-807f-bd0e58961f2d"),
                column: "Text",
                value: "Grill patties for 3-4 minutes per side.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2ada858b-3049-488e-891e-7c4eca8ea28f"),
                column: "Text",
                value: "Slice roll into bite-sized pieces and serve with soy sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"),
                column: "Text",
                value: "Cook rice noodles according to package instructions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"),
                column: "Text",
                value: "Cook eggplant slices in olive oil until soft and lightly browned.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"),
                column: "Text",
                value: "Rinse the cabbage thoroughly to remove excess salt.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"),
                column: "Text",
                value: "Fold the dough over the filling and pinch edges to seal.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"),
                column: "Text",
                value: "Mix onions, ground beef, bread, and curry powder in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"),
                column: "Text",
                value: "Coat fish fillets with flour, then dip in batter.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"),
                column: "Text",
                value: "Cook ground beef and season with garlic and spices.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"),
                column: "Text",
                value: "Garnish with bean sprouts, herbs, and lime wedges.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("43f35046-194d-414c-909c-ec7a0fad643c"),
                column: "Text",
                value: "Seal the pot with a lid and cook on low heat for 30 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4980a006-6a16-4788-bc52-c1aab9215845"),
                column: "Text",
                value: "Place a nori sheet on a bamboo mat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"),
                column: "Text",
                value: "Simmer on low heat for 10-15 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"),
                column: "Text",
                value: "Pack the mixture tightly into a jar.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"),
                column: "Text",
                value: "Fry the potato fries until crispy and golden.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"),
                column: "Text",
                value: "Serve immediately with tortilla chips or on its own.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"),
                column: "Text",
                value: "Sear sausage and pork ribs in a skillet.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"),
                column: "Text",
                value: "Bake for 30-40 minutes until golden brown.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"),
                column: "Text",
                value: "Cook basmati rice until half-cooked and drain.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"),
                column: "Text",
                value: "Rest chicken for a few minutes, then slice thinly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"),
                column: "Text",
                value: "Spoon mashed potato and cheese filling onto each circle.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5122c450-7627-47f4-a1cd-aa2fe8773ebf"),
                column: "Text",
                value: "Grill pork until fully cooked and slightly charred.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("53774383-64e6-4fc6-a307-3316e2f2527d"),
                column: "Text",
                value: "Assemble burgers with lettuce, patties, and toppings of choice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("53c53fa8-b7c7-47aa-8bd4-6880cee51f01"),
                column: "Text",
                value: "Let the pizza cool for at least 5 minutes and enjoy!");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"),
                column: "Text",
                value: "Heat beef broth and bring to a gentle boil.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"),
                column: "Text",
                value: "Serve over egg noodles or rice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"),
                column: "Text",
                value: "Top with béchamel sauce and bake for 30-40 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"),
                column: "Text",
                value: "Slice the duck into thin pieces.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"),
                column: "Text",
                value: "Mix flour, egg, and water to form a dough. Knead until smooth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"),
                column: "Text",
                value: "Toss everything together gently.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"),
                column: "Text",
                value: "Melt butter in a skillet over medium heat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"),
                column: "Text",
                value: "Sauté onions in a skillet until translucent.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"),
                column: "Text",
                value: "Bake for 35-40 minutes, then let rest before serving.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"),
                column: "Text",
                value: "Dissolve yeast in warm milk and let it activate.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"),
                column: "Text",
                value: "Add fresh salmon and roll tightly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"),
                column: "Text",
                value: "Shape into croissants and let them proof until doubled.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"),
                column: "Text",
                value: "Chop cabbage and sprinkle with salt. Let it sit for 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"),
                column: "Text",
                value: "Add sliced red onion and cilantro to the marinated fish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"),
                column: "Text",
                value: "Fry the fish in hot oil until golden brown.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"),
                column: "Text",
                value: "Mix yogurt, garlic, cumin, and olive oil to create marinade.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"),
                column: "Text",
                value: "Layer noodles, ricotta, beef, and mozzarella in a baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"),
                column: "Text",
                value: "Assemble pancakes with duck, scallions, and serve.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"),
                column: "Text",
                value: "Combine meats with cooked beans and simmer.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"),
                column: "Text",
                value: "Stir in sour cream and simmer for 5 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"),
                column: "Text",
                value: "Serve with basmati rice or naan bread.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"),
                column: "Text",
                value: "Add chicken and cook until browned.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"),
                column: "Text",
                value: "Serve with flatbread, yogurt, and fresh vegetables.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"),
                column: "Text",
                value: "Boil in salted water for 5-7 minutes, then serve warm.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"),
                column: "Text",
                value: "Shape the mixture into long, thin patties or onto skewers.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"),
                column: "Text",
                value: "Heat oil in a deep fryer or heavy skillet.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"),
                column: "Text",
                value: "Sauté onions and mushrooms in the same pan.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"),
                column: "Text",
                value: "Fluff rice and serve hot with raita.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"),
                column: "Text",
                value: "Soak black beans in water overnight.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"),
                column: "Text",
                value: "Mix flour, sugar, salt, and milk mixture into a dough.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"),
                column: "Text",
                value: "Preheat the oven to 350°F (175°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"),
                column: "Text",
                value: "Stir in tomato puree and heavy cream.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"),
                column: "Text",
                value: "Serve with pita and your favorite toppings.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"),
                column: "Text",
                value: "Add thinly sliced beef to the hot broth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7cc01c97-66e0-40e3-9e0b-67cb7e5bba8c"),
                column: "Text",
                value: "Whisk until eggs form into a foam-like white texture.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d465672-a6a1-4981-af70-6f3d9754370a"),
                column: "Text",
                value: "Chop grilled pork into bite-sized pieces.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"),
                column: "Text",
                value: "Let the fish marinate in the lime juice for 10 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"),
                column: "Text",
                value: "Ferment at room temperature for 3-5 days, then refrigerate.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"),
                column: "Text",
                value: "Cook ground lamb with diced tomatoes and season to taste.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"),
                column: "Text",
                value: "Preheat oven to 375°F (190°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"),
                column: "Text",
                value: "Bake at 400°F (200°C) until golden brown and flaky.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"),
                column: "Text",
                value: "Preheat oven to 375°F (190°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"),
                column: "Text",
                value: "Add beef back into the pan and stir in beef broth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"),
                column: "Text",
                value: "Marinate chicken in the mixture for at least 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"),
                column: "Text",
                value: "Combine cooked noodles and broth in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"),
                column: "Text",
                value: "In a bowl, combine fish and lime juice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("96e0bcb2-49f6-4745-8125-5c63e136f5b7"),
                column: "Text",
                value: "Serve hot with lime wedges and crushed peanuts.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"),
                column: "Text",
                value: "Cook kebabs for 3-4 minutes on each side until fully cooked.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"),
                column: "Text",
                value: "Cook lasagna noodles according to package instructions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"),
                column: "Text",
                value: "Grill chicken on medium-high heat for about 5-7 minutes per side.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"),
                column: "Text",
                value: "Transfer the mixture to a greased baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"),
                column: "Text",
                value: "Fold butter into the dough and roll out several times.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"),
                column: "Text",
                value: "Layer eggplants and lamb mixture in a baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"),
                column: "Text",
                value: "Roll out dough and cut into circles using a cookie cutter.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"),
                column: "Text",
                value: "Serve fish and chips together with tartar sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"),
                column: "Text",
                value: "Mix cabbage with chili flakes, garlic, and water to create a paste.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"),
                column: "Text",
                value: "Cook beef in a pan until browned, then set aside.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                column: "Text",
                value: "Crack eggs and add to mixing bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"),
                column: "Text",
                value: "Shape ground beef into four patties.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"),
                column: "Text",
                value: "Cook shrimp in a hot wok until pink, then set aside.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a8d91f07-ba9d-4bc2-a648-3e19e2863559"),
                column: "Text",
                value: "Marinate pork in adobo sauce for 4 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("aa70a518-abf1-40d5-b54f-13863ef82212"),
                column: "Text",
                value: "Cook sushi rice and season with rice vinegar.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("b6790a8b-3c8a-4905-849b-d80ca468096f"),
                column: "Text",
                value: "Layer chicken and rice in a pot, adding fried onions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("bc6b146f-9f96-4e1f-8cc0-26b139d5ef1a"),
                column: "Text",
                value: "Place back into the over for 12-15 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"),
                column: "Text",
                value: "Spread rice evenly on the nori, leaving an edge.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("c915df33-f7c6-4f55-ae59-9b8d1e36d446"),
                column: "Text",
                value: "Stir in shrimp and bean sprouts.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d0f47451-500b-45b5-bfdd-610c268e815b"),
                column: "Text",
                value: "Place cheddar cheese slices on patties to melt.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"),
                column: "Text",
                value: "Combine ground lamb, grated onion, cumin, and salt in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"),
                column: "Text",
                value: "Spread hoisin sauce on the pancakes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d9eac06b-58d7-41c2-b6db-6d14e98e3914"),
                column: "Text",
                value: "Soak rice noodles in warm water until softened.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"),
                column: "Text",
                value: "Roast the duck in the oven at 375°F until crispy.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("dbb31e0c-0758-40a2-a7fb-d7e2499befa0"),
                column: "Text",
                value: "Add arrowroot starch to mixing bowl and other spices of your choosing.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"),
                column: "Text",
                value: "Add soaked noodles to the wok with Pad Thai sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e662eb34-f212-424e-a5c5-186954c01f4a"),
                column: "Text",
                value: "Layer the sauce, then the cheese and lastly the toppings.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"),
                column: "Text",
                value: "Clean and dry the duck thoroughly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("ebc08345-ecbc-43cc-a371-ed082f332976"),
                column: "Text",
                value: "Marinate chicken with yogurt and spices for 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"),
                column: "Text",
                value: "Preheat grill or grill pan to medium-high heat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f7542ebf-4f93-4556-93ee-8a2184a7fddc"),
                column: "Text",
                value: "Warm tortillas on a skillet or grill.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 24, 19, 23, 21, 978, DateTimeKind.Utc).AddTicks(6160));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Instructions");

            migrationBuilder.AddColumn<string>(
                name: "Step",
                table: "Instructions",
                type: "character varying(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("03e9f8e6-539c-41e7-a041-8af500790ba7"),
                column: "Step",
                value: "Assemble tacos with pork, pineapple, and toppings of choice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"),
                column: "Step",
                value: "Toast burger buns lightly on the grill.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("19e6a008-bc94-4bff-8fd7-8b633712f9b9"),
                column: "Step",
                value: "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"),
                column: "Step",
                value: "Cook black beans with bay leaves until tender.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"),
                column: "Step",
                value: "Serve hot with white rice and orange slices.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2470414b-0fb5-4714-807f-bd0e58961f2d"),
                column: "Step",
                value: "Grill patties for 3-4 minutes per side.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2ada858b-3049-488e-891e-7c4eca8ea28f"),
                column: "Step",
                value: "Slice roll into bite-sized pieces and serve with soy sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"),
                column: "Step",
                value: "Cook rice noodles according to package instructions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"),
                column: "Step",
                value: "Cook eggplant slices in olive oil until soft and lightly browned.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"),
                column: "Step",
                value: "Rinse the cabbage thoroughly to remove excess salt.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"),
                column: "Step",
                value: "Fold the dough over the filling and pinch edges to seal.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"),
                column: "Step",
                value: "Mix onions, ground beef, bread, and curry powder in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"),
                column: "Step",
                value: "Coat fish fillets with flour, then dip in batter.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"),
                column: "Step",
                value: "Cook ground beef and season with garlic and spices.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"),
                column: "Step",
                value: "Garnish with bean sprouts, herbs, and lime wedges.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("43f35046-194d-414c-909c-ec7a0fad643c"),
                column: "Step",
                value: "Seal the pot with a lid and cook on low heat for 30 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4980a006-6a16-4788-bc52-c1aab9215845"),
                column: "Step",
                value: "Place a nori sheet on a bamboo mat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"),
                column: "Step",
                value: "Simmer on low heat for 10-15 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"),
                column: "Step",
                value: "Pack the mixture tightly into a jar.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"),
                column: "Step",
                value: "Fry the potato fries until crispy and golden.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"),
                column: "Step",
                value: "Serve immediately with tortilla chips or on its own.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"),
                column: "Step",
                value: "Sear sausage and pork ribs in a skillet.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"),
                column: "Step",
                value: "Bake for 30-40 minutes until golden brown.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"),
                column: "Step",
                value: "Cook basmati rice until half-cooked and drain.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"),
                column: "Step",
                value: "Rest chicken for a few minutes, then slice thinly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"),
                column: "Step",
                value: "Spoon mashed potato and cheese filling onto each circle.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5122c450-7627-47f4-a1cd-aa2fe8773ebf"),
                column: "Step",
                value: "Grill pork until fully cooked and slightly charred.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("53774383-64e6-4fc6-a307-3316e2f2527d"),
                column: "Step",
                value: "Assemble burgers with lettuce, patties, and toppings of choice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("53c53fa8-b7c7-47aa-8bd4-6880cee51f01"),
                column: "Step",
                value: "Let the pizza cool for at least 5 minutes and enjoy!");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"),
                column: "Step",
                value: "Heat beef broth and bring to a gentle boil.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"),
                column: "Step",
                value: "Serve over egg noodles or rice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"),
                column: "Step",
                value: "Top with béchamel sauce and bake for 30-40 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"),
                column: "Step",
                value: "Slice the duck into thin pieces.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"),
                column: "Step",
                value: "Mix flour, egg, and water to form a dough. Knead until smooth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"),
                column: "Step",
                value: "Toss everything together gently.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"),
                column: "Step",
                value: "Melt butter in a skillet over medium heat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"),
                column: "Step",
                value: "Sauté onions in a skillet until translucent.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"),
                column: "Step",
                value: "Bake for 35-40 minutes, then let rest before serving.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"),
                column: "Step",
                value: "Dissolve yeast in warm milk and let it activate.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"),
                column: "Step",
                value: "Add fresh salmon and roll tightly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"),
                column: "Step",
                value: "Shape into croissants and let them proof until doubled.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"),
                column: "Step",
                value: "Chop cabbage and sprinkle with salt. Let it sit for 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"),
                column: "Step",
                value: "Add sliced red onion and cilantro to the marinated fish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"),
                column: "Step",
                value: "Fry the fish in hot oil until golden brown.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"),
                column: "Step",
                value: "Mix yogurt, garlic, cumin, and olive oil to create marinade.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"),
                column: "Step",
                value: "Layer noodles, ricotta, beef, and mozzarella in a baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"),
                column: "Step",
                value: "Assemble pancakes with duck, scallions, and serve.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"),
                column: "Step",
                value: "Combine meats with cooked beans and simmer.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"),
                column: "Step",
                value: "Stir in sour cream and simmer for 5 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"),
                column: "Step",
                value: "Serve with basmati rice or naan bread.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"),
                column: "Step",
                value: "Add chicken and cook until browned.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"),
                column: "Step",
                value: "Serve with flatbread, yogurt, and fresh vegetables.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"),
                column: "Step",
                value: "Boil in salted water for 5-7 minutes, then serve warm.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"),
                column: "Step",
                value: "Shape the mixture into long, thin patties or onto skewers.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"),
                column: "Step",
                value: "Heat oil in a deep fryer or heavy skillet.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"),
                column: "Step",
                value: "Sauté onions and mushrooms in the same pan.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"),
                column: "Step",
                value: "Fluff rice and serve hot with raita.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"),
                column: "Step",
                value: "Soak black beans in water overnight.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"),
                column: "Step",
                value: "Mix flour, sugar, salt, and milk mixture into a dough.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"),
                column: "Step",
                value: "Preheat the oven to 350°F (175°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"),
                column: "Step",
                value: "Stir in tomato puree and heavy cream.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"),
                column: "Step",
                value: "Serve with pita and your favorite toppings.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"),
                column: "Step",
                value: "Add thinly sliced beef to the hot broth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7cc01c97-66e0-40e3-9e0b-67cb7e5bba8c"),
                column: "Step",
                value: "Whisk until eggs form into a foam-like white texture.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d465672-a6a1-4981-af70-6f3d9754370a"),
                column: "Step",
                value: "Chop grilled pork into bite-sized pieces.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"),
                column: "Step",
                value: "Let the fish marinate in the lime juice for 10 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"),
                column: "Step",
                value: "Ferment at room temperature for 3-5 days, then refrigerate.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"),
                column: "Step",
                value: "Cook ground lamb with diced tomatoes and season to taste.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"),
                column: "Step",
                value: "Preheat oven to 375°F (190°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"),
                column: "Step",
                value: "Bake at 400°F (200°C) until golden brown and flaky.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"),
                column: "Step",
                value: "Preheat oven to 375°F (190°C).");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"),
                column: "Step",
                value: "Add beef back into the pan and stir in beef broth.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"),
                column: "Step",
                value: "Marinate chicken in the mixture for at least 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"),
                column: "Step",
                value: "Combine cooked noodles and broth in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"),
                column: "Step",
                value: "In a bowl, combine fish and lime juice.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("96e0bcb2-49f6-4745-8125-5c63e136f5b7"),
                column: "Step",
                value: "Serve hot with lime wedges and crushed peanuts.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"),
                column: "Step",
                value: "Cook kebabs for 3-4 minutes on each side until fully cooked.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"),
                column: "Step",
                value: "Cook lasagna noodles according to package instructions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"),
                column: "Step",
                value: "Grill chicken on medium-high heat for about 5-7 minutes per side.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"),
                column: "Step",
                value: "Transfer the mixture to a greased baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"),
                column: "Step",
                value: "Fold butter into the dough and roll out several times.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"),
                column: "Step",
                value: "Layer eggplants and lamb mixture in a baking dish.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"),
                column: "Step",
                value: "Roll out dough and cut into circles using a cookie cutter.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"),
                column: "Step",
                value: "Serve fish and chips together with tartar sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"),
                column: "Step",
                value: "Mix cabbage with chili flakes, garlic, and water to create a paste.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"),
                column: "Step",
                value: "Cook beef in a pan until browned, then set aside.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                column: "Step",
                value: "Crack eggs and add to mixing bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"),
                column: "Step",
                value: "Shape ground beef into four patties.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"),
                column: "Step",
                value: "Cook shrimp in a hot wok until pink, then set aside.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("a8d91f07-ba9d-4bc2-a648-3e19e2863559"),
                column: "Step",
                value: "Marinate pork in adobo sauce for 4 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("aa70a518-abf1-40d5-b54f-13863ef82212"),
                column: "Step",
                value: "Cook sushi rice and season with rice vinegar.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("b6790a8b-3c8a-4905-849b-d80ca468096f"),
                column: "Step",
                value: "Layer chicken and rice in a pot, adding fried onions.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("bc6b146f-9f96-4e1f-8cc0-26b139d5ef1a"),
                column: "Step",
                value: "Place back into the over for 12-15 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"),
                column: "Step",
                value: "Spread rice evenly on the nori, leaving an edge.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("c915df33-f7c6-4f55-ae59-9b8d1e36d446"),
                column: "Step",
                value: "Stir in shrimp and bean sprouts.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d0f47451-500b-45b5-bfdd-610c268e815b"),
                column: "Step",
                value: "Place cheddar cheese slices on patties to melt.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"),
                column: "Step",
                value: "Combine ground lamb, grated onion, cumin, and salt in a bowl.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"),
                column: "Step",
                value: "Spread hoisin sauce on the pancakes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d9eac06b-58d7-41c2-b6db-6d14e98e3914"),
                column: "Step",
                value: "Soak rice noodles in warm water until softened.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"),
                column: "Step",
                value: "Roast the duck in the oven at 375°F until crispy.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("dbb31e0c-0758-40a2-a7fb-d7e2499befa0"),
                column: "Step",
                value: "Add arrowroot starch to mixing bowl and other spices of your choosing.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"),
                column: "Step",
                value: "Add soaked noodles to the wok with Pad Thai sauce.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e662eb34-f212-424e-a5c5-186954c01f4a"),
                column: "Step",
                value: "Layer the sauce, then the cheese and lastly the toppings.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"),
                column: "Step",
                value: "Clean and dry the duck thoroughly.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("ebc08345-ecbc-43cc-a371-ed082f332976"),
                column: "Step",
                value: "Marinate chicken with yogurt and spices for 2 hours.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"),
                column: "Step",
                value: "Preheat grill or grill pan to medium-high heat.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("f7542ebf-4f93-4556-93ee-8a2184a7fddc"),
                column: "Step",
                value: "Warm tortillas on a skillet or grill.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 17, 5, 38, 35, 762, DateTimeKind.Utc).AddTicks(5360));
        }
    }
}
