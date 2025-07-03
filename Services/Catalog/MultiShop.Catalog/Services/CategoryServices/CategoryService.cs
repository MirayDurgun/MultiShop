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
            await _categoryCollection.InsertOneAsync(value);
            //MongoDB .NET Driver'da kullanılan bir metottur. 
            //MongoDB'de bir belge (document) eklemek için kullanılır ve bu işlem asenkron (async) şekilde yapılır

        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryId == id);
            //CategoryId'si id'ye eşit olan belgeyi bul ve sil.
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            // x => true ifadesi: Tüm kayıtları seç 
            return _mapper.Map<List<ResultCategoryDto>>(values);
            // Gelen kategori listesini DTO tipine dönüştür
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdCategoryDto>(values);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryId == updateCategoryDto.CategoryId, values);
        }
    }
}
