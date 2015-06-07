using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TourismWeb.Models
{
    public class Process
    {
        [Key, ForeignKey("Customer")]
        public int ProcessID { get; set; }
        public string ProcessName { get; set; }
        public int OrderID { get; set; }

        public virtual Order Order { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
