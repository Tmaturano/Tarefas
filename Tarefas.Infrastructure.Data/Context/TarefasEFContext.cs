using Microsoft.EntityFrameworkCore;
using System.IO;
using Tarefas.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Tarefas.Infrastructure.Data.Context
{
    public class TarefasEFContext : DbContext
    {
        public TarefasEFContext()
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .Property(t => t.Id)
                .IsRequired();

            modelBuilder.Entity<Tarefa>()
                .Property(t => t.Status)
                .IsRequired();

            modelBuilder.Entity<Tarefa>()
                .Property(t => t.Titulo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Tarefa>()
                .Property(t => t.Descricao)
                .HasColumnType("varchar(250)")
                .IsRequired();

            modelBuilder.Entity<Tarefa>()
                .ToTable("Tarefas");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")    //como se fosse um app.config
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            //base.OnConfiguring(optionsBuilder);
        }

    }
}
