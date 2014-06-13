using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{

    public class InventoryItem
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }


        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "AvailableSizes")]
        public string[] AvailableSizes { get; set; }

        [Required]
        [Display(Name = "AvailableColors")]
        public string[] AvailableColors { get; set; }


        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }

   


    public class ShoppingCartItem
    {

        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        public InventoryItem Title { get; set; }
   
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Size")]
        public string Size { get; set; }

        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; }

    }


    public class ShoppingCartViewModel
    {

        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "ShoppingCartItems")]

        public Dictionary<string,ShoppingCartItem> ShoppingCartItems { get; set; }
        
    }
}