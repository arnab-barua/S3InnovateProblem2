using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addedrelationshipinsyllebusandlanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SyllebusLanguage",
                columns: table => new
                {
                    SyllebusId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyllebusLanguage", x => new { x.SyllebusId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_SyllebusLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SyllebusLanguage_Syllebuses_SyllebusId",
                        column: x => x.SyllebusId,
                        principalTable: "Syllebuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SyllebusLanguage_LanguageId",
                table: "SyllebusLanguage",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SyllebusLanguage");
        }
    }
}
