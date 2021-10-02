using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Categories
{
    public interface ICategoryService
    {
        public Task Add(CategoryDto categoryDto);
        public Task<List<CategoryDto>> Get(Expression<Func<CategoryDto, bool>> filter);
        public Task<List<CategoryDto>> GetAll();
        public Task<CategoryDto> GetById(int id);
        public Task Delete(int id);
        public Task Update(CategoryDto categoryDto);

    }
}
