using Kavan.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kavan.Service
{
    /// <summary>
    /// اینترفیس محصول
    /// </summary>
    public interface IProductService
    {
        public void Create(Product product);
        public Product GetById(int productId);
        public IEnumerable<Product> GetAll();
        public Task Delete(int productId);
        public void Update(Product newProduct);
    }
}
