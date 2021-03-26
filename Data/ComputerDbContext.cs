using ComputerJunctionMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerJunctionMVC.Data
{
    public class ComputerDbContext :DbContext
    {
        public ComputerDbContext(DbContextOptions<ComputerDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Printer> Printers { get; set; }

    }
}
