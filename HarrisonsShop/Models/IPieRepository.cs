namespace HarrisonsShop.Models
{
    public interface IPieRepository //repository used to wrap all data interaction logic. Make sure that consuming classes are talking to repository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
    }
}
