using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureAssemblyDatabaseImplement
{
    public class FurnitureAssemblyDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-3ONQPAF5\SQLEXPRESS;Initial Catalog=FurnitureAssemblyDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Furniture> Furnitures { set; get; }
        public virtual DbSet<FurnitureComponent> FurnitureComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Implementer> Implementers { get; set; }
    }
}
