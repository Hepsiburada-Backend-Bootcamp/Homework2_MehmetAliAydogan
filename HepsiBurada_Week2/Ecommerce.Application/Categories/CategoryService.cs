using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task Add(CategoryDto categoryDto)
        {
            return _categoryRepository.Add(_mapper.Map<Category>(categoryDto));
        }

        public async Task Delete(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.Delete(result);
        }

        public async Task<List<CategoryDto>> Get(Expression<Func<CategoryDto,bool>> filter)
        {
            var dtoFilter = _mapper.Map<Expression<Func<Category, bool>>>(filter);

            var result = await _categoryRepository.Get(dtoFilter);

            return _mapper.Map<List<CategoryDto>>(result);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            var result = await _categoryRepository.GetAll();

            return _mapper.Map<List<CategoryDto>>(result);
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);

            return _mapper.Map<CategoryDto>(result); ;
        }

        public Task Update(CategoryDto categoryDto)
        {
            return _categoryRepository.Update(_mapper.Map<Category>(categoryDto));
        }
    }
}
