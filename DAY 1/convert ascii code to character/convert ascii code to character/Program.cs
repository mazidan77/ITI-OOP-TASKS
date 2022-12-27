namespace convert_ascii_code_to_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ascii code");
            int ascii_code = int.Parse(Console.ReadLine());
            char character = (char)ascii_code;
            Console.WriteLine($"the character of {ascii_code} = {character}");
        }
    }
}