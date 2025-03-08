using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class VisibilityReviewModelAndSuperAdminSeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VisibilityStatus",
                table: "Recipes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "VisibilityReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VisibilityStatus = table.Column<string>(type: "text", nullable: false),
                    ReviewFeedback = table.Column<string>(type: "text", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReviewedById = table.Column<Guid>(type: "uuid", nullable: true),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: true),
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisibilityReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_AspNetUsers_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisibilityReviews_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f5ec44f6-aa4d-47b4-908b-4c04b3029534"), null, "Senior Admin", "SENIOR ADMIN" });

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
                keyValue: new Guid("f2c1a77d-cc69-4a7a-b58d-68481e19ed17"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "cbd4ec73-4a45-48b7-b295-9914f79aa225", new DateTime(2025, 3, 8, 4, 56, 10, 596, DateTimeKind.Utc).AddTicks(9360), "AQAAAAIAAYagAAAAEFKCVPcywG8uUlL0d/zyg2D4LjilP/c0CZewQaL3W4XhQ2XnZaikGZWjZYSR3wR6Pg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsGuest", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f0d0acba-6cad-4081-a14b-9973f4444962"), 0, "dea98898-afdb-473f-911d-57767d5fa74a", new DateTime(2025, 3, 8, 4, 56, 10, 595, DateTimeKind.Utc).AddTicks(5630), "owner@foodtopia.com", true, false, false, null, "OWNER@FOODTOPIA.COM", "OWNER", "$2a$12$9ZfJ8nSpsfzhlmw7o6JJlu0AbMrlrp3l.o3TD0SaXqAlDw/PndRG2", null, false, null, false, "Owner" });

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
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(2320), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4670), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4680), "public" });

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
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4660), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4680), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4690), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4710), "public" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                columns: new[] { "PublishedAt", "VisibilityStatus" },
                values: new object[] { new DateTime(2025, 3, 8, 4, 56, 10, 796, DateTimeKind.Utc).AddTicks(4700), "public" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f5ec44f6-aa4d-47b4-908b-4c04b3029534"), new Guid("f0d0acba-6cad-4081-a14b-9973f4444962") });

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_PlaylistId",
                table: "VisibilityReviews",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_RecipeId",
                table: "VisibilityReviews",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisibilityReviews_ReviewedById",
                table: "VisibilityReviews",
                column: "ReviewedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisibilityReviews");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f5ec44f6-aa4d-47b4-908b-4c04b3029534"), new Guid("f0d0acba-6cad-4081-a14b-9973f4444962") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5ec44f6-aa4d-47b4-908b-4c04b3029534"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0d0acba-6cad-4081-a14b-9973f4444962"));

            migrationBuilder.DropColumn(
                name: "VisibilityStatus",
                table: "Recipes");

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
        }
    }
}
