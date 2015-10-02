using System;

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

        public DateTime DataNascimento { get; set; }

        public int ObterIdade(Aluno aluno)
        {
            var idade = DateTime.Now.Year - aluno.DataNascimento.Year;
            if (DateTime.Now.Month < aluno.DataNascimento.Month || (DateTime.Now.Month == aluno.DataNascimento.Month && DateTime.Now.Day < aluno.DataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }
    }
}
