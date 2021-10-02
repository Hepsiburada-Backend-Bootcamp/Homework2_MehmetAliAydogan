using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }


    }
}
