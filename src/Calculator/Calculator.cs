namespace Calculator;

/// <summary>
/// Provides basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two values.
    /// </summary>
    /// <param name="a">The first operand.</param>
    /// <param name="b">The second operand.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts one value from another.
    /// </summary>
    /// <param name="a">The value to subtract from.</param>
    /// <param name="b">The value to subtract.</param>
    /// <returns>The difference of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two values.
    /// </summary>
    /// <param name="a">The first operand.</param>
    /// <param name="b">The second operand.</param>
    /// <returns>The product of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides one value by another.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of <paramref name="a"/> and <paramref name="b"/>.</returns>
    /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        return a / b;
    }
}
