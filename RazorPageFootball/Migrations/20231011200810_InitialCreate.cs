using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageFootball.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollegeFootball",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    Conference = table.Column<string>(type: "TEXT", nullable: true),
                    TotalOffense = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalDefense = table.Column<decimal>(type: "TEXT", nullable: false),
                    MasseyRating = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeFootball", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeFootball");
        }
    }
}
