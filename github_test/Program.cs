public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        var firstNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите второе число:");
        var secondNumber = Convert.ToDouble(Console.ReadLine());

        var sum = firstNumber + secondNumber;
        Console.WriteLine("Результат сложения " + sum);
    }
}