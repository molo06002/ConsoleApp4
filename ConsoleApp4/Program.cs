using System;
namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Test1 = "Du skrev talet 5!";
            string Text = "Skriv 5";
            Console.WriteLine(Text);
            string Test = Console.ReadLine();
            int test = Convert.ToInt32(Test);  
            if (test == 5);
            {
                Console.WriteLine(Test1);
            }
            string Test2 = "Du skrev talet 6!";
            string Text1 = "Skriv 6";
            Console.WriteLine(Text1);
            string Test4 = Console.ReadLine();
            int test5 = Convert.ToInt32(Test);
            if (test5 == 6);
            {
                Console.WriteLine(Test2);
            }
        }
    }
}