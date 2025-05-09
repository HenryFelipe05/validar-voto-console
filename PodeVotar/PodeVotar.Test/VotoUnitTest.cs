using System.Net.Http.Headers;

namespace PodeVotar.Test;

[TestClass]
public sealed class VotoUnitTest
{
    [TestMethod]
    [DataRow("Henry", 18, true)]
    [DataRow("Felipe", 15, false)]
    [DataRow("Maicon", 23, true)]
    [DataRow("Luiz", 12, false)]
    public void Teste_PodeVotar(string nome, int idade, bool resultadoEsperado)
    {
        Pessoa pessoa = new Pessoa(nome, idade);

        bool resultadoObtido = pessoa.PodeVotar();

        Assert.AreEqual(resultadoEsperado, resultadoObtido);
    }
}
