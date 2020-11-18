using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilmes.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet <Directors> Directors { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().ToTable("FILMES");
            modelBuilder.Entity<Movies>().HasKey(e => e.Id);
            modelBuilder.Entity<Movies>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Rank).HasColumnType("int").HasColumnName("RANK").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Title).HasColumnType("varchar").HasColumnName("TITULO").HasMaxLength(250).IsRequired();

            modelBuilder.Entity<Directors>().ToTable("DIRETORES");
            modelBuilder.Entity<Directors>().HasKey(e => e.Id);
            modelBuilder.Entity<Directors>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Directors>().Property(e => e.Nome).HasColumnType("varchar").HasColumnName("NOME").IsRequired();
            modelBuilder.Entity<Directors>().Property(e => e.Quantidade_Filmes).HasColumnType("int").HasColumnName("QUANTIDADE_FILMES").HasMaxLength(250).IsRequired();
        }
    }
}
