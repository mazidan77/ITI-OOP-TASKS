namespace task2
{
    class Empolyee
    {
        public int id { get; set; }
        public int security_level { get; set; }
        public double salary { get; set; }
        public HiringDate date { get; set; }
        public string gender { get; set; }

        public Empolyee()
        {

        }
        public Empolyee(int id, int security_level, double salary, HiringDate date, string gender)
        {
            this.id = id;
            this.security_level = security_level;
            this.salary = salary;
            this.date = date;
            this.gender = gender;
        }
        public static implicit operator int(Empolyee emp)
        {
            return emp.id;
        }
        public static bool operator >(Empolyee a, Empolyee b)
        {
            return a.date.month > b.date.month;
        }
        public static bool operator <(Empolyee a, Empolyee b)
        {
            return a.date.month < b.date.month;
        }
        public static bool operator ==(Empolyee a, Empolyee b)
        {
            return a.date.month == b.date.month;
        }
        public static bool operator !=(Empolyee a, Empolyee b)
        {
            return a.date.month != b.date.month;
        }

        public override string ToString()
        {
            //hiring_date: { date.ToString()}
            return $"emp_id:{id} security_level:{security_level} emp_salary:{salary}  gender:{gender}";
        }
        public override bool Equals(object? obj)
        {
            Empolyee emp = (Empolyee)obj;
            return id == emp.id;
        }
    }
    class HiringDate
    {
        public int date { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public HiringDate()
        {

        }
        public HiringDate(int day = 27, int month = 3, int year = 2005)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        public override bool Equals(object? obj)
        {
            HiringDate emp = (HiringDate)obj;
            return day == emp.day;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringDate date1 = new HiringDate();
            HiringDate date2 = new HiringDate(20, 5, 2020);
            HiringDate date3 = new HiringDate(15, 8, 2018);

            var emp = new Empolyee[] {new Empolyee(1, 5, 1000, date1, "male"),
                new Empolyee(2 ,1, 5000, date2, "female"),
                new Empolyee(3 ,10, 8000, date2, "male")};
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].ToString());
            }
            int x = emp[0];
            Console.WriteLine(x);

            //int number_of_emolyee;
            //bool res;
            //int id;
            //int salary;
            //int security;
            //HiringDate date;

            //do
            //{
            //    Console.WriteLine("enter number of empolyee");
            //    res = int.TryParse(Console.ReadLine(), out number_of_emolyee);
            //    if (res == false)
            //    {
            //        Console.WriteLine("please enter a number");
            //    }
            //} while (res==false);

            //Empolyee[] arr = new Empolyee[number_of_emolyee];
            //Console.WriteLine(number_of_emolyee);

            //for(int i = 0; i < arr.Length; i++)
            //{



            //    arr[i] = new Empolyee();


            //    do
            //    {


            //        Console.WriteLine($"entet id of empolyee number {i + 1}");
            //        res = int.TryParse(Console.ReadLine(), out id);
            //        arr[i].id = id;

            //        if (res == false)
            //        {
            //            Console.WriteLine("please enter a number");
            //        }
            //    } while (res==false);

            //    do
            //    {

            //        Console.WriteLine($"entet security level of empolyee number {i + 1}");
            //        res = int.TryParse(Console.ReadLine(), out security);
            //        arr[i].security_level = security;

            //        if (res == false)
            //        {
            //            Console.WriteLine("please enter a number");
            //        }
            //    } while (res == false);
            //    do
            //    {

            //        Console.WriteLine($"entet salary of empolyee number {i + 1}");
            //        res = int.TryParse(Console.ReadLine(), out salary);
            //        arr[i].salary = salary;

            //        if (res == false)
            //        {
            //            Console.WriteLine("please enter a number");
            //        }
            //    } while (res == false);
            //    Console.WriteLine("enter gender of employee");
            //    arr[i].gender = (Console.ReadLine());



            //}



            //for(int i=0; i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].ToString()); 
            //}
        }
    }
}