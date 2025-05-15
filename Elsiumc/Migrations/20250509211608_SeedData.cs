using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Elsiumc.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JoinDate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Occupation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MainRole = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubRoles = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CriminalRecords = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PenaltyPoints = table.Column<int>(type: "int", nullable: true),
                    Lands = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Constitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedByUserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    YesVotes = table.Column<int>(type: "int", nullable: false),
                    NoVotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constitutions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "062aa28a-2195-44c8-a7e6-a2a71e34c984", null, "Finance", "FİNANCE" },
                    { "2a973016-75a8-44b4-a61a-6337c1f70923", null, "Family", "FAMİLY" },
                    { "46b547d4-5c4c-46b3-afad-ac8de12fd8d6", null, "President", "PRESİDENT" },
                    { "50579300-40d5-4f00-81ad-5d0574d611f6", null, "Admin", "ADMIN" },
                    { "de860912-aad3-478d-a56d-39a47732da95", null, "Citizen", "CITIZEN" },
                    { "e0694e87-5545-4bac-bb05-951c46557381", null, "School", "SCHOOL" },
                    { "f276132b-6992-44f5-afe7-fcad1fca1e6d", null, "Friend", "Friend" }
                });

            migrationBuilder.InsertData(
                table: "Constitutions",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedByUserId", "EndsAt", "NoVotes", "Title", "YesVotes" },
                values: new object[,]
                {
                    { 1, "Bu, Anayasa 1'in içeriğidir.", new DateTime(2025, 4, 29, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(592), "user1", new DateTime(2025, 5, 4, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(593), 30, "Anayasa 1", 50 },
                    { 2, "Bu, Anayasa 2'nin içeriğidir.", new DateTime(2025, 5, 1, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(596), "user2", new DateTime(2025, 5, 6, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(597), 60, "Anayasa 2", 40 },
                    { 3, "Bu, Anayasa 3'ün içeriğidir.", new DateTime(2025, 4, 24, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(599), "user3", new DateTime(2025, 4, 29, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(600), 20, "Anayasa 3", 70 },
                    { 4, "Bu, Anayasa 4'ün içeriğidir.", new DateTime(2025, 4, 27, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(602), "user4", new DateTime(2025, 5, 2, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(603), 40, "Anayasa 4", 30 },
                    { 5, "Bu, Anayasa 5'in içeriğidir.", new DateTime(2025, 4, 19, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(604), "user5", new DateTime(2025, 4, 24, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(605), 10, "Anayasa 5", 90 },
                    { 6, "Bu, Anayasa 6'nın içeriğidir.", new DateTime(2025, 4, 21, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(606), "user6", new DateTime(2025, 4, 26, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(607), 50, "Anayasa 6", 60 },
                    { 7, "Bu, Anayasa 7'nin içeriğidir.", new DateTime(2025, 4, 14, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(608), "user7", new DateTime(2025, 4, 19, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(609), 40, "Anayasa 7", 80 },
                    { 8, "Bu, Anayasa 8'in içeriğidir.", new DateTime(2025, 4, 17, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(610), "user8", new DateTime(2025, 4, 22, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(611), 70, "Anayasa 8", 20 },
                    { 9, "Bu, Anayasa 9'un içeriğidir.", new DateTime(2025, 4, 9, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(613), "user9", new DateTime(2025, 4, 14, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(613), 5, "Anayasa 9", 100 },
                    { 10, "Bu, Anayasa 10'un içeriğidir.", new DateTime(2025, 4, 11, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(615), "user10", new DateTime(2025, 4, 16, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(615), 50, "Anayasa 10", 50 },
                    { 11, "Bu, Anayasa 11'in içeriğidir.", new DateTime(2025, 4, 4, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(617), "user11", new DateTime(2025, 4, 9, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(617), 30, "Anayasa 11", 60 },
                    { 12, "Bu, Anayasa 12'nin içeriğidir.", new DateTime(2025, 3, 30, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(619), "user12", new DateTime(2025, 4, 4, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(619), 20, "Anayasa 12", 70 },
                    { 13, "Bu, Anayasa 13'ün içeriğidir.", new DateTime(2025, 3, 25, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(621), "user13", new DateTime(2025, 3, 30, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(621), 60, "Anayasa 13", 30 },
                    { 14, "Bu, Anayasa 14'ün içeriğidir.", new DateTime(2025, 3, 20, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(623), "user14", new DateTime(2025, 3, 25, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(623), 10, "Anayasa 14", 90 },
                    { 15, "Bu, Anayasa 15'in içeriğidir.", new DateTime(2025, 3, 15, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(625), "user15", new DateTime(2025, 3, 20, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(626), 40, "Anayasa 15", 40 },
                    { 16, "Bu, Anayasa 16'nın içeriğidir.", new DateTime(2025, 3, 10, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(627), "user16", new DateTime(2025, 3, 15, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(628), 20, "Anayasa 16", 80 },
                    { 17, "Bu, Anayasa 17'nin içeriğidir.", new DateTime(2025, 3, 5, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(629), "user17", new DateTime(2025, 3, 10, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(630), 30, "Anayasa 17", 70 },
                    { 18, "Bu, Anayasa 18'in içeriğidir.", new DateTime(2025, 2, 28, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(631), "user18", new DateTime(2025, 3, 5, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(632), 40, "Anayasa 18", 60 },
                    { 19, "Bu, Anayasa 19'un içeriğidir.", new DateTime(2025, 2, 23, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(633), "user19", new DateTime(2025, 2, 28, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(634), 50, "Anayasa 19", 50 },
                    { 20, "Bu, Anayasa 20'nin içeriğidir.", new DateTime(2025, 2, 18, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(635), "user20", new DateTime(2025, 2, 23, 21, 16, 8, 276, DateTimeKind.Utc).AddTicks(636), 0, "Anayasa 20", 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Constitutions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
