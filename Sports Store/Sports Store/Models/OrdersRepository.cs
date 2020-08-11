using Microsoft.EntityFrameworkCore;
using Sports_Store.Data;
using System.Collections.Generic;
using System.Linq;

namespace Sports_Store.Models
{
    public class OrdersRepository : IOrdersRepository
    {
        private AppDbContext context;

        public OrdersRepository(AppDbContext ctx) => context = ctx;

        public IEnumerable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public Order GetOrder(long key)
        {
            return context.Orders
            .Include(o => o.Lines)
            .First(o => o.Id == key);
        }

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
