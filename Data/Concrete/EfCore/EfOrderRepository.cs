using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApp2.Data.Abstract;
using StoreApp2.Data.Concrete.EfCore;
using StoreApp2.Entity;

namespace StoreApp2.Data.Concrete
{
    public class EfOrderRepository : IOrderRepository
    {
        private IdentityContext _context;

        public EfOrderRepository(IdentityContext context)
        {
            _context = context;
        }
        public IQueryable<Order> Orders => _context.Orders;

        public void AddOrder(Order order)
        {
           _context.Orders.Add(order);
            _context.SaveChanges();
        
        }
    }
}