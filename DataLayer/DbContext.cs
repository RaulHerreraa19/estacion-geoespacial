using Microsoft.EntityFrameworkCore;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UsersModel> Users { get; set; }
        public virtual DbSet<CarModel> Carritos { get; set; }    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersModel>().ToTable("Users");
            modelBuilder.Entity<CarModel>().ToTable("Cars");
            

            modelBuilder.Entity<UsersModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
            });
            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.Latitud);
                entity.Property(e => e.Longitud);
                entity.Property(e => e.Altitud);
                entity.Property(e => e.PresionAtmosferica);
                entity.Property(e => e.Temperatura);
            });
        }
    }
}
