using Supermarket_mvp.Models;
using System.Collections.Generic;

namespace Supermarket_mvp._Repositories
{
    internal interface IProductRepository
    {
        int ProductId { get; set; }
        void Add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);
    }
}
