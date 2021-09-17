using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        //context classı ilişkinin kurulduğu classtır, base olarak DbContext bağlanır
        // uygulamaladaki nesneler ile db'deki tabloları ilişkilendirmeye yarar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } //tablo ilişkilendirilmesi

    }
  
}
