using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        //MongoDB koleksiyonlarını temsil eden bir arayüzdür
        //yapı sayesinde belirli bir koleksiyondaki (tablodaki) belgelere (documents) erişim sağlanır.
        //Veritabanıyla CRUD işlemleri (Create, Read, Update, Delete) yapmak için temel bir araçtır.
        //MongoDB'de Category adında bir koleksiyona (tabloya) erişmek için tanımlanmıştır
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
