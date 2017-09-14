using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyWhatUAlwaysWanted.Models
{
    public class ItemDataContext: DbContext
    {
        
        public DbSet<ItemModel> Posts { get; set; }

        public ItemDataContext(DbContextOptions<ItemDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
