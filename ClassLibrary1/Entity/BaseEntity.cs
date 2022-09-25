namespace ClassLibrary1.Entity;

public class BaseEntity
{
    public Guid Id { get; set; }
    public virtual DateTime UpdateDatime { get; set; }
}
