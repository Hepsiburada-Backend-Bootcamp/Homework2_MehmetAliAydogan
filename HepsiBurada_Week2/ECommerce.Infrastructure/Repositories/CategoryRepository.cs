using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceDbContext dbContext) : base(dbContext)
        {

        }
    }
}
