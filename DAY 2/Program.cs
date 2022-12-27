using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace app1
{

    struct time
    {
        int hour;
        public void set_hour(int _hour)
        {
            if(_hour>0)
                hour = _hour;
            else
                hour = 0;
        }
        public int set_hour() {
            return hour;
        }


        int min;
        public void set_min(int _min)
        {
            if (_min > 0)
                min = _min;
            else
                min = 0;

        }
        public int get_in()
        {
            return min;
        }

        int second;

        public void set_second (int _second)
        {
            if (_second >0)
                second = _second;
            else
                second = 0;
        }
        public int get_second()
        {
            return second;
        }
        public void print()
        {
            Console.WriteLine($" hour:{hour} min:{min} second:{second}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {



            #region one dim 


            //Console.WriteLine("enter number of students");
            //int number_of_students = int.Parse(Console.ReadLine());
            //int[] grades = new int[number_of_students];
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"enter grade of student number {i + 1}");
            //    grades[i] = int.Parse(Console.ReadLine());

            //}
            //int sum = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"grade of student number {i + 1} : {grades[i]}");
            //    sum += grades[i];
            //}

            //Console.WriteLine($"sum of grades = {sum}");

            #endregion

            #region multi dim
            //Console.WriteLine("enter number of students");
            //int number_of_students = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter number of subjects");
            //int number_of_subject = int.Parse(Console.ReadLine());

            //int[,] arr = new int[number_of_students, number_of_subject];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"grades in students number {i + 1}");
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"grades in subject number {j + 1}");
            //        arr[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{

            //    Console.WriteLine($"grades i n student number{i + 1}");
            //    Console.WriteLine("---------------");
            //    int sum = 0;

            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"grade in subject number{j + 1}={arr[i, j]}");
            //        sum += arr[i, j];

            //    }
            //    Console.WriteLine($"sum of student number {i + 1} :{sum}");

            //    Console.WriteLine("------------------------------------------------");
            //}
            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    int sum = 0;
            //    int j = 0;
            //    for (; j < arr.GetLength(0); j++)
            //    {
            //        sum += arr[j, i];
            //    }
            //    Console.WriteLine($"avr of subject number{i + 1}: {sum / number_of_students}");
            //}


            #endregion

            #region jagged
            //Console.WriteLine("enter number of students");
            //int number_of_students = int.Parse(Console.ReadLine());

            //int[][] arr = new int[number_of_students][];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter number of subject of student number {i + 1}");
            //    int number_of_subjects = int.Parse(Console.ReadLine());
            //    arr[i] = new int[number_of_subjects];
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine($"enter grade of subject num {j + 1}");
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int sum = 0;
            //    Console.WriteLine($"grades in student number {i + 1}");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine($"grade in subject number{j + 1} = {arr[i][j]}");
            //        sum += arr[i][j];
            //    }
            //    Console.WriteLine($"sum = :{sum}");
            //    Console.WriteLine("-------------");
            //}








            #endregion

            #region time
            //time c = new time();
            //c.set_hour(1);
            //c.set_min(20);
            //c.set_second(-20);
            //c.print();
            #endregion

            #region time arr
            Console.WriteLine("enter number of times");
            int number_of_times = int.Parse(Console.ReadLine());
            time[] arr = new time[number_of_times];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter hour of time number {i + 1}");
                arr[i].set_hour(int.Parse(Console.ReadLine()));
                Console.WriteLine($"enter min of time number {i + 1}");
                arr[i].set_min(int.Parse(Console.ReadLine()));
                Console.WriteLine($"enter second of time number {i + 1}");
                arr[i].set_second(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"time number {i + 1}");
                arr[i].print();
            }
            #endregion
             
        }

    }
}