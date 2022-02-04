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
            var aboutImage = _appDbContext.AboutImages.SingleOrDefault();
            var aboutContext = _appDbContext.AboutContexts.SingleOrDefault();
            var aboutUnstyledLists = _appDbContext.AboutUnstyledLists.ToList();
            var experts = _appDbContext.Experts.Include(x => x.Position).ToList();
            var expertContext = _appDbContext.ExpertContexts.SingleOrDefault();
            var positions = _appDbContext.Positions.ToList();
            var subcribe = _appDbContext.Subcribes.SingleOrDefault();
            var blogs = _appDbContext.Blogs.ToList();
            var blogContext = _appDbContext.BlogContexts.SingleOrDefault();

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
                Positions = positions,
                Subcribe = subcribe,
                BlogContext = blogContext,
                Blogs = blogs,
            });
        }
    }
}
