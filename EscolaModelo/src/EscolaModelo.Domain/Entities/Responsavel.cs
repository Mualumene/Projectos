using System;
using System.Collections.Generic;

namespace EscolaModelo.Domain.Entities
{
    public class Responsavel
    {
        public Responsavel()
        {
            ResponsavelId = Guid.NewGuid();
        }

        public Guid ResponsavelId { get; set; }

        public string Nome { get; set; }

        public string Parentesco { get; set; }

        public string Sexo { get; set; }

        public string CPF { get; set; }

        public DateTime Nascimento { get; set; }

        public string UFNascimento { get; set; }

        public string Naturalidade { get; set; }

        public string Nacionalidade { get; set; }

        public int CodPais { get; set; }

        public string Identidade { get; set; }

        public string IdOrgao { get; set; }

        public string IdUF { get; set; }

        public string IdEmissao { get; set; }

        public string Titulo { get; set; }

        public string Zona { get; set; }

        public string Secao { get; set; }

        public string TitUF { get; set; }

        public string Reservista { get; set; }

        public string RsvOrgao { get; set; }

        public string Raca { get; set; }

        public string CorPele { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoDeficiencia { get; set; }

        public string CTPS { get; set; }

        public string CTPSSerie { get; set; }

        public string CertidaoNascimento { get; set; }

        public string TipoSangue { get; set; }

        public string Religiao { get; set; }

        public string NacionalidadeEstrangeira { get; set; }

        public string Passaporte { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }

        public string Profissao { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public Guid AlunoId { get; set; }

        public virtual Aluno Aluno { get; set; }
    }
}
