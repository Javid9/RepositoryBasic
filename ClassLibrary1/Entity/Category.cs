
namespace ClassLibrary1.Entity;

public class Category:BaseEntity
{
    [NotMapped]
    public override DateTime UpdateDatime { get => base.UpdateDatime; set => base.UpdateDatime = value; }
   
}
