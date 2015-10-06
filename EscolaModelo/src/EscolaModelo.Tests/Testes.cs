using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscolaModelo.Domain.Entities;

namespace EscolaModelo.Tests
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestaObterIdade()
        {
            // Arranjo
            var aluno = new Aluno();
            aluno.Nome = "Renato";
            aluno.Nascimento = DateTime.Parse("27/10/1972");

            // Ação
            var resultado = aluno.ObterIdade(aluno);

            // Assert
            Assert.AreEqual(42, resultado);

        }
    }
}
