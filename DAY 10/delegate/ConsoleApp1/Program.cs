namespace Delegate
{
  
       
    public delegate void mydel(Employee emp);
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

       
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }
        public override string ToString()
        {
            return $"id:{id} mame:{name} age:{age} years old";
        }

        public event mydel add;
        public event mydel remove;
        public void onAdd()
        {
            if (add != null)
            {
                add(this);
            }

        }
        public void onRemove()
        {
            if (remove != null)
            {
                if (age >= 60)
                {
                    remove(this);
                }

            }

        }
    }

    public class Club
    {
        public List<Employee> theclub { get; set; }
        public Club(List<Employee> li)
        {
            theclub = li;
        }

        public void addEmployee(Employee emp)
        {
            theclub.Add(emp);

        }
        public override string ToString()
        {
            string clubList = "";
            foreach (Employee item in theclub)
            {
                clubList += $"{item} \n";
            }
            return clubList;
        }
    }
    public class SocialInsurance
    {
        public List<Employee> social { get; set; }
        public SocialInsurance(List<Employee> a)
        {
            social = a;
        }
        public void addEmployee(Employee emp)
        {
            social.Add(emp);
            Console.WriteLine($"id{emp.id}-{emp.name} in club");

        }
        public void removeSocial(Employee emp)
        {

            social.Remove(emp);

        }
        public override string ToString()
        {
            string allsocial = "";
            foreach (Employee item in social)
            {
                allsocial += $"{item} \n";
            }
            return allsocial;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           




            Employee[] arr = new Employee[]
            {
                new Employee(1, "mohamed", 36),
                new Employee(2, "ali", 20),
                new Employee(3, "ahmed", 55),
                new Employee(4, "hossam", 70),
            };

            SocialInsurance s1 = new SocialInsurance(new List<Employee>());
            Club c1 = new Club(new List<Employee>());

        

            for(int i=0; i < arr.Length;i++)
            {
                arr[i].add += c1.addEmployee;
                arr[i].add += s1.addEmployee;
                arr[i].remove += s1.removeSocial;
                arr[i].onAdd();
                arr[i].onRemove();
            }


            Console.WriteLine("--------------------------");
          

            foreach (Employee emp in s1.social)
            {
                Console.WriteLine($"id{emp.id}-{emp.name} in social");
            }

        }
    }
}