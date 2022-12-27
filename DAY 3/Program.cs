using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace challenge
{


    class player
    {


      
        public int number { get; set; }
        public string name { get; set; }
        public string position { get; set; }

        //CONSTRUCTORS

        public player()
        {
            this.number = 0;
            this.name = "unknown";
            this.position = "unknown";
        }

        public player(int number, string name, string position)
        {
            this.number = number;
            this.name = name;
            this.position = position;   
        }
        public player(int number , string name)
        {
            this.number = number;
            this.name = name;
            this.position = "unknown";
        }
       

        public string getsting()
        {
            return $"player number:{number}  name:{name}  position:{position}";
        }
        
        }
    class team
    {
        public int id { get; set; }
        public string name { get; set; }

        public player[] play { get; set; }

        public team(int id, string name, player[] play)
        {
            this.id = id;
            this.name = name;
            this.play = play;
        }
        public team()
        {
            
        }
        public string getstring()
        {
           string text= $"team id:{id}  team name:{name} \n   ";

            for(int i=0; i<play.Length; i++) {

                text += play[i].getsting()+"\n";
            
            }
            return text ;   
        }
    }

    




    internal class Program
    {

        static void Main(string[] args)
        {


            //player[] a = new player[]
            //{
            //    new player (1,"mohamed","mid"),
            //    new player (2,"ahmed","gk"),
            //    new player (3,"omar","def"),
            //    new player (4,"abdalla","def"),
            //    new player (5,"ali","mid"),
            //   new player (6,"basel","attack"),
            //    new player (7,"mohamed","attack"),
            //};
            //team t = new team(1, "real", a);

            //Console.WriteLine(t.getstring());

            #region from user
            team t = new team();
            Console.WriteLine("enter team id ");
            t.id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter team name");
            t.name = Console.ReadLine();


            Console.WriteLine("enter number of players");
            int number_of_players = int.Parse(Console.ReadLine());

            player[] arr = new player[number_of_players];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new player();
                Console.WriteLine($"enter number of player {i + 1}");
                arr[i].number = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter name of player {i + 1}");
                arr[i].name = Console.ReadLine();
                Console.WriteLine($"enter position of player number {i + 1}");
                arr[i].position = Console.ReadLine();
                Console.WriteLine("----------------");
            }

            t.play = arr;

            Console.WriteLine(t.getstring());



            #endregion


            #region bonus

            Console.WriteLine("enter number of teams");
            int number_of_teams = int.Parse(Console.ReadLine());

            team[] arr1 = new team[number_of_teams];


            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new team();
                Console.WriteLine($"enter id for team number {i + 1}");
                arr1[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter name of team number {i + 1}");
                arr1[i].name = Console.ReadLine();
                Console.WriteLine($"enter number of player of team number {i + 1}");
                int numbers_of_players = int.Parse(Console.ReadLine());
                player[] arr2 = new player[numbers_of_players];
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = new player();
                    Console.WriteLine($"enter number of player {j + 1}");
                    arr2[j].number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"enter name of player {j + 1}");
                    arr2[j].name = Console.ReadLine();
                    Console.WriteLine($"enter position of player number {j + 1}");
                    arr2[j].position = Console.ReadLine();
                    Console.WriteLine("----------------");

                }
                arr1[i].play = arr2;

            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i].getstring());
            }



            #endregion

        }
    }
}