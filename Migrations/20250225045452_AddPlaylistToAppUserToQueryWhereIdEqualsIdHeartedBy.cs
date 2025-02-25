using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaylistToAppUserToQueryWhereIdEqualsIdHeartedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeartedPlaylist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartedPlaylist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeartedPlaylist_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeartedPlaylist_Playlist_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "97fd936d-63db-4cc0-8f0a-5a3209d6113f", new DateTime(2025, 2, 25, 4, 54, 52, 216, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "d864af46-3bff-4189-b09b-8665624af2f5", new DateTime(2025, 2, 25, 4, 54, 52, 416, DateTimeKind.Utc).AddTicks(2560), "AQAAAAIAAYagAAAAEGuq4yOXw3niecWVSWZIVPdKigVUbM/Z5rMVYH0dZKqYHNJd33gQFOHIDEAyCCN+Vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "ecbd9543-0a41-4f23-8660-e1600d850379", new DateTime(2025, 2, 25, 4, 54, 52, 297, DateTimeKind.Utc).AddTicks(1660), "AQAAAAIAAYagAAAAEG/LU0oMRSUKFyfM1gPcA75dVWjAwsp+7fONUp+kh+CzRdtRONp4GLB48qKTbXj1Uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "9b14d04b-7671-460b-bef3-bd9b4cb1fcf3", new DateTime(2025, 2, 25, 4, 54, 52, 258, DateTimeKind.Utc).AddTicks(3420), "AQAAAAIAAYagAAAAEIB4sycST2FgC5r0QhtMyUbAoUQ1CDzAi3D85HzHk27VREQx0RY7o4kiD/Vouo21iQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7dc3add3-8fd7-4bd4-ac0a-df13ee37fb57", new DateTime(2025, 2, 25, 4, 54, 52, 335, DateTimeKind.Utc).AddTicks(5620), "AQAAAAIAAYagAAAAEALMkiCy8jZaonisTwSvWUbtvoXbdMvho31PGpD1SaWoM5c+z77aeOoT4Q5T05eM1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "18335eb9-fe6d-477e-827a-030498663d00", new DateTime(2025, 2, 25, 4, 54, 52, 217, DateTimeKind.Utc).AddTicks(9290), "AQAAAAIAAYagAAAAEFk0GUUh6lq330R2dwkeKRLIUZOju1uzwLwp2CmW5KQUnqPKiFE9gkk8Eju4OSh5zQ==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 475, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 25, 4, 54, 52, 464, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.CreateIndex(
                name: "IX_HeartedPlaylist_PlaylistId",
                table: "HeartedPlaylist",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_HeartedPlaylist_UserId_PlaylistId",
                table: "HeartedPlaylist",
                columns: new[] { "UserId", "PlaylistId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartedPlaylist");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "dcbbb587-42d9-4408-8aa9-54aed98f1ff7", new DateTime(2025, 2, 22, 2, 29, 31, 483, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "098c9a47-c950-40ed-8d1c-d58885240a50", new DateTime(2025, 2, 22, 2, 29, 31, 641, DateTimeKind.Utc).AddTicks(1080), "AQAAAAIAAYagAAAAEPHqnE9C/8tDgOGkj0fTzFh9siWUFfW4L1NVhwiqj/14oLoXS5j2423/dMOs5EB/fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7b9ad5e2-f1bf-4981-b7fc-8c099b96818a", new DateTime(2025, 2, 22, 2, 29, 31, 563, DateTimeKind.Utc).AddTicks(7630), "AQAAAAIAAYagAAAAEKVy98+5V5cib7fE/4AVXONOsS+8o24YwQDOQUKVz+noPNK0jq2Jw2PqWQIZYjWc9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "ff294be3-b04a-46ca-9bc5-d4136c951d4f", new DateTime(2025, 2, 22, 2, 29, 31, 524, DateTimeKind.Utc).AddTicks(4050), "AQAAAAIAAYagAAAAEPKzQuYKI5U6oDJ6euq3ZRNJCFYDBKqXYsqYOO0BOR3jHepJ4ZivRQ/rwTcml01MKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7e6dd6e7-36e5-42cf-a1ea-7c4eb50d0ec1", new DateTime(2025, 2, 22, 2, 29, 31, 603, DateTimeKind.Utc).AddTicks(1270), "AQAAAAIAAYagAAAAEHyOR0Fjcca3crUuGe9fI455NIE6TlmdzAstUhiloxpMglfSzoEAUDsQsIp57K2kAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "4c6c4669-9171-4b7d-ba50-fcdb6758d67c", new DateTime(2025, 2, 22, 2, 29, 31, 484, DateTimeKind.Utc).AddTicks(8700), "AQAAAAIAAYagAAAAELdyIiVD0pSf2dYKEUV8t0p4L3m3wD3NKw0vRQ9OrWc12HE8TFhkYlEv7xnThLPauA==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 687, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 2, 22, 2, 29, 31, 682, DateTimeKind.Utc).AddTicks(4780));
        }
    }
}
