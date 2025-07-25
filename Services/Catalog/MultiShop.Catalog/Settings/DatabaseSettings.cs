﻿namespace MultiShop.Catalog.Settings
{
    public class DatabaseSettings:IDatabaseSettings
    {
        //Her database interfacenin bir sınıfı olmalı
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; }
        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }
    }
}
