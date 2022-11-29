using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        //get products from DB
        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct() //shows schema in swagger/index.html
        {
            //access products in db
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
