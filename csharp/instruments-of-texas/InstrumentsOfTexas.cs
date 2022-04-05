using System;

public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner)
    // TODO: complete the definition of the constructor
    {
        Operand1 = operand1;
        Operand2 = operand2;
    }

    public int Operand1 { get; }
    public int Operand2 { get; }
}

public class CalculatorTestHarness
{
    private Calculator calculator;

    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public string TestMultiplication(int x, int y)
    {
        try
        {
            calculator.Multiply(x, y);
            return "Multiply succeeded";
        }
        catch (Exception exception) when (x < 0 && y < 0)
        {
            return $"Multiply failed for negative operands. {exception.Message}";
        }
        catch (Exception exception) when (x > 0 || y > 0)
        {
            return $"Multiply failed for mixed or positive operands. {exception.Message}";
        }
    }

    public void Multiply(int x, int y)
    {
        try
        {
            calculator.Multiply(x, y);
        }
        catch (OverflowException overflowException)
        {
            throw new CalculationException(x, y, overflowException.Message, overflowException.InnerException);
        }
    }
}


// Please do not modify the code below.
// If there is an overflow in the multiplication operation
// then a System.OverflowException is thrown.vMultiply succeeded
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}
