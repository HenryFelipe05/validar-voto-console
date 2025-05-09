using System.Net.Http.Headers;

namespace PodeVotar.Test;

[TestClass]
public sealed class VotoUnitTest
{
    [TestMethod]
    public void Teste_Idade18_PodeVotar()
    {
        Pessoa pessoa = new Pessoa("Henry", 18);

        bool resultadoEsperado = true;
        bool resultadoObtido = pessoa.PodeVotar();

        Assert.AreEqual(resultadoEsperado, resultadoObtido);
    }

    [TestMethod]
    public void Teste_Idade15_NaoPodeVotar()
    {
        Pessoa pessoa = new Pessoa("Felipe", 15);

        bool resultadoEsperado = false;
        bool resultadoObtido = pessoa.PodeVotar();

        Assert.AreEqual(resultadoEsperado, resultadoObtido);
    }
}
