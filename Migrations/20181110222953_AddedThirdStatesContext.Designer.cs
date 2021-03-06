﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Round3;

namespace Round3.Migrations
{
    [DbContext(typeof(StatesContext))]
    [Migration("20181110222953_AddedThirdStatesContext")]
    partial class AddedThirdStatesContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Round3.Models.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AdjustedIncome");

                    b.Property<double>("AverageAge");

                    b.Property<double>("AveragePopulation");

                    b.Property<double>("AverageSalary");

                    b.Property<double>("AverageTemp");

                    b.Property<double>("CostOfLiving");

                    b.Property<double>("GrowthRate");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("StateName");

                    b.Property<double>("TaxRate");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new { Id = -1, AdjustedIncome = 64417000.0, AverageAge = 43.0, AveragePopulation = 21310000.0, AverageSalary = 57244.0, AverageTemp = 67.6, CostOfLiving = 99.0, GrowthRate = 15.0, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", StateName = "Florida", TaxRate = 0.0 },
                        new { Id = -2, AdjustedIncome = 64417000.0, AverageAge = 43.0, AveragePopulation = 21310000.0, AverageSalary = 60325.0, AverageTemp = 67.6, CostOfLiving = 90.7, GrowthRate = 15.0, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", StateName = "Texas", TaxRate = 0.0 },
                        new { Id = -3, AdjustedIncome = 64417000.0, AverageAge = 43.0, AveragePopulation = 21310000.0, AverageSalary = 84390.0, AverageTemp = 67.6, CostOfLiving = 100.2, GrowthRate = 15.0, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png", StateName = "Virginia", TaxRate = 0.0 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
