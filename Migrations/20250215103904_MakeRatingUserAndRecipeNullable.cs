using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class MakeRatingUserAndRecipeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "c741ef3d-30a1-46f2-825a-192bae95e8f8", new DateTime(2025, 2, 15, 10, 39, 3, 592, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "86eaab6a-8fa1-481a-adda-8d3ac6f85483", new DateTime(2025, 2, 15, 10, 39, 3, 749, DateTimeKind.Utc).AddTicks(1350), "AQAAAAIAAYagAAAAEJgYhEgm2sGQmdwEUTzNyowVoiqnrfO10wYlEGd5nfaYP9KSq7hLU+btJc1Le/rXGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e5ff9018-42b5-4765-bf74-efc70cdbf621", new DateTime(2025, 2, 15, 10, 39, 3, 672, DateTimeKind.Utc).AddTicks(8530), "AQAAAAIAAYagAAAAEP/KgNJmLylP6p17D0ww3WYqKsI36QUCvMu0TS/QuElAuz2kcvvzna6AoCX0wbTTDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7207fc34-ce18-41ad-850b-753b3fc2df21", new DateTime(2025, 2, 15, 10, 39, 3, 634, DateTimeKind.Utc).AddTicks(5600), "AQAAAAIAAYagAAAAEJCq0GjiFbLScoHu06Cz6SeET7rtCj4/cdPJrg0zXy2r4uWUq5KQfjV+Q5kjgJZ+gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "0a12b73e-4f68-4f25-980f-f965bf05c3fa", new DateTime(2025, 2, 15, 10, 39, 3, 711, DateTimeKind.Utc).AddTicks(1170), "AQAAAAIAAYagAAAAEKZG1onzpJY3mTJo5HxlhQXlFujANBh3iR//YbqkxO+bQbeJdkj2i4ZJ3TX8MsT45A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f58101de-2019-4360-bb6a-29ae8bee3310", new DateTime(2025, 2, 15, 10, 39, 3, 594, DateTimeKind.Utc).AddTicks(2930), "AQAAAAIAAYagAAAAEPiPzXgFHaL+hpFZblGUY63lqUe9+fWoK+6Y/nR33FsAnp0UWd4jDAO2MdE7YaB4Wg==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 796, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 15, 10, 39, 3, 791, DateTimeKind.Utc).AddTicks(3050));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "75f200c1-ad50-48dc-92af-848b4ddf7bec", new DateTime(2025, 2, 14, 0, 29, 25, 278, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "b865578c-dc80-43c0-9498-6ecca8ffe82f", new DateTime(2025, 2, 14, 0, 29, 25, 432, DateTimeKind.Utc).AddTicks(450), "AQAAAAIAAYagAAAAEDEXesYZworP2JPoLMNl1C/XOvt16eBdFSc6DtexARQzWmV4Hk5RQ+Y+PzyB2bOHlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "b4b8ff1d-9dc2-4f68-bf78-4736ba18c5a8", new DateTime(2025, 2, 14, 0, 29, 25, 356, DateTimeKind.Utc).AddTicks(9490), "AQAAAAIAAYagAAAAEF7jmTCEiOk+9p9ee/PBRYRUBR6MxYhe1TmpMScfbmFP51Y7CekZY4NhL6KMTygHVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "a983fe6b-66f0-466d-a906-60b21fad57e0", new DateTime(2025, 2, 14, 0, 29, 25, 319, DateTimeKind.Utc).AddTicks(3910), "AQAAAAIAAYagAAAAEH6CAt9sNzfVZYzjmuG24GUIKKRhUlxm/dhOpEHR5XipRutHPEnxbhHU1Asg+KNvvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7ed9b009-1631-41bd-9f2f-09280c8f8baa", new DateTime(2025, 2, 14, 0, 29, 25, 394, DateTimeKind.Utc).AddTicks(5420), "AQAAAAIAAYagAAAAEJlLZC4pBYn+Bdv5qSLyKfhCY2F8x+NopfS7DJhpwQJa17LaFXt3ODLjPJHBjqjIbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "edc130cc-8757-477b-9371-0d5953b2703a", new DateTime(2025, 2, 14, 0, 29, 25, 280, DateTimeKind.Utc).AddTicks(3540), "AQAAAAIAAYagAAAAEPY9kz2W9BaJ5gN4KNCuczM4ClLyul7lK2LSvpSHpj9bbBlKs8j9QWOlSlLWpSn1Dw==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 477, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 14, 0, 29, 25, 472, DateTimeKind.Utc).AddTicks(6460));
        }
    }
}
