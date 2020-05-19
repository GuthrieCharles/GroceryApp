using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ItemType? NumDescription { get; set; }
        public bool? OnSale { get; set; }
        public int Quanity { get; set; }


    }
}
