using Microsoft.EntityFrameworkCore.Migrations;

namespace Round3.Migrations
{
    public partial class fiftystates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "AdjustedIncome", "AverageAge", "AveragePopulation", "AverageSalary", "AverageTemp", "CostOfLiving", "GrowthRate", "ImgUrl", "StateName", "TaxRate" },
                values: new object[,]
                {
                    { -4, 64417.0, 43.0, 21310000.0, 53707.0, 67.6, 92.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Utah", 0.0 },
                    { -29, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 94.4, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Louisiana", 0.0 },
                    { -30, 64417.0, 43.0, 21310000.0, 44725.0, 67.6, 90.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Kentucky", 0.0 },
                    { -31, 64417.0, 43.0, 21310000.0, 53810.0, 67.6, 125.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Maryland", 0.0 },
                    { -32, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 90.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Iowa", 0.0 },
                    { -33, 64417.0, 43.0, 21310000.0, 71896.0, 67.6, 135.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "New York", 0.0 },
                    { -34, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 95.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "New Mexico", 0.0 },
                    { -35, 64417.0, 43.0, 21310000.0, 58434.0, 67.6, 96.9, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Wisconsin", 0.0 },
                    { -36, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 119.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "New Hampshire", 0.0 },
                    { -37, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 98.9, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "North Dakota", 0.0 },
                    { -28, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 104.5, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Nevada", 0.0 },
                    { -38, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 112.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Maine", 0.0 },
                    { -40, 64417.0, 43.0, 21310000.0, 77321.0, 67.6, 134.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Massachusetts", 0.0 },
                    { -41, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 102.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "South Dakota", 0.0 },
                    { -42, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 88.5, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Arkansas", 0.0 },
                    { -43, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 149.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "D.C.", 0.0 },
                    { -44, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 115.4, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Oregon", 0.0 },
                    { -45, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 100.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Montana", 0.0 },
                    { -46, 64417.0, 43.0, 21310000.0, 62258.0, 67.6, 130.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Connecticut", 0.0 },
                    { -47, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 122.4, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Vermont", 0.0 },
                    { -48, 64417.0, 43.0, 21310000.0, 57342.0, 67.6, 122.1, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Rhode Island", 0.0 },
                    { -39, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 91.3, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Nebraska", 0.0 },
                    { -49, 64417.0, 43.0, 21310000.0, 53728.0, 67.6, 131.6, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Alaska", 0.0 },
                    { -27, 64417.0, 43.0, 21310000.0, 62756.0, 67.6, 121.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "New Jersey", 0.0 },
                    { -25, 64417.0, 43.0, 21310000.0, 82260.0, 67.6, 100.5, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "South Carolina", 0.0 },
                    { -5, 64417.0, 43.0, 21310000.0, 69697.0, 67.6, 95.5, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Illinois", 0.0 },
                    { -6, 64417.0, 43.0, 21310000.0, 73787.0, 67.6, 91.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Wyoming", 0.0 },
                    { -7, 64417.0, 43.0, 21310000.0, 69998.0, 67.6, 88.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Michigan", 0.0 },
                    { -8, 64417.0, 43.0, 21310000.0, 72055.0, 67.6, 90.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Missouri", 0.0 },
                    { -9, 64417.0, 43.0, 21310000.0, 71709.0, 67.6, 90.4, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Kansas", 0.0 },
                    { -10, 64417.0, 43.0, 21310000.0, 71223.0, 67.6, 89.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Tennessee", 0.0 },
                    { -11, 64417.0, 43.0, 21310000.0, 54398.0, 67.6, 93.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Ohio", 0.0 },
                    { -12, 64417.0, 43.0, 21310000.0, 69362.0, 67.6, 94.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "North Carolina", 0.0 },
                    { -13, 64417.0, 43.0, 21310000.0, 67282.0, 67.6, 88.6, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Oklahoma", 0.0 },
                    { -26, 64417.0, 43.0, 21310000.0, 62468.0, 67.6, 91.4, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Georgia", 0.0 },
                    { -14, 64417.0, 43.0, 21310000.0, 68037.0, 67.6, 102.1, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Colorado", 0.0 },
                    { -16, 64417.0, 43.0, 21310000.0, 56129.0, 67.6, 87.9, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Indiana", 0.0 },
                    { -17, 64417.0, 43.0, 21310000.0, 66739.0, 67.6, 89.6, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Idaho", 0.0 },
                    { -18, 64417.0, 43.0, 21310000.0, 67696.0, 67.6, 91.2, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Alabama", 0.0 },
                    { -19, 64417.0, 43.0, 21310000.0, 65064.0, 67.6, 98.1, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Arizona", 0.0 },
                    { -20, 64417.0, 43.0, 21310000.0, 62715.0, 67.6, 86.0, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Mississippi", 0.0 },
                    { -21, 64417.0, 43.0, 21310000.0, 68966.0, 67.6, 101.1, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Minnesota", 0.0 },
                    { -22, 64417.0, 43.0, 21310000.0, 60514.0, 67.6, 102.6, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Deleware", 0.0 },
                    { -23, 64417.0, 43.0, 21310000.0, 64185.0, 67.6, 102.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Pennsylvania", 0.0 },
                    { -24, 64417.0, 43.0, 21310000.0, 60863.0, 67.6, 134.8, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "California", 0.0 },
                    { -15, 64417.0, 43.0, 21310000.0, 80595.0, 67.6, 107.1, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "Washington", 0.0 },
                    { -50, 64417.0, 43.0, 21310000.0, 36806.0, 67.6, 95.7, 15.0, "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", "West Virginia", 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: -4);
        }
    }
}
