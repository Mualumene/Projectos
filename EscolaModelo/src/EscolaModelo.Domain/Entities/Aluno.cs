﻿using System;
using System.Collections.Generic;

namespace EscolaModelo.Domain.Entities
{
    public class Aluno
    {
        public Aluno()
        {
            AlunoId = Guid.NewGuid();
        }

        public Guid AlunoId { get; set; }

        public string Nome { get; set; }

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

        public string IdCensoEscolar { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        
        public  ICollection<Responsavel> Responsaveis { get; set; }

        public int ObterIdade(Aluno aluno)
        {
            var idade = DateTime.Now.Year - aluno.Nascimento.Year;
            if (DateTime.Now.Month < aluno.Nascimento.Month || (DateTime.Now.Month == aluno.
                Nascimento.Month && DateTime.Now.Day < aluno.Nascimento.Day))
            {
                idade--;
            }

            return idade;
        }
    }
}
