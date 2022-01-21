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
            var productEnrty = await _productEntryApiService.GetAllAsync();

            return View(_mapper.Map<IEnumerable<ProductEntryDistinctDto>>(productEnrty));
        }

        public async Task<IActionResult> Details(string ivno)
        {
            var pEntry =
              await _productEntryApiService.GetProEntryByIvnoAsync(ivno);
            return View(_mapper.Map<IEnumerable<ProductEntryDto>>(pEntry));
        }

        
    }
}
