using System;

public class SqrtCalculator
{
    public double CalculateSqrt(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Nie można obliczyć pierwiastka z liczby ujemnej");
        }

        return Math.Sqrt(number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SqrtCalculator calculator = new SqrtCalculator();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Podaj liczbę, z której chcesz obliczyć pierwiastek (wpisz 'exit' aby zakończyć):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                exit = true;
                continue;
            }

            if (double.TryParse(input, out double number))
            {
                try
                {
                    double result = calculator.CalculateSqrt(number);
                    Console.WriteLine($"Pierwiastek kwadratowy z {number} wynosi: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono nieprawidłową liczbę.");
            }
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
