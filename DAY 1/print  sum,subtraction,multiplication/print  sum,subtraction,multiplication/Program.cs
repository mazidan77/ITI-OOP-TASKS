namespace print__sum_subtraction_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"the sum of {firstNumber} and {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"the subtraction of {firstNumber} and {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"the multiplication of {firstNumber} and {secondNumber} = {firstNumber * secondNumber}");

        }
    }
}