using Talents;

namespace TesteTalents;

public class CalcTest
{

    private Calculadora _calc = new Calculadora();



    [Fact]
    public void SomarDoisNumerosRetornarValor()
    {
        int resultado = _calc.Somar(5, 5);

        Assert.Equal(10, resultado);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(2, 0, 2)]
    [InlineData(0, 3, 3)]
    [InlineData(3, 1, 4)]
    public void SomarDoisNumerosRetornarValor2(int num1, int num2, int resultadoTeste)
    {
        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(resultadoTeste, resultado);
    }

    [Fact]
    public void SubtrairDoisNumerosRetornarValor()
    {
        int resultado = _calc.Subtrair(0, 0);

        Assert.Equal(0, resultado);
    }

    [Fact]
    public void MultiplicarDoisNumerosRetornarValor()
    {
        int resultado = _calc.Multiplicar(2, 2);

        Assert.Equal(4, resultado);
    }

    [Theory]
    [InlineData(25, 5, 5)]
    [InlineData(210, 6, 35)]
    [InlineData(36, 9, 4)]
    [InlineData(40, 10, 4)]
    public void DividirDoisNumerosRetornarValor2(int num1, int num2, int result)
    {
        int resultado = _calc.Dividir(num1, num2);
        Assert.Equal(result, resultado);
    }


    [Fact]
    public void DividirDoisNumerosRetornarValor()
    {
        int resultado = _calc.Dividir(4, 2);

        Assert.Equal(2, resultado);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(2, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Somar(0, 1);
        _calc.Somar(3, 1);
        _calc.Somar(6, 1);
        _calc.Somar(9, 1);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}