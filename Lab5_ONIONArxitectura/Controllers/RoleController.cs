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
   Console.WriteLine("Enter Phone");
   role.Phone= Console.ReadLine();
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
      Console.WriteLine($"{role.Id}.{role.Name}\nPhone:{role.Phone}\nCreatedAt:{role.CreatedAt}\nDetedAt:{role.DeletedAt}\nUpdatedAt:{role.UpdatedAt}\nActive:{role.IsActive}");
      Console.WriteLine("----------------");
    }
  }

  public void Update()
  {
    AddId:Console.WriteLine("Enter roleId for update");
    string strId = Console.ReadLine();
    if (!int.TryParse(strId,out int id))
    {
      Console.WriteLine("Id is not valid");
      goto AddId;
    }

    Role role = new();
    Console.WriteLine("Enter role name");
    role.Name = Console.ReadLine();
    Console.WriteLine("Enter Role Phone");
    role.Phone = Console.ReadLine();
    role.Id = id;
    ResponseObject responseObject= _roleService.Update(role);
    Console.WriteLine($"{responseObject.StatusCode}:{responseObject.Message}");
    if (responseObject.StatusCode==400)
    {
      goto AddId;
    }

  }

  public void GetAll()
  {
    List<Role> roles = _roleService.GetAll();
    foreach (Role role in roles)
    {
      Console.WriteLine("----------------");
      Console.WriteLine($"{role.Id}.{role.Name}\nPhone:{role.Phone}\nCreatedAt:{role.CreatedAt}\nDetedAt:{role.DeletedAt}\nUpdatedAt:{role.UpdatedAt}\nActive:{role.IsActive}");
      Console.WriteLine("----------------");
    }
    
  }

  public void GetById()
  {
    AddId:Console.WriteLine("Enter role id");
    string strId = Console.ReadLine();
    if (!int.TryParse(strId, out int id))
    {
      Console.WriteLine("Id is not valid");
      goto AddId;
    }

    Role role = _roleService.GetById(id);
    Console.WriteLine($"{role.Id}.{role.Name}\nPhone:{role.Phone}\nCreatedAt:{role.CreatedAt}\nDetedAt:{role.DeletedAt}\nUpdatedAt:{role.UpdatedAt}\nActive:{role.IsActive}");

  }

  public void Delete()
  {
    AddId:Console.WriteLine("Enter role id");
    string strId = Console.ReadLine();
    if (!int.TryParse(strId, out int id))
    {
      Console.WriteLine("Id is not valid");
      goto AddId;
    }

    ResponseObject responseObject = _roleService.Delete(id);
    Console.WriteLine($"{responseObject.StatusCode}:{responseObject.Message}");
    if (responseObject.StatusCode==400)
    {
      goto AddId;
    }
  }
  public void DeleteFromDb()
  {
    AddId:Console.WriteLine("Enter role id");
    string strId = Console.ReadLine();
    if (!int.TryParse(strId, out int id))
    {
      Console.WriteLine("Id is not valid");
      goto AddId;
    }

    ResponseObject responseObject = _roleService.DeleteFromDb(id);
    Console.WriteLine($"{responseObject.StatusCode}:{responseObject.Message}");
    if (responseObject.StatusCode==400)
    {
      goto AddId;
    }
  }
}