namespace MultiShop.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        //MongoDB ile bağlantı için gerekli olan ayarları içerecek sınıfların uygulaması gereken bir yapıdır.
        //CRUD işlemleri için gerekli
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; }

        // MongoDB bağlantı cümlesi (sunucu adresi, port, kullanıcı vs. bilgileri içerir)
        public string ConnectionStrings { get; set; }


        // Bağlanılacak MongoDB veritabanının adı
        public string DatabaseName { get; set; }
    }
}
