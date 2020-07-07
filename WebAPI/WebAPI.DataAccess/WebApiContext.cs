using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using WebAPI.Entities;

namespace WebAPI.DataAccess
{
   public class WebApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AYLIN\\SQLSERVER2017;Database=WebAPI;Trusted_Connection=True;");
        }
        public DbSet<Users> Users { get; set; }
      
    }
}
