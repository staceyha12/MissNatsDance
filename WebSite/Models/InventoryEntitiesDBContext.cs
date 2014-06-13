using System.Data.Entity;

namespace WebSite.Models
{

    public class InventoryEntitiesDBContext : DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
      
    }

}