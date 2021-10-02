using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }

        public double TotalPrice { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<OrderItem> Orders { get; set; }

    }
}
