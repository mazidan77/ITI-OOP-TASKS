namespace EmpoClass
{
    public class Empo
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }


        public Empo()
        {

        }
        public Empo(int id)
        {
            this.id = id;
        }
        public Empo(int id, int age)
        {
            this.id = id;
            this.age = age;
        }
        public Empo(int id, int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }
        public string getstring()
        {
            return $"{id}-{age} your age is {age}";
        }
    }
}