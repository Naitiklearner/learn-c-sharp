using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligiblity_to_vote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Password: ");
            string Password =  Console.ReadLine() ?? "error";

            if (Password == "naitik")
            {
                Console.Write("Enter your age: ");

                int intage = Convert.ToInt32(Console.ReadLine());

                if (intage >= 18)
                    Console.WriteLine("you are eligible to vote");
                else
                    Console.WriteLine("you are not eligible to vote");
                

            }
            else if (Password == "error")   
                Console.WriteLine("Provide a password");
            else
                Console.WriteLine("Password incorrect");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}