using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EscolaModelo.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using EscolaModelo.Infra.Data.EntityConfig;

namespace EscolaModelo.Infra.Data.Context
{
    public class EscolaModelo : DbContext
    {
        public EscolaModelo()
            :base("EscolaModelo")
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Responsavel> Responsaveis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AlunoConfig());
            modelBuilder.Configurations.Add(new ResponsavelConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
