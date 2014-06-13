using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

public class Option
{

    
    public int Id { get; set; }
    public string Value { get; set; }
}
namespace WebSite.Models
{

      
        public class JacketOrderItemViewModel
        {

            [Required]
            [Display(Name = "ID")]
            public int OrderID { get; set; }

            [Required]
            [Display(Name = "Color")]
            public int ColorID { get; set; }

            [Required]
            [Display(Name = "Quantity")]
            public int Quantity { get; set; }
             
            [Required]
            [Display(Name = "Size")]
            public int SizeID { get; set; }

        }
    

        public class JacketOrderViewModel
        {
     
            public JacketOrderItemViewModel CurrentOrder { get; set; }
            public IList<JacketOrderItemViewModel> JacketOrders { get; set; }

            [Required (ErrorMessage="Please enter your name.")]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please enter your email address.")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

        }

 
}