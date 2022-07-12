using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillSix = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
