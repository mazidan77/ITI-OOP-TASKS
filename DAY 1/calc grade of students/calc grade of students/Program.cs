namespace calc_grade_of_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your degree");
            int degree = int.Parse(Console.ReadLine());
            if (degree >= 93)
            {
                Console.WriteLine("A");
            }
            else if (degree >= 85)
            {
                Console.WriteLine("B+");
            }
            else if (degree >= 80)
            {
                Console.WriteLine("B");
            }
           
            else if (degree >= 75)
            {
                Console.WriteLine("C+");
            }
            else if (degree >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("f");
            }
        }
    }
}