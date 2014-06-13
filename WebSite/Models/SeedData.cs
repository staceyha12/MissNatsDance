using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSite.Models
{
    public class SeedData : DropCreateDatabaseIfModelChanges<InventoryEntities>
    {


        protected override void Seed(InventoryEntities context)
        {


            new List<InventoryItem>
            {
                new InventoryItem { Title = "Miss Nat's Dance School Winter Jacket", AvailableColors = new string[] {"Hot Pink", "Black", "Blue"}, AvailableSizes = new string[]{"2","3","4","5","6","7","8","9","10","12","14"},
                }                 }.ForEach(a => context.InventoryItems.Add(a));
        }
       

    }
}