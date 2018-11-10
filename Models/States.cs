namespace Round3.Models
{
  public class States
  {
    public int Id { get; set; }
    public string StateName { get; set; }
    public double AverageSalary { get; set; }
    public double CostOfLiving { get; set; }
    public double AdjustedIncome { get; set; }
    public double AveragePopulation { get; set; }
    public double AverageAge { get; set; }
    public double AverageTemp { get; set; }
    public double TaxRate { get; set; }
    public double GrowthRate { get; set; }
    public string ImgUrl { get; set; }
  }
}