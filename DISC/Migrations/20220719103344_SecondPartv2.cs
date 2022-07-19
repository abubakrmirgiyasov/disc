using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISC.Migrations
{
    public partial class SecondPartv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "SecondPartQuizzes",
                newName: "QuestionThird");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "SecondPartQuizzes",
                newName: "QuestionSixth");

            migrationBuilder.AddColumn<string>(
                name: "QuestionFifth",
                table: "SecondPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionFirst",
                table: "SecondPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionFourth",
                table: "SecondPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionSecond",
                table: "SecondPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionSeventh",
                table: "SecondPartQuizzes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionFifth",
                table: "SecondPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuestionFirst",
                table: "SecondPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuestionFourth",
                table: "SecondPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuestionSecond",
                table: "SecondPartQuizzes");

            migrationBuilder.DropColumn(
                name: "QuestionSeventh",
                table: "SecondPartQuizzes");

            migrationBuilder.RenameColumn(
                name: "QuestionThird",
                table: "SecondPartQuizzes",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "QuestionSixth",
                table: "SecondPartQuizzes",
                newName: "Answer");
        }
    }
}
