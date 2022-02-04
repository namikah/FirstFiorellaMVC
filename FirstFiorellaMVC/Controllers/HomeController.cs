using FirstFiorellaMVC.DataAccessLayer;
using FirstFiorellaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FirstFiorellaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var aboutImage = _appDbContext.aboutImages.SingleOrDefault();
            var aboutContext = _appDbContext.aboutContexts.SingleOrDefault();
            var aboutUnstyledLists = _appDbContext.aboutUnstyledLists.ToList();
            var experts = _appDbContext.experts.Include(x => x.Position).ToList();
            var expertContext = _appDbContext.expertContexts.SingleOrDefault();
            var positions = _appDbContext.positions.ToList();

            //Select
            //var test = _dbContext.Products.Select(x => new
            //{
            //    x.Id,
            //    x.Name
            //}).ToList();

            return View(new HomeViewModel
            {
                AboutImage = aboutImage,
                AboutContext = aboutContext,
                AboutUnstyledLists = aboutUnstyledLists,
                Experts = experts,
                ExpertContext = expertContext,
                Positions = positions
            });
        }
    }
}
