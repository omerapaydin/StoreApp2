using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApp2.Entity;

namespace StoreApp2.Data.Abstract
{
    public interface IOrderRepository
    {
          IQueryable<Order>  Orders { get; }

        void AddOrder(Order Order);
    }
}