
using System.Linq;

namespace loputootitpe23KH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skip, join, ifelse, forloop");
            string e = Console.ReadLine();
            switch (e)
            {
                case "Skip":
                    skip();
                        break;
                case "join":
                    join();
                        break;
                    case "ifelse":
                    ifelse();
                    break;
                    case "forloop":
                    forloop();
                    break;
                default:
                    Console.WriteLine("ERROR: Vale tüüp");
                    break;


            }
        }
        static void skip()
        {
            var e = peoplelist.People.Skip(1);
            foreach (var item in e)
            {
                Console.WriteLine(item.name +" "+ item.age + " " + item.id);
            }
        }
        static void join()
        {
            var b = peoplelist.People.Join(
                joinbs.joincult,
                humans => humans.id,
                    Age => Age.age,
                    (humans, Age) => new
                    {
                        name = humans.name,
                        age = Age.id,
                    }


                );
                
            foreach (var item in b)
            {
                Console.WriteLine(item.name + " " + item.age);
            }
        }
        static void ifelse()
        {

            try
            {
                Console.WriteLine("Siseta asukoht");//C:/Users/opilane/Desktop
                string a = Console.ReadLine();
                Console.WriteLine("Sisesta failinimi");
                string b = Console.ReadLine();
                using (StreamWriter kirj = new StreamWriter(a+"/"+b)) //vaidame, et koht ja fail on "C:/Users/opilane/Desktop/mingifail.txt"
                {
                    Console.WriteLine("Sisesta tekst");
                    string e = Console.ReadLine();
                    kirj.WriteLine(e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Koht pole leitav");
            }
        }
        static void forloop()
        {
            int i, j;
            int n = 3;
            int e = 1;
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(e);
                    e++;
                }
                Console.Write("\n");
                
            }
        }
    }
}
