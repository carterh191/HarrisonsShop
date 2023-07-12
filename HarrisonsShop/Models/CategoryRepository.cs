namespace HarrisonsShop.Models

{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HarrisonsShopDbContext _harrisonsPieShopDbContext;

        public CategoryRepository(HarrisonsShopDbContext harrisonsPieShopDbContext)
        {
            _harrisonsPieShopDbContext = harrisonsPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _harrisonsPieShopDbContext.Categories.OrderBy(p => p.CategoryName); //using injetion to get all the categories ordered by category name alphabetically
    }
}
