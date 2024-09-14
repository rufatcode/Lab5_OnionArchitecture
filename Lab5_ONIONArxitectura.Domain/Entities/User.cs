using Lab5_ONIONArxitectura.Domain.Comman;

namespace Lab5_ONIONArxitectura.Domain.Entities;

public class User:BaseEntity
{
  public string UserName { get; set; }
  public string Password { get; set; }
  public List<int> RoleIds { get; set; }
  public List<Role> Roles { get; set; }
}