using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Round3.Migrations
{
    public partial class AddedThirdStatesContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    StateName = table.Column<string>(nullable: true),
                    AverageSalary = table.Column<double>(nullable: false),
                    CostOfLiving = table.Column<double>(nullable: false),
                    AdjustedIncome = table.Column<double>(nullable: false),
                    AveragePopulation = table.Column<double>(nullable: false),
                    AverageAge = table.Column<double>(nullable: false),
                    AverageTemp = table.Column<double>(nullable: false),
                    TaxRate = table.Column<double>(nullable: false),
                    GrowthRate = table.Column<double>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "AdjustedIncome", "AverageAge", "AveragePopulation", "AverageSalary", "AverageTemp", "CostOfLiving", "GrowthRate", "ImgUrl", "StateName", "TaxRate" },
                values: new object[] { -1, 64417000.0, 43.0, 21310000.0, 57244.0, 67.6, 99.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Florida", 0.0 });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "AdjustedIncome", "AverageAge", "AveragePopulation", "AverageSalary", "AverageTemp", "CostOfLiving", "GrowthRate", "ImgUrl", "StateName", "TaxRate" },
                values: new object[] { -2, 64417000.0, 43.0, 21310000.0, 60325.0, 67.6, 90.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Texas", 0.0 });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "AdjustedIncome", "AverageAge", "AveragePopulation", "AverageSalary", "AverageTemp", "CostOfLiving", "GrowthRate", "ImgUrl", "StateName", "TaxRate" },
                values: new object[] { -3, 64417000.0, 43.0, 21310000.0, 84390.0, 67.6, 100.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Virginia", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
