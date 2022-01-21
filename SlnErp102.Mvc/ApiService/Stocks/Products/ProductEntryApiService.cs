using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Stocks.Products;

namespace SlnErp102.Mvc.ApiService.Stocks.Products
{
    public class ProductEntryApiService
    {
        private readonly HttpClient _httpClient;
        public ProductEntryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductEntryDistinctDto>?> GetAllAsync()
        {
            IEnumerable<ProductEntryDistinctDto>? pEntryDtos;
            var response = await _httpClient.GetAsync("ProductEntries");


            //http://localhost:43333/api/productentry gelmesi lazım

            if (response.IsSuccessStatusCode)
            {
                pEntryDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDistinctDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                pEntryDtos = null;
            }
            return pEntryDtos;
        }

        public async Task<IEnumerable<ProductEntryDto>?> GetProEntryByIvnoAsync(string ivno)
        {
            IEnumerable<ProductEntryDto>? pEntryDtos;

            var response = await _httpClient.GetAsync($"ProductEntries/a/{ivno}");

            //ProductEntries/InvoiceNumberString/1234
            //ProductEntries/InvoiceNumberString/4321

            if (response.IsSuccessStatusCode)
            {
                pEntryDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                pEntryDtos = null;
            }
            return pEntryDtos;
        }
    }
}
