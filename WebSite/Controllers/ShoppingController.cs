using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using WebSite.Models;

namespace WebSite.Controllers
{
   
    public class ShoppingController : Controller
    {

        private ShoppingCartViewModel _ShoppingCart 
        {
            get{
                    if (Session["ShoppingCart"] == null)
                    {
                        ShoppingCartViewModel _shoppingCart = new ShoppingCartViewModel();
                        _shoppingCart.ID = Session.SessionID;
                        _shoppingCart.ShoppingCartItems = new List<ShoppingCartItem>();

                        Session["ShoppingCart"] = _shoppingCart;
                    }

                    return Session["ShoppingCart"] as ShoppingCartViewModel;
            }
            set
            {

                    Session["ShoppingCart"] = value;
               
            }
        }
        private class _Option
        {

            public int Id { get; set; }
            public string Value { get; set; }
        }
          // GET: Index

       
        public ActionResult Index()
        {
           
            IEnumerable<_Option> _colorOptions = new List<_Option>
                { 
                    new _Option {Id = -1, Value = "Select a Color"},
                    new _Option {Id = 0, Value = "Hot Pink (Black Writing)"},
                    new _Option {Id = 1, Value = "Blue (Black Writing)"},
                    new _Option {Id = 2, Value = "Black (Hot Pink Writing)"}
                };

            IEnumerable<_Option> _sizeOptions = new List<_Option>
                {
                new _Option {Id = -1, Value = "Select a Size"},
                new _Option {Id = 0, Value = "2"},
                new _Option {Id = 1, Value = "3"},
                new _Option {Id = 2, Value = "4"},
                new _Option {Id = 3, Value = "5"},
                new _Option {Id = 4, Value = "6"},
                new _Option {Id = 5, Value = "7"},
                new _Option {Id = 6, Value = "8"},
                new _Option {Id = 7, Value = "9"},
                new _Option {Id = 8, Value = "10"},
                new _Option {Id = 9, Value = "12"},
                new _Option {Id = 10, Value = "14"}
                };

            ShoppingCartItem item = new ShoppingCartItem();
            item.Price = 50;
            item.AvailableColors = new SelectList(_colorOptions, "Value", "Value");
            item.AvailableSizes = new SelectList(_sizeOptions, "Value", "Value");
            item.ID = -1;
            item.Title = "Miss Nat's Winter Jacket";
        
            return View(item);
        }

        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
  
            return PartialView(_ShoppingCart);
        }

        // Post: AddtoCart

        [HttpPost]
        public ActionResult AddToCart(ShoppingCartItem item)
        {

            item.ID = _ShoppingCart.ShoppingCartItems.Count - 1;
            _ShoppingCart.TotalPrice += (item.Price * item.Quantity);
            _ShoppingCart.ShoppingCartItems.Add(item);
          
            

             return RedirectToAction("Index", "Shopping");
        }

        public ActionResult RemoveFromCart(ShoppingCartItem item)
        {

            _ShoppingCart.ShoppingCartItems.RemoveAt(item.ID);
            return RedirectToAction("Index", "Shopping");
        }
        public ActionResult Confirmation()
        {
            return View(_ShoppingCart);
        }
        public ActionResult UserConfirmation()
        {
            string strBody = "<p><b>Jacket Order from" + _ShoppingCart.Name + "(email:" + _ShoppingCart.Email +")</b></p><table>";

            foreach (var item in _ShoppingCart.ShoppingCartItems)
            {
                strBody += "<tr>";
                
                strBody += "<td><b>";
                strBody += item.Quantity;
                strBody += "</b> ";
                strBody += item.Title;
                strBody += (item.Quantity > 1)?"s": "";
                strBody += ",Color: ";
                strBody += item.Color ;
                strBody += ", Size: ";
                strBody += item.Size.ToString(); 
                strBody += "</td>";

                strBody += "<td><b>$";
                strBody += (item.Price * item.Quantity).ToString();
                strBody +=".00</b></td>";

                
                strBody += "</tr>";
                strBody+= "<tr><td colspan='2'><b style='color:red'> TOTAL AMOUNT OWED:";
                strBody += _ShoppingCart.TotalPrice;
                strBody += "</b></td></tr>";
            }

            strBody += "</table>";

            //send email to Miss Nat.
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("thegadfly12@gmail.com");
            msg.Subject = "Jacket Order:";
            msg.From = new System.Net.Mail.MailAddress("thegadfly12@gmail.com");
            msg.Body = strBody;
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("thegadfly12@gmail.com", "Bacchiman12");
            smtp.Send(msg);

            _ShoppingCart = null;
            return RedirectToAction("Index", "Home");
        }
    }
}