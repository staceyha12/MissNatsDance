using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class JacketOrderController : Controller
    {

        private SelectList _colors = null;
        private SelectList _sizes = null;
        private SelectList _GetColors()
        {
            if (_colors == null)
            {
                IEnumerable<Option> _colorOptions = new List<Option>
                { 
                    new Option {Id = -1, Value = "Select a Color"},
                    new Option {Id = 0, Value = "Hot Pink (Black Writing)"},
                    new Option {Id = 1, Value = "Blue (Black Writing)"},
                    new Option {Id = 2, Value = "Black (Hot Pink Writing)"}
                };

                _colors = new SelectList(_colorOptions, "Id", "Value", "-1");
            }

            return _colors;
        }


        private SelectList _GetSizes()
        {
            if (_sizes == null)
            {
                IEnumerable<Option> _sizeOptions = new List<Option>
                {
                new Option {Id = -1, Value = "Select a Size"},
                new Option {Id = 0, Value = "2"},
                new Option {Id = 1, Value = "3"},
                new Option {Id = 2, Value = "4"},
                new Option {Id = 3, Value = "5"},
                new Option {Id = 4, Value = "6"},
                new Option {Id = 5, Value = "7"},
                new Option {Id = 6, Value = "8"},
                new Option {Id = 7, Value = "9"},
                new Option {Id = 8, Value = "10"},
                new Option {Id = 9, Value = "12"},
                new Option {Id = 10, Value = "14"}
                };


                _sizes = new SelectList(_sizeOptions, "Id", "Value", "-1");
            }

            return _sizes;
       }



       
        //GET: JacketOrder/Create
        public ActionResult Create()
        {
            ViewBag.Sizes = _GetSizes();
            ViewBag.Colors = _GetColors();
            return View();
        }
        
        //GET: JacketOrder/Delete
        public ActionResult Delete(int id)
        {
            return View();
        }
        //
        // POST: /JacketOrder/Submit
        [HttpPost]
        public ActionResult AddToOrder(JacketOrderViewModel model)
        {
            return View();
        }
        //
        // POST: /JacketOrder/Submit
        [HttpPost]
        public ActionResult Submit(JacketOrderViewModel model)
        {
            return View();
        }
    }
}