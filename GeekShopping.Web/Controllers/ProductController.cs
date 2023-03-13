using Microsoft.AspNetCore.Mvc;
using GeekShopping.Web.Services.IServices;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex()
        {
            var products = _productService.FindAllProducts();
            return View(products);
        }
    }
}
