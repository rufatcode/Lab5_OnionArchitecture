using Lab5_ONIONArxitectura.Domain.Entities;
using Lab5_ONIONArxitectura.Repository.Repositories;
using Lab5_ONIONArxitectura.Service.DynamicObject;
using Lab5_ONIONArxitectura.Service.Services.Interfaces;

namespace Lab5_ONIONArxitectura.Service.Services;

public class RoleService:IRoleService
{
  private readonly RoleRepository _roleRepository;

  public RoleService(RoleRepository roleRepository)
  {
    _roleRepository =roleRepository;
  }
  public ResponseObject Create(Role entity)
  {
    if (_roleRepository.GetByName(entity.Name)!=null)
    {
      return new ResponseObject()
      {
        StatusCode = 400,
        Message = $"{entity.Name} has already created"
      };
    }
    _roleRepository.Create(entity);

    return new ResponseObject()
    {
      StatusCode = 200,
      Message = $"{entity.Name} has successfully created"
    };
  }

  public ResponseObject Update(Role entity)
  {
    throw new NotImplementedException();
  }

  public ResponseObject Delete(int id)
  {
    if (GetById(id)==null)
    {
      return new ResponseObject()
      {
        StatusCode = 400,
        Message = $"Role does not exist"
      };
    }
    _roleRepository.Delete(id);
    return new ResponseObject()
    {
      StatusCode = 200,
      Message = $"Role has successfully deleted"
    };
  }

  public ResponseObject DeleteFromDb(Role entity)
  {
    Role existRole = GetById(entity.Id);
    if (existRole==null)
    {
      return new ResponseObject()
      {
        StatusCode = 400,
        Message = $"Role does not exist"
      };
    }
    _roleRepository.DeleteFromDb(existRole);
    return new ResponseObject()
    {
      StatusCode = 200,
      Message = $"Role has successfully deleted from db"
    };
  }

  public List<Role> GetAll()
  {
    return _roleRepository.GetAll();
  }

  public Role GetById(int id)
  {
    return _roleRepository.GetById(id);
  }

  public List<Role> GetAllAdmin()
  {
    return _roleRepository.GetAllAdmin();
  }
}