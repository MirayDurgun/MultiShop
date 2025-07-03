using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailDetailServices
{
    public interface IProductDetailDetailService
    {
        //kategorilerle ilgili CRUD işlemleri (Oluşturma, Okuma, Güncelleme, Silme) yapmak için asenkron yöntemler içeriyor
        // Task: Bu metodun sonucu hemen dönmez, asenkron çalışır; işlem tamamlandığında sonucu döndürür
        //çünkü veritabanı gibi zaman alan işlemler yapılır; sonuç hazır olunca döner
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string id);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
    }
}
