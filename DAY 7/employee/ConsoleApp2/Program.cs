namespace task2
{
    public static class logHandle
    {
        public static void writeLogg(string message)
        {
            
            using (StreamWriter sw = new StreamWriter(@"D:\PROGRAMMING\ITI Q2 MNF .NET\c# advanced\Day3\log.txt", true))
            {
                sw.WriteLine(message);
            }

        }
    }
    [Flags]
    enum security
    {
        guest=1, Developer=2, secretary=4 , DBA=8
    }
    enum gender
    {
        M,F
    }
    class Empolyee:IComparable
    {
        public int id { get; set; }
        public security security_level { get; set; }
        public double salary { get; set; }
        public HiringDate date { get; set; }
        public gender gender { get; set; }

        public Empolyee()
        {

        }
        public Empolyee(int id, security security_level, double salary, HiringDate date, gender gender)
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
            return( a.date.year > b.date.year) ;
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
       
            return $"emp_id:{id} security_level:{security_level} emp_salary:{salary}  hiring_date: {date.ToString()}  gender:{gender}";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Empolyee)
            {
                Empolyee emp = (Empolyee)obj;
                return id == emp.id;
            }
            else
            {
                return false ;  
            }
           
        }

        public int CompareTo(object? obj)
        {
           Empolyee em = obj as Empolyee;

            return date.CompareTo(em.date);
        }
    }
    class HiringDate:IComparable
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
            if(obj is HiringDate)
            {
                HiringDate emp = (HiringDate)obj;
                return day == emp.day;
            }
            else
                return false;
           
        }

        public int CompareTo(object? obj)
        {
            HiringDate a = (HiringDate)obj;
            return (year.CompareTo(a.year) ) ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringDate date1 = new HiringDate(15, 4, 2005);
            HiringDate date2 = new HiringDate(20, 5, 2020);
            HiringDate date3 = new HiringDate(15, 8, 2018);



            var emp = new Empolyee[] {new Empolyee(1, security.DBA, 1000, date1, gender.M),
                new Empolyee(2 ,security.guest, 5000, date2, gender.F),

                new Empolyee(3 ,security.DBA^security.Developer^security.guest ^security.secretary, 8000, date3, gender.M)};

            Array.Sort(emp);
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].ToString());
            }




            //int x = emp[0];
            //Console.WriteLine(x);

            //int number_of_emolyee;
            //bool res;
            //int id;
            //int salary;
            //int security;

            //do
            //{
            //    Console.WriteLine("enter number of empolyee");
            //    res = int.TryParse(Console.ReadLine(), out number_of_emolyee);
            //    if (res == false)
            //    {
            //        Console.WriteLine("please enter a number");
            //    }
            //} while (res == false);

            //Empolyee[] arr = new Empolyee[number_of_emolyee];


            //for (int i = 0; i < arr.Length; i++)
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
            //    } while (res == false);

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
            //    try
            //    {
            //        arr[i].date = new HiringDate();
            //        Console.WriteLine("enter year");
            //        arr[i].date.year = int.Parse(Console.ReadLine());
            //        Console.WriteLine("enter month");
            //        arr[i].date.month = int.Parse(Console.ReadLine());
            //        Console.WriteLine("enter day");
            //        arr[i].date.day = int.Parse(Console.ReadLine());
            //    }
            //    catch (FormatException ex)
            //    {
            //        logHandle.writeLogg(ex.Message);
            //        Console.WriteLine(ex.Message);
            //    }



            //    Console.WriteLine("enter year");
            //    int year = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter month");
            //    int month = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter day");
            //    int day = int.Parse(Console.ReadLine());
            //    HiringDate date = new HiringDate(day, month, year);
            //    arr[i].date = date;


            //}



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].ToString());
            //}
            //Console.WriteLine(arr[0] > arr[1]);
            //int x = arr[0];
            //string y =(string) arr[0];
            //Console.WriteLine((x));
            //Console.WriteLine((y));

        }
    }
}