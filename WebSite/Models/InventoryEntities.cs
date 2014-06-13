using System.Data.Entity;

namespace WebSite.Models
{

    public class InventoryEntities : DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
      
    }

}