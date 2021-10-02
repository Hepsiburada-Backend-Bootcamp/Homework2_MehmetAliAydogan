using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Category ParentCategory { get; set; }

        public virtual ICollection<Category> SubCategories { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
