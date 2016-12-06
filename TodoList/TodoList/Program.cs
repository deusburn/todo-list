using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogic;

namespace TodoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userReaction = 0;

            var board = new NoteBoard();

            do
            {
                Console.WriteLine(
                    "------------------------------- \n" +
                    " The program has a functional : \n\n" +
                    " 1. Add post ; \n" +
                    " 2. Delete post ; \n" +
                    " 3. Show all posts ; \n" +
                    " 4. Check note ; \n" +
                    " 5. Exit ; \n\n" +
                    " Please enter the number :");

                userReaction = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (userReaction)
                {
                    case 1:
                        board.WriteNote();
                        break;
                    case 2:
                        board.DeleteNote();
                        break;
                    case 3:
                        board.ShowNote();
                        break;
                    case 4:
                        board.CheckNote();
                        break;
                }
            }
            while (userReaction != 5);
        }
    }
}
