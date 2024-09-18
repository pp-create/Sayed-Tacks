using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area_TBL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_TBL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citys_TBL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    governorateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys_TBL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details_Task_TBL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveysId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<int>(type: "int", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details_Task_TBL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "governorate_TBL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governorate_TBL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Park_TBL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park_TBL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveysVistor_TBL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Think = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveysVistor_TBL", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area_TBL");

            migrationBuilder.DropTable(
                name: "Citys_TBL");

            migrationBuilder.DropTable(
                name: "Details_Task_TBL");

            migrationBuilder.DropTable(
                name: "governorate_TBL");

            migrationBuilder.DropTable(
                name: "Park_TBL");

            migrationBuilder.DropTable(
                name: "SurveysVistor_TBL");
        }
    }
}
