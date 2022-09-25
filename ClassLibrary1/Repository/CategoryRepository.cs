using ClassLibrary1.Entity;
namespace ClassLibrary1.Repository;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(DbContext context) : base(context)
    {

    }
}
