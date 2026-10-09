var calculator = new Calculator.Calculator();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Operations: + - * / (or q for quit)");
    Console.WriteLine("Choose an operation: ");
    var operation = Console.ReadLine()?.Trim()?.ToLower();

    if (operation is "q" or "quit")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    if (operation is not ("+" or "-" or "*" or "/"))
    {
        Console.WriteLine("Invalid operation. Please use +, -, * or /");
        continue;
    }

    Console.Write("Enter first number: ");
    var firstNumber = Console.ReadLine()?.Trim();

    Console.Write("Enter second number: ");
    var secondNumber = Console.ReadLine()?.Trim();

    if (!double.TryParse(firstNumber, out var a) || !double.TryParse(secondNumber, out var b))
    {
        Console.WriteLine("Invalid input, Please enter a valid number");
        continue;
    }

    try
    {
        var result = operation switch
        {
            "+" => calculator.Add(a, b),
            "-" => calculator.Subtract(a, b),
            "*" => calculator.Multiply(a, b),
            "/" => calculator.Divide(a, b),
            _ => throw new InvalidOperationException("Invalid operation. Please user +, -, * or /")
        };

        Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
