namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsTheirSum()
    {
        var calculator = new Calculator();

        var result = calculator.Add(1, 2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsTheirDifference()
    {
        var calculator = new Calculator();

        var result = calculator.Subtract(2, 1);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsTheirProduct()
    {
        var calculator = new Calculator();

        var result = calculator.Multiply(2, 3);

        Assert.Equal(6, result);
    }

    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsTheirQuotient()
    {
        var calculator = new Calculator();

        var result = calculator.Divide(6, 2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
    }
}
