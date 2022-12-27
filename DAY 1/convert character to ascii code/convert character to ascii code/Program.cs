namespace convert_character_to_ascii_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character");
            char character = Convert.ToChar(Console.ReadLine());
            int ascii_code = (int)character;
            Console.WriteLine($"the ascii code of {character} = {ascii_code}");
        }
    }
}