using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addedsyllebusanddocumentsmodelfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    MimeType = table.Column<string>(nullable: true),
                    FileContent = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Syllebuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SyllebusName = table.Column<string>(nullable: true),
                    TradeId = table.Column<int>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    DevelopmentOfficer = table.Column<string>(nullable: true),
                    Manager = table.Column<string>(nullable: true),
                    ActiveDate = table.Column<DateTime>(nullable: false),
                    SyllebusDocId = table.Column<int>(nullable: true),
                    TestPlanDocId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syllebuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Syllebuses_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Syllebuses_Documents_SyllebusDocId",
                        column: x => x.SyllebusDocId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syllebuses_Documents_TestPlanDocId",
                        column: x => x.TestPlanDocId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syllebuses_Trades_TradeId",
                        column: x => x.TradeId,
                        principalTable: "Trades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Syllebuses_LevelId",
                table: "Syllebuses",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Syllebuses_SyllebusDocId",
                table: "Syllebuses",
                column: "SyllebusDocId");

            migrationBuilder.CreateIndex(
                name: "IX_Syllebuses_TestPlanDocId",
                table: "Syllebuses",
                column: "TestPlanDocId");

            migrationBuilder.CreateIndex(
                name: "IX_Syllebuses_TradeId",
                table: "Syllebuses",
                column: "TradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Syllebuses");

            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
