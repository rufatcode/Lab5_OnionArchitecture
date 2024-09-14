using Lab5_ONIONArxitectura.Domain.Comman;

namespace Lab5_ONIONArxitectura.Repository.Repositories.Interfaces;

public interface IRepository<T>
{
  public void Create(T entity);
  public void Update(T entity);
  public void Delete(int id);
  public void DeleteFromDb(T entity);
  public List<T> GetAll();
  public T GetById(int id);
  public List<T> GetAllAdmin();
  
}