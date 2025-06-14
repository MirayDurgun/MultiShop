using MultiShop.Catalog.Dtos.CategoryDtos;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        //kategorilerle ilgili CRUD işlemleri (Oluşturma, Okuma, Güncelleme, Silme) yapmak için asenkron yöntemler içeriyor
        // Task -> Asenkron olarak çalışır ve işlem tamamlandığında herhangi bir veri döndürmez (void)
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
