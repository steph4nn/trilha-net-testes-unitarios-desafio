using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        bool res =_validacoes.ListaContemDeterminadoNumero(lista,numeroParaProcurar);
        
        // Assert

        Assert.False(res);
    }


    [Theory]
    [InlineData(new int[]{ 5, 7, 8, 9 }, new int[]{ 10, 14, 16, 18 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] arrayDeItens, int[] resultadoEsperado)
    {  
        // Act
        var listaDeItens = arrayDeItens.ToList();
        var listaPor2 = _validacoes.MultiplicarNumerosLista(listaDeItens,2);
        // Assert
        Assert.Equal(resultadoEsperado,listaPor2);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        int maior =_validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        Assert.Equal(9, maior);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}
