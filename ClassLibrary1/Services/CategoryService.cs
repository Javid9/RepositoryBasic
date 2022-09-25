using ClassLibrary1.Entity;
using ClassLibrary1.Repository;
using Microsoft.Extensions.Logging;

namespace ClassLibrary1.Services;

public class CategoryService: ICategoryService
{
    readonly ICategoryRepository _categoryRepository;
    readonly ILogger<CategoryService> _logger;

    public CategoryService(ICategoryRepository categoryRepository, ILogger<CategoryService> logger)
    {
        _categoryRepository = categoryRepository;
        _logger = logger;
    }

    public async Task<bool> AddCategory(Category category)
    {
        try
        {
            _logger.LogInformation("Categori ekleme islemi baslatildi");
            await _categoryRepository.CreateAsync(category);

            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError("beklemedik bir hata meydana geldi hata kodu {0}", ex.Message);
            throw new Exception(ex.Message);    
        }

    }

    public async Task<List<Category>> GetCategoriesAsync()
    {
        return (await _categoryRepository.GetAllAsync()).ToList();
    }   





}
