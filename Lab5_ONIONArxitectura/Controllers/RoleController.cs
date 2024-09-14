using Lab5_ONIONArxitectura.Domain.Entities;
using Lab5_ONIONArxitectura.Repository.Repositories;
using Lab5_ONIONArxitectura.Service.DynamicObject;
using Lab5_ONIONArxitectura.Service.Services;
using Lab5_ONIONArxitectura.Service.Services.Interfaces;

namespace Lab5_ONIONArxitectura.Controllers;

public class RoleController
{
  private readonly IRoleService _roleService;

  public RoleController()
  {
    _roleService = new RoleService(new RoleRepository());
  }

  public void Create()
  {
    AddName:Console.WriteLine("Enter Role Name");
    Role role = new();
   role.Name= Console.ReadLine();
   ResponseObject responseObject = _roleService.Create(role);
   if (responseObject.StatusCode==400)
   {
     Console.WriteLine($"{responseObject.StatusCode}:{responseObject.Message}");
     goto AddName;
   }

   Console.WriteLine($"{responseObject.StatusCode}:{responseObject.Message}");
  }

  public void GetAllByAdmin()
  {
    List<Role> roles = _roleService.GetAllAdmin();

    foreach (Role role in roles)
    {
      Console.WriteLine("----------------");
      Console.WriteLine($"{role.Id}.{role.Name}\nCreatedAt:{role.CreatedAt}\nDetedAt:{role.DeletedAt}\nUpdatedAt:{role.UpdatedAt}\nActive:{role.IsActive}");
      Console.WriteLine("----------------");
    }
  }
}