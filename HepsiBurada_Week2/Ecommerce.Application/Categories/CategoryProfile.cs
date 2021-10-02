using AutoMapper;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
