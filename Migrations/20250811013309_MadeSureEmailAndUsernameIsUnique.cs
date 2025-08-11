using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class MadeSureEmailAndUsernameIsUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "34fa661c-b01e-43e3-a04d-dc9207f495e1", new DateTime(2025, 8, 11, 1, 33, 8, 744, DateTimeKind.Utc).AddTicks(7520), "AQAAAAIAAYagAAAAEC0tW5rQ6Ind/RXfRv5cslFHbC9GlFsuqiKtBVB4gg6Y0ABkR5x7GFf3c/fFdsEC3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "706472e8-c45e-448d-ac18-69d885a4ee82", new DateTime(2025, 8, 11, 1, 33, 8, 665, DateTimeKind.Utc).AddTicks(1040), "AQAAAAIAAYagAAAAECfXTwrnCyt8t+hBg3I9N0jC/CDhu1EV9GiI0wAIuR+l2aVa1n6aRPodYlQcKp/5UA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f2d380f3-47ec-4228-b2f1-cee17893acaf", new DateTime(2025, 8, 11, 1, 33, 8, 625, DateTimeKind.Utc).AddTicks(2900), "AQAAAAIAAYagAAAAEDc42tKgGx8zOFrjhyPHCXa/xvK6MMDvd3S/mD9149JJ+tek5No4ifqP0k2wzY9qeg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "5096cd32-e4d7-4668-bb35-a0db1030c647", new DateTime(2025, 8, 11, 1, 33, 8, 704, DateTimeKind.Utc).AddTicks(8550), "AQAAAAIAAYagAAAAEI9lzuyJ4/tUa/eBvXZMCK1z/LQlGNxMIVWwrYt7O2yz82/Nzq0hbqySS5oMoXr66Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7ebfc605-29ca-4fe0-92c3-49a1c045e729", new DateTime(2025, 8, 11, 1, 33, 8, 583, DateTimeKind.Utc).AddTicks(300), "AQAAAAIAAYagAAAAEDwNNnXzWnLewMcUcKYsi7IZvv2XPN2V2cAH5sPE1R0VOPd/kxRDDtWyN1G6XAju1g==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 794, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 8, 11, 1, 33, 8, 788, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "2a8cd15e-67db-4f81-b07c-33fe9e5341ba", new DateTime(2025, 7, 21, 7, 50, 9, 714, DateTimeKind.Utc).AddTicks(1520), "AQAAAAIAAYagAAAAENWYm5+nVImlxUlb47qVMOnPkhFBlrhizkER7UVlC14lF9yY3uBJ1uEVpK4xzeaCZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "0d004a6b-445b-4381-bb66-912dfbdf5b7c", new DateTime(2025, 7, 21, 7, 50, 9, 638, DateTimeKind.Utc).AddTicks(5520), "AQAAAAIAAYagAAAAEKEcHSS00BV75PcLVa2XtDVRJ9ycvG/TFlP5bQTvvB36UeX2Q5skLXHJzLSmsNMQrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "61dfa4e3-4d05-40ae-8f97-d1a6b9411b79", new DateTime(2025, 7, 21, 7, 50, 9, 598, DateTimeKind.Utc).AddTicks(5460), "AQAAAAIAAYagAAAAEDEf0D/eXsN8MJtD3pJAXHSGhxEkQgx+CLX2TyD2ENIPhk3mhjEZC/P2BsuPjePFVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "6de8adce-7c43-4157-86de-1dc0494548dd", new DateTime(2025, 7, 21, 7, 50, 9, 676, DateTimeKind.Utc).AddTicks(6340), "AQAAAAIAAYagAAAAEHS70hB3erml500+m9e3u/7gfc3SxFvdkFHyGZdaZMZTVotfUd49K/8KMLWTfaQtBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "28d3c06d-1881-4f85-a43a-c157b3408a5c", new DateTime(2025, 7, 21, 7, 50, 9, 557, DateTimeKind.Utc).AddTicks(8960), "AQAAAAIAAYagAAAAEIOXNQYbNe58EE1KtGnqTGhhzu5NUXQp2UIyZ7p8LmftvoyJO6kpeXlftw8Vgl38xw==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 760, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 7, 21, 7, 50, 9, 755, DateTimeKind.Utc).AddTicks(3480));
        }
    }
}
