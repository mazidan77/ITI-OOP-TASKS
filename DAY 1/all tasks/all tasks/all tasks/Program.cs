namespace all_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region convert character to ascii code
            Console.WriteLine("Enter any character");
            char character = Convert.ToChar(Console.ReadLine());
            int ascii_code = (int)character;
            Console.WriteLine($"the ascii code of {character} = {ascii_code}");
            #endregion

            #region convert ascii code to character
            //Console.WriteLine("Enter ascii code");
            //int ascii_code = int.Parse(Console.ReadLine());
            //char character = (char)ascii_code;
            //Console.WriteLine($"the character of {ascii_code} = {character}");
            #endregion

            #region even or odd
            //Console.WriteLine("ENTER A NUMBER");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"{number} is even");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is odd");
            //}
            #endregion


            #region print the sum subtraction multiplication

            //Console.WriteLine("enter first number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //int secondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine($"the sum of {firstNumber} and {secondNumber} = {firstNumber + secondNumber}");
            //Console.WriteLine($"the subtraction of {firstNumber} and {secondNumber} = {firstNumber - secondNumber}");
            //Console.WriteLine($"the multiplication of {firstNumber} and {secondNumber} = {firstNumber * secondNumber}");
            #endregion

            #region grades

            //Console.WriteLine("enter your degree");
            //int degree = int.Parse(Console.ReadLine());
            //if (degree >= 93)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (degree >= 85)
            //{
            //    Console.WriteLine("B+");
            //}
            //else if (degree >= 80)
            //{
            //    Console.WriteLine("B");
            //}

            //else if (degree >= 75)
            //{
            //    Console.WriteLine("C+");
            //}
            //else if (degree >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("f");
            //}
            #endregion

            #region Multiplication table
            //for (int i = 1; i < 13; i++)
            //{
            //    for (int j = 1; j < 13; j++)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");
            //    }
            //}
            #endregion

        }
    }
}