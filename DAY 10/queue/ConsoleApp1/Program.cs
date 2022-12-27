using System.Drawing;
using System.Reflection.Emit;

namespace ConsoleApp1
{
  

    class queue<t>
    {
        t[] items { get; set; }
        int lastindex { get; set; }
        int x { get; set; }
        public queue(int size)
        {
            items = new t[size];
            lastindex = 0;
        }
        public void enqueue(t item)
        {
            if (lastindex < items.Length)
            {
                items[lastindex] = item;
                lastindex++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }



        }

        public t dequeue()
        {
            if (lastindex >= 0)
            {
               
                 
                return items[x++];
            }
            else
            {
                return default(t);
            }

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {


           
          
   queue<int> q1= new queue<int>(3);
            q1.enqueue(5);
            q1.enqueue(4);
            q1.enqueue(3);
            Console.WriteLine(q1.dequeue());

         
        }
    }
}