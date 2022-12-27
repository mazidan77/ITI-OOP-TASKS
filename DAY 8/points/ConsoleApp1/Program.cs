using System;
using System.Numerics;

namespace ConsoleApp1
{
    class point3D:IComparable
    {

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public point3D()
        {

        }

        public point3D(int x)
        {
            this.x = x;
        }
        public point3D(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public point3D(int x, int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: {x},{y},{z}";
        }

        public int CompareTo(object? obj)
        {
            point3D f = obj as point3D;
            return x.CompareTo(f.x);

        }

        public static bool operator == (point3D a, point3D b)
        {
            return a.x == b.x && a.y == b.y && a.z==b.z ;
        }
        public static bool operator != (point3D a, point3D b)
        {
            return a.x != b.x || a.y != b.y ||  a.z != b.z;
        }


        public static implicit operator string(point3D c)
        {
            return $"{c.x},{c.y},{c.z}";
        }

        public override bool Equals(object? obj)
        {
            point3D a= obj as point3D;
            return x.Equals(a.x) && y.Equals(a.y)&&z.Equals(a.z);
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {

            //point3D p1= new point3D(10,20,30);
            //  Console.WriteLine(p1);

            //  string s = p1;
            //  Console.WriteLine(s);
            int x;
            int y;
            int z;
            bool res;

            point3D[] arr = new point3D[2];
            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = new point3D();
                do
                {
                    Console.WriteLine($"enter x of point {i + 1}");
                    res = int.TryParse(Console.ReadLine(), out x);
                    arr[i].x = x;
                }
                while (res == false);
                do
                {
                    Console.WriteLine($"enter y of point {i + 1}");
                    res = int.TryParse(Console.ReadLine(), out y);
                    arr[i].y = y;
                }
                while (res == false);
                do
                {
                    Console.WriteLine($"enter z of point {i + 1}");
                    res = int.TryParse(Console.ReadLine(), out z);
                    arr[i].z = z;
                }
                while (res == false);
            }
          
            Array.Sort(arr);    

            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

            Console.WriteLine("--------------------------");

            if (arr[0] == arr[1])
            {
                Console.WriteLine($"Point 1 = Point 2");
            }
            else
            {
                Console.WriteLine($"Point 1 != Point 2");
            }
            
            string s = arr[0];
            Console.WriteLine(s);
        }


    }
    }
