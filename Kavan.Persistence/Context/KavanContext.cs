using System;
using System.Collections.Generic;
using System.Text;
using Kavan.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kavan.Persistence.Context
{
    public class KavanContext : DbContext
    {
        public KavanContext(DbContextOptions<KavanContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


    }
}
