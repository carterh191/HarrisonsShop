using Microsoft.EntityFrameworkCore;

namespace HarrisonsShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly HarrisonsShopDbContext _harrisonsPieShopDbContext;

        public PieRepository(HarrisonsShopDbContext harrisonsPieShopDbContext)
        {
            _harrisonsPieShopDbContext = harrisonsPieShopDbContext; //generates constructor passing in dbContext
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _harrisonsPieShopDbContext.Pies.Include(c => c.Category); // launch a query when we execute this to the database asking all records in the Pie table
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _harrisonsPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek); //only return pies where PiesOfTheWeek is actually true
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _harrisonsPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId); //first or default on the Pies DbSet here to get the pie where the ID is equual to the PieID thats passed here
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
