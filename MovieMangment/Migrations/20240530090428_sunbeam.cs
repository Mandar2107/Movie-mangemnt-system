using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMangment.Migrations
{
    public partial class sunbeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Movie_Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Name = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Actor = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Actress = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Rating = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Movie_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Birthdate = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
