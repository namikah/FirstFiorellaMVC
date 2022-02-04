using FirstFiorellaMVC.Models;
using System.Collections.Generic;

namespace FirstFiorellaMVC.ViewModels
{
    public class HomeViewModel
    {
        public AboutImage AboutImage { get; set; }

        public AboutContext AboutContext { get; set; }

        public  List<AboutUnstyledList> AboutUnstyledLists { get; set; }

        public List<Expert> Experts { get; set; }

        public List<Position> Positions { get; set; }

        public ExpertContext ExpertContext { get; set; }
    }
}
