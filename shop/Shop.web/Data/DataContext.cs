using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Data
{
    public class DataContext:DbContext    
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Product2> Products2 { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


    }

}
