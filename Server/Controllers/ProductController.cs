using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazor.Server.Controllers
{
    public class ProductController : BaseController
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await _context.Products.ToListAsync();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
