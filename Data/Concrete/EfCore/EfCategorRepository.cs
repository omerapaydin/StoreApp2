using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApp2.Data.Abstract;
using StoreApp2.Entity;

namespace StoreApp2.Data.Concrete.EfCore
{
    public class EfCategorRepository : ICategoryRepository
    {

        private IdentityContext _context;
         public EfCategorRepository(IdentityContext context)
        {
            _context = context;
        }
        public IQueryable<Category> Categories => _context.Categories;

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}