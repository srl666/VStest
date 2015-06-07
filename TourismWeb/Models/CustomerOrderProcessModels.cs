using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismWeb.Models
{
    class CustomerOrderProcessModels
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Process> Processs { get; set; }
    }
}
