using FirstFiorellaMVC.Models;
using System.Collections.Generic;

namespace FirstFiorellaMVC.ViewModels
{
    public class HomeViewModel
    {
        public AboutImage AboutImage { get; set; }

        public IContext AboutContext { get; set; }

        public  List<AboutUnstyledList> AboutUnstyledLists { get; set; }

        public List<Expert> Experts { get; set; }

        public List<Position> Positions { get; set; }

        public IContext ExpertContext { get; set; }

        public Subcribe Subcribe { get; set; }

        public List<Blog> Blogs { get; set; }

        public IContext BlogContext { get; set; }

        public List<Author> Authors { get; set; }

        public List<Instagram> Instagrams { get; set; }

        public List<Social> Socials { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
