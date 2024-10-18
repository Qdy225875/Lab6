using System;
class exercise1
{
    static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i == 10)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine();
    }
}

class exercise2
{
    static void Main()
    {
        int i = 0;
        while (i <= 10)
        {
            if (i == 10)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
            i++;
        }
    }
}

class exercise3
{
    static void Main()
    {
        int i = 0;
        do
        {
            if (i == 10)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
            i++;
        } while (i <= 10);
    }
}

class exercise4
{
    static void Main()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

public class Car
{
    private string brand;
    private string model;
    private string color;
    private string registrationNumber;

    public Car(string brand, string model, string color, string registrationNumber)
    {
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.registrationNumber = registrationNumber;
    }

    public string RegistrationNumber
    {
        get { return registrationNumber; }
    }

    public string Brand
    {
        get { return brand; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                brand = value;
            }
        }
    }

    public override string ToString()
    {
        return $"Brand: {brand}, Model: {model}, Color: {color}, Registration Number: {registrationNumber}";
    }
}

public class exercise6
{
    public static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", "Red", "ABC123");
        Console.WriteLine(myCar.ToString());

        myCar.Brand = "Honda";
        Console.WriteLine(myCar.ToString());
    }
}

class exercise7
{
    static void Main(string[] args)
    {
        while (true)
        {
            double a = 0, b = 0;
            char c;
            Console.Write("Please enter the first number:");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a numnber!");
                continue;
            }
            Console.Write("Please enter the operators (+, -, *,/):");
            if (!char.TryParse(Console.ReadLine(), out c) || !(c == '+' || c == '-' || c == '*' || c == '/'))
            {
                Console.WriteLine("Please enter correct operator: + - * / ");
                continue;
            }
            Console.Write("Please enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a numnber!");
                continue;
            }
            try
            {
                double result = 0;
                switch (c)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        if (b == 0)
                        {
                            throw new DivideByZeroException("The divisor cannot be zero!");
                        }
                        result = a / b;
                        break;
                }
                Console.WriteLine($"{a} {c} {b} = {Math.Round(result, 2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Calculation completed.");
            }
            Console.Write("Do you want to continue calculating? (y/n): ");
            if (Console.ReadLine()?.ToLower() != "y")
            {
                break;
            }
        }
    }
}
