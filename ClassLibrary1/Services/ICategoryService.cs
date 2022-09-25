using ClassLibrary1.Entity;

namespace ClassLibrary1.Services;

public interface ICategoryService
{
    Task<List<Category>> GetCategoriesAsync();
    Task<bool> AddCategory(Category category);
}
