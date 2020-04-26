using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MvcCodeFirstExample.Models
{
    public class ProductDetailDbContext : DbContext
    {
        public ProductDetailDbContext() : base("data source=.; initial catalog=ProductDetails; integrated security=SSPI")
        {

        }
        public DbSet<Category>CategoriesTbl { get; set; }
        public DbSet<Product> ProductsTbl { get; set; }
    }
}
