using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Date t1 = new Date(22, 12);
            Date t2 = new Date(16, 10);
            Date t3 = new Date(23, 5);
            


            t1.Display();
            t2.Display();

            if (t1._month < t2._month)
            {
                Console.WriteLine("2 дата больще");
            }
            else
            {
                Console.WriteLine("1 дата больще");
            }
                
        }
        
    }
}
