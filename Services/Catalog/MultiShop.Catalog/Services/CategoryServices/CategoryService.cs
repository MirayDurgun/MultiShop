using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

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

        public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            // 3 aşama vardır. 1.Bağlantı 2.Databse, 3.Tablo
            //1. Bağlantı
            var client = new MongoClient(_databaseSettings.ConnectionStrings); //connaction stringse erişim sağlıyoruz
                                                                               //MongoDB'ye bağlanır.

            //2. Databse
            var database = client.GetDatabase(_databaseSettings.DatabaseName); //client.GetDatabase veri tabanına erişim sağlar
                                                                               //Bağlanılacak veritabanının adını içerir

            //3. Tablo
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            // Category koleksiyonuna erişim sağlar.

            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
           // await
            
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
