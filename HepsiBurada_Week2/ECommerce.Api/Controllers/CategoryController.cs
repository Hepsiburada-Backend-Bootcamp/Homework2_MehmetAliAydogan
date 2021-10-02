using Ecommerce.Application;
using Ecommerce.Application.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _categoryService.GetAll();

            return Ok(new 
            {   status = true,
                data = result,
                errors = ""
            });
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDto categoryDTO)
        {
           
            await _categoryService.Add(categoryDTO);

            return Ok(new
            {
                status = true,
                errors = ""
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _categoryService.GetById(id);

            return Ok(new { status = true, data = result, errors = "" });
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok(new { status = true, errors = "" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CategoryDto categoryDto)
        {
            _categoryService.Update(categoryDto);
            return Ok(new { status = true, errors = "" });
        }
    }
}
