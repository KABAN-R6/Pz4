using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Date t1 = new Date(22, 1);
            Date t2 = new Date(16, 12);
            Date t3 = new Date(23, 1);
            


            t1.Display();
            t2.Display();
            t3.Display();

            if (t1._month < t2._month)
            {
                
                if (t2._month<t3._month)
                {
                    Console.WriteLine("3 дата больще");
                }
                else
                {
                    Console.WriteLine("2 дата больще");
                }
            }
            else
            {
                Console.WriteLine("1 дата больще");
            }
                
        }
        
    }
}
