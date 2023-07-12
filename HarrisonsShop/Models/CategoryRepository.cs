namespace HarrisonsShop.Models

{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HarrisonsShopDbContext _harrisonsPieShopDbContext;

        public CategoryRepository(HarrionsShopDbContext harrisonsPieShopDbContext)
        {
            _harrisonsPieShopDbContext = harrisonsPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _harrisonsPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
