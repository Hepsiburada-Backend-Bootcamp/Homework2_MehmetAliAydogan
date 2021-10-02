using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Categories
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int? ParentId { get; set; }
    }
}
