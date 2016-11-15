using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        private static readonly List<String> Posts = new List<string>();

        static void Main(string[] args)
        {
            ////add post
            //Posts.Add("asdf asdf asdf");
            //Posts.Add("asdf 2");
            //Posts.Add("asdf 3");
            ////delete post
            //Posts.Remove(Posts.Last());
            ////show posts
            //foreach (var post in Posts)
            //{
            //    Console.WriteLine(post);
            //}
            
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
                        var enteredLine = Console.ReadLine();
                        Posts.Add(enteredLine);
                        Console.WriteLine("You wrote: {0}", enteredLine);
                        Console.WriteLine("post saved successfully");
                        break;
                    case 2:
                        Console.WriteLine("You choosed Delete post");
                        Posts.Remove(Posts.Last());
                        Console.WriteLine(" Last post deleted successfully");
                        break;
                    case 3:
                        Console.WriteLine("You choosed Show all posts. Listed below already existing records");
                        foreach (var post in Posts)
                        {
                            Console.WriteLine(post);
                        }
                        break;
                }
            }
            while (userReaction != 4);
        }
    }
}
