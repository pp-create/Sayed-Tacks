using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveysId",
                table: "Details_Task_TBL");

            migrationBuilder.AddColumn<int>(
                name: "Details_TaskID",
                table: "SurveysVistor_TBL",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details_TaskID",
                table: "SurveysVistor_TBL");

            migrationBuilder.AddColumn<int>(
                name: "SurveysId",
                table: "Details_Task_TBL",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
