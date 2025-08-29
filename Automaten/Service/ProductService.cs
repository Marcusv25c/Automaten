using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Repo;

namespace Automaten.Service
{
    internal class ProductService
    {
        private IProductRepo _iProductRepo;

        public ProductService(IProductRepo productRepo)
        {
            _iProductRepo = productRepo;
        }

        public void Create(string name, int price)
        {
            _iProductRepo.Create(name, price);
        }
    }
}
