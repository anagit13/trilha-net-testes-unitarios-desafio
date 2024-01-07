using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //IMPLEMENTADO !!

        // Arrange
        var texto = "Matrix";

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //IMPLEMENTADO !!!
        // Act
        _validacoes.ContemCaractere(texto, textoProcurado);
        var resultado = _validacoes.ContemCaractere(texto, "qualquer");

        // Assert
        //IMPLEMENTADO !!!
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //IMPLEMENTADO !!!
        Assert.False(resultado);
    }

    //IMPLEMENTADO !!!
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //IMPLEMENTADO !!!
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }
}
