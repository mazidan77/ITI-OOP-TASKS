using System.Diagnostics;

namespace task
{

    abstract class question
    {
        
        public int id { get; set; }
        public string body { get; set; }
        public int mark { get; set; }

        public abstract string show();

        //constructor
        public question()
        {

        }

        public question(int id)
        {
            this.id = id;
        }
        public question(int id , string body)
        {
            this.id = id;
            this.body = body;
        }

        public question(int id, string body , int mark)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;

        }
    }
  
    class mcq : question
    {

        public string c1 { get; set; }
        public string c2 { get; set; }
        public string c3 { get; set; }
        public string c4 { get; set; }

        public mcq()
        {

        }
        public mcq(string c1 , string c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }
        public mcq(string c1,string c2, string c3, string c4)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;
        }

        public mcq(int id, string body , int mark , string c1, string c2, string c3, string c4)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;
        }
     
        public override string show()
        {
            return $"{id}-{body}  --mark:({mark})\na.{c1}\nb.{c2}\nc.{c3}\nd.{c4}";
        }


    }

    class tof : question
    {
        public tof(int id , string body , int mark)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;
        }
        public tof()
        {

        }
        public tof(int id, string body)
        {
            this.id = id;
            this.body = body;
        }
        public override string show()
        {
            return $"{id}-{body}  --mark:({mark})\na.true \nb.false\n";
        }
    }

    internal class Program
    {

    
        static void Main(string[] args)
        {

            #region static
            //     mcq[] arr = new[]
            //     {
            //                  new mcq (1,"question tilte",20,"choose 1","choose 2","choose 3","choose4"),
            //                  new mcq (2,"question tilte",20,"choose 1","choose 2","choose 3","choose4"),
            //                  new mcq (3,"question tilte",20,"choose 1","choose 2","choose 3","choose4"),
            //                  new mcq (4,"question tilte",20,"choose 1","choose 2","choose 3","choose4"),
            //                  new mcq (5,"question tilte",20,"choose 1","choose 2","choose 3","choose4")

            //     };

            //     for (int i = 0; i < arr.Length; i++)
            //     {
            //         Console.WriteLine(arr[i].show());
            //         Console.WriteLine("-----------------------");
            //     }
            //     Console.WriteLine("============================");

            //     tof[] arr2 = new[]
            //{
            //                  new tof (1,"question tilte",20),
            //                    new tof (2,"question tilte",20),
            //                     new tof (3,"question tilte",20),
            //                      new tof (4,"question tilte",20),
            //                       new tof (5,"question tilte",20),
            //     };

            //     for (int i = 0; i < arr2.Length; i++)
            //     {
            //         Console.WriteLine(arr2[i].show());
            //         Console.WriteLine("-----------------------");
            //     }
            #endregion


            Console.WriteLine("enter number of MCQ questions");
            int number_mcq = int.Parse(Console.ReadLine());
            mcq[] arr3 = new mcq[number_mcq];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = new mcq();
                Console.WriteLine($"enter id of question number {i + 1}");
                arr3[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter body of question number{i + 1}");
                arr3[i].body = Console.ReadLine();
                Console.WriteLine($"enter mark of question number {i + 1}");
                arr3[i].mark = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter choose (A) of question number {i + 1}");
                arr3[i].c1 = (Console.ReadLine());
                Console.WriteLine($"enter choose (B) of question number{i + 1}");
                arr3[i].c2 = (Console.ReadLine());
                Console.WriteLine($"enter choose (C) of question number {i + 1}");
                arr3[i].c3 = (Console.ReadLine());
                Console.WriteLine($"enter choose (D) of question number {i + 1}");
                arr3[i].c4 = (Console.ReadLine());
                Console.WriteLine("-------------");
            }


            Console.WriteLine("enter number of TOF questions");
            int number_tof = int.Parse(Console.ReadLine());
            tof[] arr4 = new tof[number_tof];
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = new tof();
                Console.WriteLine($"enter id of question {i + 1}");
                arr4[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter body of question {i + 1}");
                arr4[i].body = Console.ReadLine();
                Console.WriteLine($"enter mark of question {i + 1}");
                arr4[i].mark = int.Parse(Console.ReadLine());
               
                Console.WriteLine("-------------");
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i].show());
                Console.WriteLine("----------------");
            }



            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i].show());
                Console.WriteLine("----------------");
            }


        }
    }
}