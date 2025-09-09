using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class AwaitingRoleManagerCheckThenSeedingOwnerRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8ddf580b-9cae-4dab-b81a-4c5ddb663c69"),
                column: "NormalizedName",
                value: "OWNER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "5badf56e-41b6-4e29-b623-589f36686431", new DateTime(2025, 9, 9, 2, 55, 30, 498, DateTimeKind.Utc).AddTicks(5650), "AQAAAAIAAYagAAAAELg6a3d8PR5YwoynTD1rxsSQb7ifgaUo7229uDKoC3aAX5/1/sKAoyiRXXeO3ckoKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "ea6998b5-d95c-4a85-969c-7f38b72580cf", new DateTime(2025, 9, 9, 2, 55, 30, 423, DateTimeKind.Utc).AddTicks(4380), "AQAAAAIAAYagAAAAEFlEOBUinx8Pha6JZ5odIiuLNuFzpEx1NdiccsQ5Ut5R7sq4uP6FG+CkAsTqLY+ANA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f4dee227-212e-4658-83f5-a42446bda68b", new DateTime(2025, 9, 9, 2, 55, 30, 385, DateTimeKind.Utc).AddTicks(9740), "AQAAAAIAAYagAAAAEOBkhYckQedTnbRYnXB2mcvZmchEq1SxXz/ialxuGZi5iKZxPrPq+WP6QpqgZpBQRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e79506b8-ae50-4a26-a596-ca49fa214de4", new DateTime(2025, 9, 9, 2, 55, 30, 460, DateTimeKind.Utc).AddTicks(9960), "AQAAAAIAAYagAAAAEK52r+4UQDNk6hnT/88Bjo1K1sf92n7V8VPKn9DvC5IPpEcCmaJQwzUWJZtvhCqe3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "614fd085-6b13-4d5d-80fd-a548f0050173", new DateTime(2025, 9, 9, 2, 55, 30, 343, DateTimeKind.Utc).AddTicks(7820), "AQAAAAIAAYagAAAAEMWqlYBEr337J9SaOF5MPeOOJryR564L193nvBvCp26OCpRxv/r/cDebA6paVxutJg==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 544, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 538, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 55, 30, 539, DateTimeKind.Utc).AddTicks(920));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8ddf580b-9cae-4dab-b81a-4c5ddb663c69"),
                column: "NormalizedName",
                value: "Owner");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "136187c4-2bb0-4f99-b440-3871d71c5dc9", new DateTime(2025, 9, 9, 2, 26, 40, 486, DateTimeKind.Utc).AddTicks(1030), "AQAAAAIAAYagAAAAEOnq8nCPafw3+4VKVqleXUQO6lLCBwrPvfXEYIt+IObs3Mwqth+VmgMTMmhILS2x3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "77841756-f1e7-436b-aef0-010daff35ea2", new DateTime(2025, 9, 9, 2, 26, 40, 411, DateTimeKind.Utc).AddTicks(700), "AQAAAAIAAYagAAAAEPkEsRpnuRyTeQGXtWvVK10NERw8SVSEN0Bsek8TorBWVzbZMgicQv8SjZ77kl4vLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "a3303ac9-18d3-4942-b064-c9d85f222822", new DateTime(2025, 9, 9, 2, 26, 40, 373, DateTimeKind.Utc).AddTicks(4880), "AQAAAAIAAYagAAAAEJjAB16JhN7zelCpBOStm6B+SB/03R5QaGq4KSZ/3cFyuJiAe92jSpcxNTsDVebMuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "4467579e-4724-4250-89a0-41fb8e3652af", new DateTime(2025, 9, 9, 2, 26, 40, 448, DateTimeKind.Utc).AddTicks(6240), "AQAAAAIAAYagAAAAEIgnjFM7hA7uZH3Pu+7qCzRW/ianIl8ECOY6ngEe4wpgvarGnUx2IoRsrCR8+2iJDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f8d000b0-ee7f-4a67-83a2-e4bbe1619ec4", new DateTime(2025, 9, 9, 2, 26, 40, 333, DateTimeKind.Utc).AddTicks(7010), "AQAAAAIAAYagAAAAECdWHtypCzYvqD17nQYaL8Z20s6hqp7jfjWXX2cA4D0a1b6/5JSUNILgc7io2hntwQ==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 532, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 9, 9, 2, 26, 40, 527, DateTimeKind.Utc).AddTicks(6680));
        }
    }
}
