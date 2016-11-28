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
//            var note = new Note();
//            note.Checkbox = CheckboxState.Unchecked;
            var board = new NoteBoard();
//            board.Notes.Add(note);

            int userReaction = 0;
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
                        Console.WriteLine("You choosed Add post. Enter your line below");
                        var enteredLine = Console.ReadLine();

                        var note = new Note();
                        note.Checkbox = CheckboxState.Unchecked;
                        note.Record = enteredLine;
                        board.Notes.Add(note);

                        Console.WriteLine("You wrote: {0}", enteredLine);
                        Console.WriteLine("post saved successfully");
                        break;
                    case 2:
                        Console.WriteLine("You choosed Delete post");
                        
                        board.Notes.Remove(board.Notes.Last());
                        Console.WriteLine(" Last post deleted successfully");
                        break;
                    case 3:
                        Console.WriteLine("You choosed Show all posts. Listed below already existing records");
                        foreach (var n in board.Notes)
                        {
                            if ( n.Checkbox == CheckboxState.Checked)
                            {
                                Console.WriteLine(" [x] " + n.Record);
                            }
                            else
                            {
                                Console.WriteLine(" [ ] " + n.Record);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Check note");
                        var choseNote = Console.ReadLine();
                        var number = int.Parse(choseNote);
                        board.Notes[number - 1].Checkbox = CheckboxState.Checked;
                        break;;
                }
            }
            while (userReaction != 5);
        }
    }
}
