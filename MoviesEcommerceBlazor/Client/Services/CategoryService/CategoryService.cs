
namespace MoviesEcommerceBlazor.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;
        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (result != null && result.Data != null)
                Categories = result.Data;
        }

        //public async Task<ServiceResponse<Product>> GetCategory(int categoryId)
        //{
        //    var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
        //        return result;
        //}
    }
}
