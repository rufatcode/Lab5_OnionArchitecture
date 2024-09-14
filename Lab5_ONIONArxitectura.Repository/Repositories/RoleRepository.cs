using Lab5_ONIONArxitectura.Domain.Entities;
using Lab5_ONIONArxitectura.Repository.DataContext;
using Lab5_ONIONArxitectura.Repository.Repositories.Interfaces;

namespace Lab5_ONIONArxitectura.Repository.Repositories;

public class RoleRepository:Repository<Role>,IRoleRepository
{
  private IRoleRepository _roleRepositoryImplementation;
  public Role GetByName(string name)
  {
    return AppDbContext<Role>.Datas.FirstOrDefault(r => r.Name == name&&r.IsActive);
  }
}