﻿using DPA.Store.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPA.Store.API.Controllers
{
    [Route("api/[controller]")] //define la ruta
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryRepository.GetAll();
            return Ok(categories);
        }

    }
}
