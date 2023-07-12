namespace HarrisonsShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly HarrisonsShopDbContext _harrisonsPieShopDbContext;

        public PieRepository(HarrisonsShopDbContext harrisonsPieShopDbContext)
        {
            _harrisonsPieShopDbContext = harrisonsPieShopDbContext;
        }
    }
}
