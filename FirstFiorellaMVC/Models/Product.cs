﻿using System.Collections.Generic;

namespace FirstFiorellaMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public  List<ProductImage> Images{ get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
