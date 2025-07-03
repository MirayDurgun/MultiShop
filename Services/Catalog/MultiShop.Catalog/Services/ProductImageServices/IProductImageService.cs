using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        //kategorilerle ilgili CRUD işlemleri (Oluşturma, Okuma, Güncelleme, Silme) yapmak için asenkron yöntemler içeriyor
        // Task: Bu metodun sonucu hemen dönmez, asenkron çalışır; işlem tamamlandığında sonucu döndürür
        //çünkü veritabanı gibi zaman alan işlemler yapılır; sonuç hazır olunca döner
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
    }
}
