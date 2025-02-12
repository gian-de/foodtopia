using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class AddedCreatedAtPropForFilteringGuestAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "9fd72693-eaf8-4e7c-92bf-ef0143f064e6", new DateTime(2025, 2, 12, 1, 56, 10, 474, DateTimeKind.Utc).AddTicks(8460), "AQAAAAIAAYagAAAAEEbB8nKgpJ4yqODXNsWqMa36bB2K0b3qi7BZoL4irjeKDxK8+yCALKSlAdPCG48Lig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "2ee1ee00-f648-49e8-bed5-60fc6a8f4715", new DateTime(2025, 2, 12, 1, 56, 10, 399, DateTimeKind.Utc).AddTicks(8190), "AQAAAAIAAYagAAAAEAR5oJmbjh3KGrJn41NEeWPx1Cpua1cFRN5RU2C7kr1vgVrWnAPH1Qtm5JnFL4dKsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "63195b3e-9b7b-4105-8b87-d4c3d69ba3ee", new DateTime(2025, 2, 12, 1, 56, 10, 361, DateTimeKind.Utc).AddTicks(8860), "AQAAAAIAAYagAAAAEJ1XKI4jZP1BPEqSIyy3E/IqrNHmK1Ha/+wobhHGFOI1/avj4m3o/rZgXwhl/PQ9PQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "285d61e6-e292-48df-ae79-ac1bd5ebbad3", new DateTime(2025, 2, 12, 1, 56, 10, 437, DateTimeKind.Utc).AddTicks(3290), "AQAAAAIAAYagAAAAEN/rMdD8yETg/EoBujzeKKwY1mAgbXfdk2VtkirozMEM1CRZV1eE+Y28uFNx9WmllQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e9c49c1d-0a0c-4819-a006-e747a851de42", new DateTime(2025, 2, 12, 1, 56, 10, 321, DateTimeKind.Utc).AddTicks(3590), "AQAAAAIAAYagAAAAEOQOdTqna+dErCrQL9yVEg38oKkGczho5OxTKDCUqdVvEf86ldLsVpqxbgdkW2i2jQ==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 521, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 12, 1, 56, 10, 515, DateTimeKind.Utc).AddTicks(4620));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02b6558b-ce49-44b9-941e-c569c765ae23", "AQAAAAIAAYagAAAAEAxL6+zpCWXP1/OLZ4kWE07/vpvKJeIRQLX6K/a8gjcT/9bby8vHiIcDGLMXaS8QhQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b31b1c37-7d30-480c-8704-7f29734972c8", "AQAAAAIAAYagAAAAEO49YQZwAUhdA53iZdXeXgwWeTxdaZHXyOcrBTvufTJKgAOqVU5lxUwA40opNdpwgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d8f578f-37e3-4f09-a66d-c5aaa60252b2", "AQAAAAIAAYagAAAAEEJf/KwXd+xlG86ThtcTMRRtY5cvieC+g9RXHQ+PF7OmglOxmy3l3kCwnyFXOqCBug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d66cfcc-5a53-4150-bad3-9f03109a72bc", "AQAAAAIAAYagAAAAEDmGZoHL+sdU8z5yjh3kx0Pujrx80BE29ErNC7fgSvON36oYR4tn20TSaEYCJ1KZ1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0acb18d-fae8-4cfb-84ee-6919f3e501f0", "AQAAAAIAAYagAAAAEGCFxJYBy7putXX87l6s0zI4d6QoH1eEA7KYULcR40YLJHDxKjIioXeVeWSu9hSVrA==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 890, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 11, 23, 34, 22, 884, DateTimeKind.Utc).AddTicks(6950));
        }
    }
}
