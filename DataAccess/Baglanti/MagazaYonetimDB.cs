using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Baglanti
{
    public class MagazaYonetimDB: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MagazaYonetimDB;Trusted_Connection=true");
        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
