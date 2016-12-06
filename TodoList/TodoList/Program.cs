using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogic;
using System.IO;

namespace TodoList
{
    public class Program
    {
        static void DoAction(NoteBoard board , int userReaction)
        {
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
        static void ShowFunction()
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
        }

        static void Main(string[] args)
        {
            int userReaction = 0;
            var board = new NoteBoard();
            board.Initialize();

            do
            {
                try
                {
                    ShowFunction();

                    userReaction = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    DoAction(board, userReaction);
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine(" You entered not correct number !!! ");
                    Console.WriteLine();
                }
            } while (userReaction != 5);
        }
    }
}
