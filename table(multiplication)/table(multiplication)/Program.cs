using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace table 
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter the password: ");
            string Password = Console.ReadLine() ?? "error";
            
            if (Password == "naitik")
            {
                Console.Write("Enter the number of table which you want to print: ");

                int intnum = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                Console.WriteLine(Convert.ToString(intnum) + " * " + i + " = " + intnum * i);
                }
            }
            else
            {
                Console.WriteLine("Password incorrect");
            }
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}