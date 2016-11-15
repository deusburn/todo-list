using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            int userReaction = 0;
            do
            {
                Console.WriteLine(
                    "------------------------------- \n" +
                    " The program has a functional : \n\n" +
                    " 1. Add post ; \n" +
                    " 2. Delete post ; \n" +
                    " 3. Show all posts ; \n" +
                    " 4. Exit ; \n\n" +
                    " Please enter the number :");

                userReaction = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (userReaction)
                {
                    case 1:
                        Console.WriteLine("You choosed Add post. Enter your line below");
                        var one = Console.ReadLine();
                        Console.WriteLine("You wrote: {0}", one);
                        Console.WriteLine("post saved successfully");
                        break;
                    case 2:
                        Console.WriteLine("You choosed Delete post");
                        Console.WriteLine(" Last post deleted successfully");
                        break;
                    case 3:
                        Console.WriteLine("You choosed Show all posts. Listed below already existing records");
                        string a = "1998";
                        string c = "1876";
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                        break;
                }
            } while (userReaction != 4);
        }
    }
}
