using FirstFiorellaMVC.DataAccessLayer;
using FirstFiorellaMVC.Models;
using FirstFiorellaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FirstFiorellaMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Detail(int? id)
        {
            return View(new HomeViewModel
            {
                Products = _appDbContext.Products.ToList(),
                Categories = _appDbContext.Categories.ToList(),
                Slider = _appDbContext.Sliders.SingleOrDefault(),
                SliderImages = _appDbContext.SliderImages.ToList(),
                AboutImage = _appDbContext.AboutImages.SingleOrDefault(),
                AboutContext = _appDbContext.AboutContexts.SingleOrDefault(),
                AboutUnstyledLists = _appDbContext.AboutUnstyledLists.ToList(),
                Experts = _appDbContext.Experts.Include(x => x.Position).ToList(),
                ExpertContext = _appDbContext.ExpertContexts.SingleOrDefault(),
                Positions = _appDbContext.Positions.ToList(),
                Subcribe = _appDbContext.Subcribes.SingleOrDefault(),
                Blogs = _appDbContext.Blogs.ToList(),
                BlogContext = _appDbContext.BlogContexts.SingleOrDefault(),
                Authors = _appDbContext.Authors.ToList(),
                Instagrams = _appDbContext.Instagrams.ToList(),
                Socials = _appDbContext.Socials.ToList(),
                Menus = _appDbContext.Menus.ToList(),
                ProductImages = _appDbContext.ProductImages.ToList(),
                ImagesByProductId = _appDbContext.ProductImages.ToList().FindAll(x=>x.Product.Id == id),
                Campaigns = _appDbContext.Campaigns.ToList(),
            });
        }
    }
}
