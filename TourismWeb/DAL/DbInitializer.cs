using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismWeb.Models;

namespace TourismWeb.DAL
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {Name="AAAA", Phone="1111111",Address="1111111"},
                new Customer {Name="BBBB", Phone="1111111",Address="1111111"},
                new Customer {Name="CCCC", Phone="3333333",Address="3333333"}
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order {Title="ORDERA", CustomerID=1}
            };

            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();
        }

    }

}
