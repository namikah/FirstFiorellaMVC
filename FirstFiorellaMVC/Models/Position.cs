using System.Collections.Generic;

namespace FirstFiorellaMVC.Models
{
    public class Position
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public ICollection<Expert> experts { get; set; }
    }
}
