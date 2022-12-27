namespace even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }

        }
    }
}