using System;

namespace To_print_msg.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Teach One, Each One, Tree One");
            }
            Console.ReadLine();
        }
    }
}
