using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class FixedNamingForDbSetPlaylistRecipeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeartedPlaylists_Playlist_PlaylistId",
                table: "HeartedPlaylists");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistRecipe_Playlist_PlaylistId",
                table: "PlaylistRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistRecipe_Recipes_RecipeId",
                table: "PlaylistRecipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaylistRecipe",
                table: "PlaylistRecipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist");

            migrationBuilder.RenameTable(
                name: "PlaylistRecipe",
                newName: "PlaylistRecipes");

            migrationBuilder.RenameTable(
                name: "Playlist",
                newName: "Playlists");

            migrationBuilder.RenameIndex(
                name: "IX_PlaylistRecipe_RecipeId",
                table: "PlaylistRecipes",
                newName: "IX_PlaylistRecipes_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlist_UserId",
                table: "Playlists",
                newName: "IX_Playlists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlist_FullSlug",
                table: "Playlists",
                newName: "IX_Playlists_FullSlug");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaylistRecipes",
                table: "PlaylistRecipes",
                columns: new[] { "PlaylistId", "RecipeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "5407dc14-7127-4d65-b891-a2e698cb3afc", new DateTime(2025, 3, 6, 9, 1, 0, 955, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "cd9034de-cce9-4e54-b272-72db46b209c3", new DateTime(2025, 3, 6, 9, 1, 1, 110, DateTimeKind.Utc).AddTicks(6990), "AQAAAAIAAYagAAAAEHbrh+IHsBrfjvoNKA7AnEBD6afflbjLSUzMAVrkNq9yQNwYOQBdoH0m/rQxkYo9Og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "c29c79d2-a668-47d1-b77c-4531e2f90981", new DateTime(2025, 3, 6, 9, 1, 1, 34, DateTimeKind.Utc).AddTicks(9940), "AQAAAAIAAYagAAAAED5PpmE6dvXlGN5ZELPwujRLjzBCPXxc9gVQUMch/4coyh7Y84YgaTGd4B4TOVMeDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "ff2d7e09-404b-45a0-b812-b32f12d697ae", new DateTime(2025, 3, 6, 9, 1, 0, 997, DateTimeKind.Utc).AddTicks(1050), "AQAAAAIAAYagAAAAEGxzO+76CnU6COfn5qH/19llYAQ5Y9kH6wJt99qfSRWe6jRVFwdEqOb91niJAmk/2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "44f8bf0e-31b6-4e08-bf1a-46ff7e0aa7e2", new DateTime(2025, 3, 6, 9, 1, 1, 72, DateTimeKind.Utc).AddTicks(7320), "AQAAAAIAAYagAAAAENsn/HifmlTyoLmyY9h/vGE9iPu4zM556rSVrcFzPWI/FD4ysO6iXhrZY8Yfktp08Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e7373ece-57c5-45f6-9476-a90c35768873", new DateTime(2025, 3, 6, 9, 1, 0, 957, DateTimeKind.Utc).AddTicks(4270), "AQAAAAIAAYagAAAAEDeNsUEx1QAQKPzWSfRaynEJwU2wZNHocJbI2p0fTynSkTCC1Ku++6oj+7b7XVr23A==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 158, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 9, 1, 1, 153, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.AddForeignKey(
                name: "FK_HeartedPlaylists_Playlists_PlaylistId",
                table: "HeartedPlaylists",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistRecipes_Playlists_PlaylistId",
                table: "PlaylistRecipes",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistRecipes_Recipes_RecipeId",
                table: "PlaylistRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_AspNetUsers_UserId",
                table: "Playlists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeartedPlaylists_Playlists_PlaylistId",
                table: "HeartedPlaylists");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistRecipes_Playlists_PlaylistId",
                table: "PlaylistRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistRecipes_Recipes_RecipeId",
                table: "PlaylistRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_UserId",
                table: "Playlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaylistRecipes",
                table: "PlaylistRecipes");

            migrationBuilder.RenameTable(
                name: "Playlists",
                newName: "Playlist");

            migrationBuilder.RenameTable(
                name: "PlaylistRecipes",
                newName: "PlaylistRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_UserId",
                table: "Playlist",
                newName: "IX_Playlist_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_FullSlug",
                table: "Playlist",
                newName: "IX_Playlist_FullSlug");

            migrationBuilder.RenameIndex(
                name: "IX_PlaylistRecipes_RecipeId",
                table: "PlaylistRecipe",
                newName: "IX_PlaylistRecipe_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaylistRecipe",
                table: "PlaylistRecipe",
                columns: new[] { "PlaylistId", "RecipeId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "545e447c-70dc-4d72-b897-2a5ff8b7a1aa", new DateTime(2025, 3, 6, 7, 2, 38, 393, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f533a33-a555-4490-92e1-6046a789efb4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "097c93a6-fa58-4404-bed1-f1d7f10880ab", new DateTime(2025, 3, 6, 7, 2, 38, 560, DateTimeKind.Utc).AddTicks(5400), "AQAAAAIAAYagAAAAEMMssleGqukowICaf3VOCp+OlTIFcjao75vTvSKTUWTuJs0lWoRm+RWF5ztBQ7qBbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ade051b-43be-4938-8942-507046ab759a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "1673e0d5-bfc7-40bf-a677-49d2a46ac270", new DateTime(2025, 3, 6, 7, 2, 38, 477, DateTimeKind.Utc).AddTicks(9380), "AQAAAAIAAYagAAAAEHBaeMPr5cWY5GF3AU7h5uip6yfCEof8FLRaqWndj3I9jJwAQwQRxY2BLVw0aNoWcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91d587d6-a100-415b-859a-a2631dbfd12d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "4437f0b5-9f21-43ee-b589-f68b35388b1f", new DateTime(2025, 3, 6, 7, 2, 38, 436, DateTimeKind.Utc).AddTicks(9550), "AQAAAAIAAYagAAAAEBJOwmYZZ70ixRhdCfl7PB7C9WvussOLClanzq0FZbYTkp5I2wTYouZhELGn7K8i7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afe80b95-1e55-4894-9507-81790f3d3424"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "1ad94640-de0a-4220-afec-9b1ab27bd539", new DateTime(2025, 3, 6, 7, 2, 38, 521, DateTimeKind.Utc).AddTicks(1170), "AQAAAAIAAYagAAAAELN7IotbfIq/+zIaY0WkYxC0AQ5a/ZPifGV7ii0aD0De3CSWYJmYUMyt+Bcep/m6gA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f7e84453-d117-465e-bb30-eb59cdb756ec", new DateTime(2025, 3, 6, 7, 2, 38, 395, DateTimeKind.Utc).AddTicks(6750), "AQAAAAIAAYagAAAAED/AOcvhEScmlWJ8s/E6S8cu7sbPaZKO/tKEX/Ue5LCcqTYMu3jFExj5aZQAGOo09Q==" });

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4baa4456-d138-4181-a556-0c34ac9d399d"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("4bd052d1-088b-463c-8281-b386bbbc056f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("61939421-e5cf-4700-82f1-8d103387170f"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("b5ae64ba-a904-4dee-8759-dc0722144058"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "HeartedRecipes",
                keyColumn: "Id",
                keyValue: new Guid("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                column: "HeartedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 608, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                column: "PublishedAt",
                value: new DateTime(2025, 3, 6, 7, 2, 38, 602, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.AddForeignKey(
                name: "FK_HeartedPlaylists_Playlist_PlaylistId",
                table: "HeartedPlaylists",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistRecipe_Playlist_PlaylistId",
                table: "PlaylistRecipe",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistRecipe_Recipes_RecipeId",
                table: "PlaylistRecipe",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
