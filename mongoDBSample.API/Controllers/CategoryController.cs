using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mongoDBSample.Data.Entity;
using mongoDBSample.Service.Abstract;

namespace mongoDBSample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = categoryService.Get();
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var result = categoryService.GetByIdAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category data)
        {
            var result = categoryService.AddAsync(data).Result;
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Category data)
        {
            var result = categoryService.UpdateAsync(id, data).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var result = categoryService.DeleteAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
