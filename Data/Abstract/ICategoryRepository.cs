using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApp2.Entity;

namespace StoreApp2.Data.Abstract
{
    public interface ICategoryRepository
    {
          IQueryable<Category> Categories {get;}

        void AddCategory(Category category);
    }
}