namespace MoviesEcommerceBlazor.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();

        //Task<ServiceResponse<Category>> GetCategory(int categoryId);
    }
}
