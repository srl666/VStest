using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourismWeb.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Title { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Process> Processs { get; set; }
    }
}
