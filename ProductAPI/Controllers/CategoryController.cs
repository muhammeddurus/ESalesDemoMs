using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Services.Interface;

namespace ProductAPI.Controllers
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
        public ActionResult GetList()
        {
            return Ok(_categoryService.GetList());
        }
        
        [HttpPost]
        public ActionResult AddCategory(Category entity)
        {
            _categoryService.AddCategory(entity);
            return Ok();
        }
    }
}
