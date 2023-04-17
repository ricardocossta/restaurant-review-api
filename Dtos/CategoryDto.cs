﻿using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class CategoryDto
    {
        public CategoryDto(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
