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

            Property(a => a.Sexo)
                .HasMaxLength(50);

            Property(a => a.CPF)
                .HasMaxLength(50);

            Property(a => a.Naturalidade)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Nacionalidade)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Identidade)
                .HasMaxLength(50);

            Property(a => a.IdOrgao)
                .HasMaxLength(50);

            Property(a => a.IdUF)
                .HasMaxLength(50);

            Property(a => a.Titulo)
                .HasMaxLength(50);

            Property(a => a.Zona)
                .HasMaxLength(50);

            Property(a => a.Secao)
                .HasMaxLength(50);

            Property(a => a.TitUF)
                .HasMaxLength(50);

            Property(a => a.Reservista)
                .HasMaxLength(50);

            Property(a => a.RsvOrgao)
                .HasMaxLength(50);

            Property(a => a.Login)
                .HasMaxLength(10);

            Property(a => a.Senha)
                .HasMaxLength(18);

            Property(a => a.Raca)
                .HasMaxLength(15);

            Property(a => a.CorPele)
                .HasMaxLength(50);

            Property(a => a.EstadoCivil)
                .HasMaxLength(20);

            Property(a => a.TipoDeficiencia)
                .HasMaxLength(40);

            Property(a => a.CTPS)
                .HasMaxLength(15);

            Property(a => a.CTPSSerie)
                .HasMaxLength(15);

            Property(a => a.NumRegistro)
                .HasMaxLength(10);

            Property(a => a.CertidaoNascimento)
                .HasMaxLength(80);

            Property(a => a.TipoSangue)
                .HasMaxLength(3);

            Property(a => a.Religiao)
                .HasMaxLength(100);

            Property(a => a.UFNascimento)
                .HasMaxLength(2);

            Property(a => a.NacionalidadeEstrangeira)
                .HasMaxLength(50);

            Property(a => a.IdCensoEscolar)
                .HasMaxLength(30);

            Property(a => a.Passaporte)
                .HasMaxLength(30);
        }
    }
}
