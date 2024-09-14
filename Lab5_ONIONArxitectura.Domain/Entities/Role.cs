using Lab5_ONIONArxitectura.Domain.Comman;

namespace Lab5_ONIONArxitectura.Domain.Entities;

public class Role:BaseEntity
{
  public string Name { get; set; }
  public List<User> Users { get; set; }
}