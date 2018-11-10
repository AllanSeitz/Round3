using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Round3.Models;


namespace Round3
{
  public partial class StatesContext : DbContext
  {
    public StatesContext()
    {
    }

    public StatesContext(DbContextOptions<StatesContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=UsStates");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<States>().HasData(
          new States { Id = -1, StateName = "Florida", AverageSalary = 57244, CostOfLiving = 99, AveragePopulation = 21310000, AdjustedIncome = 64417000, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -2, StateName = "Texas", AverageSalary = 60325, CostOfLiving = 90.7, AveragePopulation = 21310000, AdjustedIncome = 64417000, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -3, StateName = "Virginia", AverageSalary = 84390, CostOfLiving = 100.2, AveragePopulation = 21310000, AdjustedIncome = 64417000, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -4, StateName = "Utah", AverageSalary = 53707, CostOfLiving = 92.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -5, StateName = "Illinois", AverageSalary = 69697, CostOfLiving = 95.5, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -6, StateName = "Wyoming", AverageSalary = 73787, CostOfLiving = 91.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -7, StateName = "Michigan", AverageSalary = 69998, CostOfLiving = 88.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -8, StateName = "Missouri", AverageSalary = 72055, CostOfLiving = 90.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -9, StateName = "Kansas", AverageSalary = 71709, CostOfLiving = 90.4, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -10, StateName = "Tennessee", AverageSalary = 71223, CostOfLiving = 89.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -11, StateName = "Ohio", AverageSalary = 54398, CostOfLiving = 93, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -12, StateName = "North Carolina", AverageSalary = 69362, CostOfLiving = 94.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -13, StateName = "Oklahoma", AverageSalary = 67282, CostOfLiving = 88.6, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -14, StateName = "Colorado", AverageSalary = 68037, CostOfLiving = 102.1, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -15, StateName = "Washington", AverageSalary = 80595, CostOfLiving = 107.1, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -16, StateName = "Indiana", AverageSalary = 56129, CostOfLiving = 87.9, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -17, StateName = "Idaho", AverageSalary = 66739, CostOfLiving = 89.6, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -18, StateName = "Alabama", AverageSalary = 67696, CostOfLiving = 91.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -19, StateName = "Arizona", AverageSalary = 65064, CostOfLiving = 98.1, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -20, StateName = "Mississippi", AverageSalary = 62715, CostOfLiving = 86, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -21, StateName = "Minnesota", AverageSalary = 68966, CostOfLiving = 101.1, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -22, StateName = "Deleware", AverageSalary = 60514, CostOfLiving = 102.6, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -23, StateName = "Pennsylvania", AverageSalary = 64185, CostOfLiving = 102.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -24, StateName = "California", AverageSalary = 60863, CostOfLiving = 134.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -25, StateName = "South Carolina", AverageSalary = 82260, CostOfLiving = 100.5, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -26, StateName = "Georgia", AverageSalary = 62468, CostOfLiving = 91.4, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -27, StateName = "New Jersey", AverageSalary = 62756, CostOfLiving = 121, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -28, StateName = "Nevada", AverageSalary = 53728, CostOfLiving = 104.5, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -29, StateName = "Louisiana", AverageSalary = 53728, CostOfLiving = 94.4, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -30, StateName = "Kentucky", AverageSalary = 44725, CostOfLiving = 90.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -31, StateName = "Maryland", AverageSalary = 53810, CostOfLiving = 125, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -32, StateName = "Iowa", AverageSalary = 53728, CostOfLiving = 90.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -33, StateName = "New York", AverageSalary = 71896, CostOfLiving = 135.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -34, StateName = "New Mexico", AverageSalary = 53728, CostOfLiving = 95.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -35, StateName = "Wisconsin", AverageSalary = 58434, CostOfLiving = 96.9, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -36, StateName = "New Hampshire", AverageSalary = 53728, CostOfLiving = 119.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -37, StateName = "North Dakota", AverageSalary = 53728, CostOfLiving = 98.9, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -38, StateName = "Maine", AverageSalary = 53728, CostOfLiving = 112, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -39, StateName = "Nebraska", AverageSalary = 53728, CostOfLiving = 91.3, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -40, StateName = "Massachusetts", AverageSalary = 77321, CostOfLiving = 134.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -41, StateName = "South Dakota", AverageSalary = 53728, CostOfLiving = 102.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -42, StateName = "Arkansas", AverageSalary = 53728, CostOfLiving = 88.5, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -43, StateName = "D.C.", AverageSalary = 53728, CostOfLiving = 149.2, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -44, StateName = "Oregon", AverageSalary = 53728, CostOfLiving = 115.4, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -45, StateName = "Montana", AverageSalary = 53728, CostOfLiving = 100.8, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -46, StateName = "Connecticut", AverageSalary = 62258, CostOfLiving = 130.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -47, StateName = "Vermont", AverageSalary = 53728, CostOfLiving = 122.4, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -48, StateName = "Rhode Island", AverageSalary = 57342, CostOfLiving = 122.1, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -49, StateName = "Alaska", AverageSalary = 53728, CostOfLiving = 131.6, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" },
          new States { Id = -50, StateName = "West Virginia", AverageSalary = 36806, CostOfLiving = 95.7, AveragePopulation = 21310000, AdjustedIncome = 64417, AverageAge = 43, AverageTemp = 67.6, TaxRate = 0, GrowthRate = 15, ImgUrl = "http://s3.amazonaws.com/wmfeimages/wp-content/uploads/2017/07/10162234/MAP-OF-FLORIDA-743x5001.png" }



);
    }
    public DbSet<States> States { get; set; }

  }
}
