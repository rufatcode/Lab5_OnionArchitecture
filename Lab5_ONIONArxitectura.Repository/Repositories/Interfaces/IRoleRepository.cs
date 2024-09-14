using Lab5_ONIONArxitectura.Domain.Entities;

namespace Lab5_ONIONArxitectura.Repository.Repositories.Interfaces;

public interface IRoleRepository:IRepository<Role>
{
  public Role GetByName(string name);
}