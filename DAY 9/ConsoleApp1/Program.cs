using System.Collections.Generic;
using System.Transactions;

namespace ConsoleApp1
{
    class track:IComparable<track>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public track()
        {

        }

        public track(int id , string name , string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;

        }
        public override bool Equals(object? obj)
        {
            track t= obj as track;
            return id == t.id;
            
        }
        public override string ToString()
        {
            return $"id:{id} name:{name} description:{description}";
        }

        public int CompareTo(track? other)
        {
            return id.CompareTo(other.id);
        }
    }

   class student:IComparable<student>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public student()
        {

        }
        public student(int ide)
        {
            this.id = id;
           
        }
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }
        public student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override bool Equals(object? obj)
        {
            student s= obj as student;
            return id == s.id;
        }
        public override string ToString()
        {
            return $"S id:{id} name:{name} age:{age} years old";
        }

        public int CompareTo(student? other)
        {
            return id.CompareTo(other.id);
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Dictionary<track, List<student>> d = new Dictionary<track, List<student>>();
            d.Add(new track(1, "dotNet", "full stack using .net"), new List<student>()
            {
                  new student(1,"mohamed",26),
                  new student(2,"ahmed",20),
                  new student(3,"ali",24),
                  new student(4,"hassan",22),
                  new student(5,"mohamed",25),
            });
            d.Add(new track(2, "php", "full stack using PHP"), new List<student>()
            {
                new student(1,"mohamed",26),
                 new student(2,"ahmed",20),
                  new student(3,"ali",24),

            });



            foreach (KeyValuePair<track,List<student>> item in d)
            {
                Console.WriteLine(item.Key);
                foreach (student items in item.Value )
                {
                    Console.WriteLine(items.ToString());
                }

            }







         
        }
    }
}