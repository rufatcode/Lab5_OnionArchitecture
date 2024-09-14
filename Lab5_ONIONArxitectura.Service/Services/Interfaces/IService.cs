using Lab5_ONIONArxitectura.Domain.Comman;
using Lab5_ONIONArxitectura.Service.DynamicObject;

namespace Lab5_ONIONArxitectura.Service.Services.Interfaces;

public interface IService<T>where T:BaseEntity
{
  public ResponseObject Create(T entity);
  public ResponseObject Update(T entity);
  public ResponseObject Delete(int id);
  public ResponseObject DeleteFromDb(int id);
  public List<T> GetAll();
  public T GetById(int id);
  public List<T> GetAllAdmin();
}