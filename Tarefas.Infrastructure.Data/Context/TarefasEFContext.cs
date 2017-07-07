using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefas.Infrastructure.Data.Context
{
    public class TarefasEFContext //: DbContext
    {
        public TarefasEFContext() //: base("DefaultConnection")
        {
        }

        //public DbSet<Aluno> Alunos { get; set; }

            /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id" && !p.ReflectedType.Name.Contains("AlunoUsuario"))
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Where(p => !p.ReflectedType.Name.Contains(("AlunoUsuario")))
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Where(p => !p.ReflectedType.Name.Contains(("AlunoUsuario")))
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AlunoConfig());
            modelBuilder.Configurations.Add(new AlunoUsuarioConfig());

            base.OnModelCreating(modelBuilder);
        }
        */

    }
}
