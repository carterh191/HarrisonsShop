using HarrisonsShop.Models;
using HarrisonsShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HarrisonsShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository; //all pies returned, require availibiltie of the repositoirs in controller
        private readonly ICategoryRepository _categoryRepository; //all categories returned, require availibiltie of the repositoirs in controller

        public PieController (IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() //Controller name corresponds with the folder name without the word controller, action results in a view(cshtml file in corresponding folder)
        {
            //ViewBag.CurrentCategory = "Cheese cakes"; //viewBag is dynamic and can add whatever property to it.Shared between controller and view
            //return View(_pieRepository.AllPies);
            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes"); // use constructor of PieListViewModel and pass in allPies and cuurent category
            return View(pieListViewModel);
        }
    }
}
