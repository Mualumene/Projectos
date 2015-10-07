using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EscolaModelo.Domain.Entities;

namespace EscolaModelo.Infra.Data.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            HasKey(a => a.AlunoId);

            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Bairro)
                .HasMaxLength(50);

        }
    }
}
