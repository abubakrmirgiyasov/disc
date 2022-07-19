using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISC.Migrations
{
    public partial class QuizV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quiz",
                table: "FirstPartQuizzes",
                newName: "QuizThird");

            migrationBuilder.AddColumn<string>(
                name: "QuizFirst",
                table: "FirstPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuizFourth",
                table: "FirstPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuizSecond",
                table: "FirstPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuizFirst",
                table: "FirstPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuizFourth",
                table: "FirstPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuizSecond",
                table: "FirstPartQuizzes");

            migrationBuilder.RenameColumn(
                name: "QuizThird",
                table: "FirstPartQuizzes",
                newName: "Quiz");
        }
    }
}
