using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApp2.Entity;

namespace StoreApp2.Data.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products {get;}

        void AddProduct(Product product);
    }
}