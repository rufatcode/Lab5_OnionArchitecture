using Lab5_ONIONArxitectura.Domain.Comman;
using Lab5_ONIONArxitectura.Repository.DataContext;
using Lab5_ONIONArxitectura.Repository.Repositories.Interfaces;

namespace Lab5_ONIONArxitectura.Repository.Repositories;

public class Repository<T>:IRepository<T> where T:BaseEntity
{
  public void Create(T entity)
  {
    AppDbContext<T>.Datas.Add(entity);
  }

  public void Update(T entity)
  {
    T existEntity = AppDbContext<T>.Datas.FirstOrDefault(e => e.Id == entity.Id);
    existEntity = entity;
  }
  
  //roles->{role1,role2}
  //role1->id=1,name=admin
  //Delete(new Role(){id=1,name=admin) x
  //role->getbyId(id)
  //Dete(role)

  public void DeleteFromDb(T entity)
  {
    AppDbContext<T>.Datas.Remove(entity);
  }
  
  public void Delete(int id)
  {
    T existEntity = AppDbContext<T>.Datas.FirstOrDefault(e => e.Id == id);
    existEntity.IsActive = false;
    existEntity.DeletedAt=DateTime.Now;
  }

  public List<T> GetAll()
  {
    return AppDbContext<T>.Datas.Where(e=>e.IsActive).ToList();
  }

  public T GetById(int id)
  {
    return AppDbContext<T>.Datas.FirstOrDefault(e => e.Id == id&&e.IsActive);
  }

  public List<T> GetAllAdmin()
  {
    return AppDbContext<T>.Datas;
  }
}