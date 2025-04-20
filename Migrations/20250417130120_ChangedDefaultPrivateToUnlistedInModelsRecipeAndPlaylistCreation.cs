using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDefaultPrivateToUnlistedInModelsRecipeAndPlaylistCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b01786c3-ce91-49ed-9454-6d5b3cdca073", new DateTime(2025, 4, 17, 13, 1, 19, 868, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "31902635-1906-4e62-9583-b241aee45352", new DateTime(2025, 4, 17, 13, 1, 20, 36, DateTimeKind.Utc).AddTicks(6070), "AQAAAAIAAYagAAAAEK12JgINX+KOeqrbXyEiCi4/nsJMgLeEUG/ldG5IBg9PmjtqGAr6Klk93d/nyp1azA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "5bca6071-85b2-4c73-bfc8-caf48820b401", new DateTime(2025, 4, 17, 13, 1, 19, 961, DateTimeKind.Utc).AddTicks(510), "AQAAAAIAAYagAAAAEJ/4PFibkp1zqpGpYA8d35yqnl4AubTn9iBxK+zgktDUZ6byyShIza30Y8/VHFTJqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "c7f45041-752f-4f08-ba3f-a30f779d6b69", new DateTime(2025, 4, 17, 13, 1, 19, 919, DateTimeKind.Utc).AddTicks(9080), "AQAAAAIAAYagAAAAEDJDrMwTv7UrBz55K/BeNIPtpKHxO2qFizDuH36HDJdsKgeHv1w7Ou3SlcQ7maztxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "5e1be338-3d30-484f-bff7-14312455fe78", new DateTime(2025, 4, 17, 13, 1, 19, 999, DateTimeKind.Utc).AddTicks(670), "AQAAAAIAAYagAAAAEM0YItsgo0oU8pAs7GkEYfS0A4YkkQOhvMTWrLZxKIlvARsXmOZ9QSHlxZTgDIa2NQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0d0acba-6cad-4081-a14b-9973f4444962"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f936854c-ab2e-40f1-a747-91a6e5cba062", new DateTime(2025, 4, 17, 13, 1, 19, 872, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e5064490-53a6-4c3d-9b66-2018d0d802b7", new DateTime(2025, 4, 17, 13, 1, 19, 873, DateTimeKind.Utc).AddTicks(3750), "AQAAAAIAAYagAAAAEGi7PhIOxmXb+9wVdAU5URV//IaSad3SOrH1yAaup/xDfwXcCEzRhyqWXu61nG5ahg==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 83, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250), "unlisted" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 4, 17, 13, 1, 20, 78, DateTimeKind.Utc).AddTicks(6260));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "4edb93d6-e685-40cd-b997-991d89162fc8", new DateTime(2025, 3, 8, 4, 56, 10, 594, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "cce36c2e-84d3-4ef0-9761-633c4cb37c67", new DateTime(2025, 3, 8, 4, 56, 10, 754, DateTimeKind.Utc).AddTicks(5150), "AQAAAAIAAYagAAAAEFb5hbU386RmVDFFXXkMr/Nn3wKSE5ZomDqOy8c4dxxqPq1hZr+gT+aah2gpN6MIrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "a8d6ad9a-887b-4cac-9f48-8471df7db122", new DateTime(2025, 3, 8, 4, 56, 10, 676, DateTimeKind.Utc).AddTicks(7150), "AQAAAAIAAYagAAAAEIKp3i1VNZR3ZfLZrdMchanii3CaBwubLE/X1EDFt20zeKPye3m6LCsf84C5fymKpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e79fefd9-8785-4631-a7d6-c0e2e721aceb", new DateTime(2025, 3, 8, 4, 56, 10, 637, DateTimeKind.Utc).AddTicks(7320), "AQAAAAIAAYagAAAAEPnQIWZ0Frk7HaqGMTFvwKQHOE3w6rb9OBP645P8SSBKXAXO2yFA8N5+tDbm02Cnbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "edf437dd-8208-4368-8d1e-656a3a63be4f", new DateTime(2025, 3, 8, 4, 56, 10, 715, DateTimeKind.Utc).AddTicks(7010), "AQAAAAIAAYagAAAAEDra2GX59X+Mhz1rIh5anWT3WpUsEthpEFhz9MPziBvnDAfXdqxxk0Ql8EsUz2bYOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0d0acba-6cad-4081-a14b-9973f4444962"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "dea98898-afdb-473f-911d-57767d5fa74a", new DateTime(2025, 3, 8, 4, 56, 10, 595, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "cbd4ec73-4a45-48b7-b295-9914f79aa225", new DateTime(2025, 3, 8, 4, 56, 10, 596, DateTimeKind.Utc).AddTicks(9360), "AQAAAAIAAYagAAAAEFKCVPcywG8uUlL0d/zyg2D4LjilP/c0CZewQaL3W4XhQ2XnZaikGZWjZYSR3wR6Pg==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 801, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4680), "private" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700));
        }
    }
}
