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
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "AvailableSizes")]
        public SelectList AvailableSizes { get; set; }

        
        [Display(Name = "AvailableColors")]
        public SelectList AvailableColors { get; set; }


        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }




    public class ShoppingCartItem : InventoryItem
    {
   
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
        public string ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 letter")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "TotalPrice")]
        public int TotalPrice { get; set; }

        [Required]
        [Display(Name = "ShoppingCartItems")]

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        
    }
}