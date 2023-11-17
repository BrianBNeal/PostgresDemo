namespace PostgresDemo.Models;


public abstract class BaseEntity<T> where T : struct
{
    public T Id { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateUpdated { get; set; }
}

public abstract class BaseEntity : BaseEntity<int>
{
    
}
