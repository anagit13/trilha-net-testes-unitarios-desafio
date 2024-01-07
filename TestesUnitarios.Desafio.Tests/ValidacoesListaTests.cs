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
        var resultado = new List<int>();

        // Act
        resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultado, new List<int> { 5, 9 });
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, 9);

        // Assert
        Assert.True(resultado);
    }

    //IMPLEMENTADO !!!
    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, 10);

        // Assert
        Assert.False(resultado);
    }

    //IMPLEMENTADO !!!
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var multiplicador = new List<int> { 2 };

        // Act
        var resultado = lista.Select(x => x * multiplicador.First()).ToList();

        // Assert
        Assert.Equal(resultado, new List<int> { 10, 14, 16, 18 });
}

    //IMPLEMENTADO !!!
    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert       
        Assert.Equal(9, resultado);
    }

    //IMPLEMENTADO !!!
    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //IMPLEMENTADO !!!
        Assert.Equal(-8, resultado);
    }
}
