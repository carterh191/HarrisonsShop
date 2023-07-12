using Microsoft.EntityFrameworkCore;

namespace HarrisonsShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly HarrisonsShopDbContext _harrisonsShopDbContext;

        public PieRepository(HarrisonsShopDbContext harrisonsPieShopDbContext)
        {
            _harrisonsShopDbContext = harrisonsShopDbContext; //generates constructor passing in dbContext
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _harrisonsShopDbContext.Pies.Include(c => c.Category); // launch a query when we execute this to the database asking all records in the Pie table
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _harrisonsShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek); //only return pies where PiesOfTheWeek is actually true
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _harrisonsShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId); //first or default on the Pies DbSet here to get the pie where the ID is equual to the PieID thats passed here
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
