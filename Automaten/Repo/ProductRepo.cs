using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Automaten.Model;

namespace Automaten.Repo
{
    internal class ProductRepo : IProductRepo
    {
        private List<Product> _products = new List<Product>();
        private readonly string _jsonFilePath = "C:\\Users\\banan\\source\\repos\\Automaten\\Automaten\\JSON\\Product.json";


        public ProductRepo()
        {
            LoadFromJson();
        }

        public void Create(string name, int price)
        {
            _products.Add(new Product(name, price));
            SaveToJson();
        }

        public Product Get(string name)
        {
            foreach (Product product in _products)
            {
                if (product.Name == name)
                { return product; }
            }
            throw new Exception("nope");
        }

        public void Update(string name, int price)
        {
            Product toUpdate = Get(name);
            toUpdate.Price = price;
        }

        public void SaveToJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(_products, options);
            File.WriteAllText(_jsonFilePath, json);
        }

        public void LoadFromJson()
        {
            string json = File.ReadAllText(_jsonFilePath);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Product> loadedProducts = JsonSerializer.Deserialize<List<Product>>(json, options);
            if (loadedProducts != null)
            {
                _products = loadedProducts;
            }
        }
    }
}
