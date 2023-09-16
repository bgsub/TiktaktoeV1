using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tiktaktoe.Migrations
{
    /// <inheritdoc />
    public partial class InitialPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OpponentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GridSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameMode = table.Column<int>(type: "int", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Loses = table.Column<int>(type: "int", nullable: false),
                    Draws = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    isOpponentVirtual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
