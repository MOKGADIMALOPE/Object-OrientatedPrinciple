using objectorientatedprinciples;

class Program
{
    static void Main(string[] args)
    {
        People Person1 = new People("Nomathemba", "Black", 20, "Female");
        People Person2 = new People("Busisiwe", "Black", 10, "Female");
        People Person3 = new People("Omphile", " Black", 27, "Male");

        Console.WriteLine(Person1.name + " " + Person1.race + " " + Person1.age + " " + Person1.gender);
        Console.WriteLine(Person2.name + " " + Person2.race + " " + Person2.age + " " + Person2.gender);
        Console.WriteLine(Person3.name + " " + Person3.race + " " + Person3.age + " " + Person3.gender);






    }




}



