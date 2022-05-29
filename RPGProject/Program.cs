using RPGProject.src.Entities;

namespace RPGProject
{
    public class Program
    {
        static void Main (string[] args)
        {
            Knight arus = new Knight("Arus");
            Wizard topapa = new Wizard("Topapa");
            Ninja wedge = new Ninja("Wedge");

            Console.WriteLine(arus.ToString());
            Console.WriteLine(topapa.ToString());
            Console.WriteLine(wedge.ToString());

            Console.WriteLine("\n\n");
            
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.Attack(7));
            Console.WriteLine("-----------------------------------");
        }
    }
}
