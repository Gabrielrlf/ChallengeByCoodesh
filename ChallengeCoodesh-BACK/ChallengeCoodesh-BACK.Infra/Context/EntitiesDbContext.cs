using ChallengeCoodesh_BACK.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Infra.Context
{
    public class EntitiesDbContext : DbContext
    {
        public DbSet<FileUploader> fileUploader { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlite("Data Source=Coodesh.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileUploader>()
              .HasData(
                  new FileUploader(Domain.Enum.TypeTransaction.ProductorSell, DateTime.Now, "DESENVOLVEDOR FULL STACK", 155000, "ELIANA NOGUEIRA")
                  {
                      Id = 1
                  }
              );
        }
    }
}
