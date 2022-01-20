using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Mvc.ApiService.Stocks.Products;

namespace SlnErp102.Mvc.Controllers
{
    public class ProductEntryApiController : Controller
    {
        private readonly ProductEntryApiService _productEntryApiService;
        private readonly IMapper _mapper;

        public ProductEntryApiController(ProductEntryApiService productEntryApiService,IMapper mapper)
        {
            _productEntryApiService = productEntryApiService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var productEntry = await _productEntryApiService.GetAllAsync();

            return View(_mapper.Map<IEnumerable<ProductEntryDistinctDto>>(productEntry));
        }

        public async Task<IActionResult> Details(string invo)
        {
            var a = invo;
            return View();
        }
    }
}
