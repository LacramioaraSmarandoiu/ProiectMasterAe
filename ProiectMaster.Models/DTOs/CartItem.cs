using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public CartItem()
        {
        }
        public CartItem(int id, string name, string image, string description, decimal price)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Price = price;
        }
    }

   
}
