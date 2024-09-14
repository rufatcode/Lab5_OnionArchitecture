namespace Lab5_ONIONArxitectura.Domain.Comman;

public abstract class BaseEntity
{
  private static int _count = 0;
  public  int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? UpdatedAt { get; set; }
  public DateTime? DeletedAt { get; set; }
  public bool IsActive { get; set; }
  public BaseEntity()
  {
    Id = ++_count;
    CreatedAt = DateTime.Now;
    IsActive = true;
  }

  
}