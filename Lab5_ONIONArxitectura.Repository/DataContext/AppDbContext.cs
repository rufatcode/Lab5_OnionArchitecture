using Lab5_ONIONArxitectura.Domain.Comman;

namespace Lab5_ONIONArxitectura.Repository.DataContext;

public static class AppDbContext<T> where T:BaseEntity
{
  public static List<T> Datas { get; set; } = new List<T>();


}