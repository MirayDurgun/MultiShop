using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductService
    {
        //kategorilerle ilgili CRUD işlemleri (Oluşturma, Okuma, Güncelleme, Silme) yapmak için asenkron yöntemler içeriyor
        // Task: Bu metodun sonucu hemen dönmez, asenkron çalışır; işlem tamamlandığında sonucu döndürür
        //çünkü veritabanı gibi zaman alan işlemler yapılır; sonuç hazır olunca döner
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
