using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class NoteBoard
    {
        public List<Note> Notes = new List<Note>();

        public void CheckNote()
        {
            Console.WriteLine("Check note");
            var choseNote = Console.ReadLine();
            var number = Int32.Parse(choseNote);
            Notes[number - 1].Checkbox = CheckboxState.Checked;
        }

        public void ShowNote()
        {
            Console.WriteLine("You choosed Show all posts. Listed below already existing records");
            foreach (var n in Notes)
            {
                if (n.Checkbox == CheckboxState.Checked)
                {
                    Console.WriteLine(" [x] " + n.Record);
                }
                else
                {
                    Console.WriteLine(" [ ] " + n.Record);
                }
            }
        }

        public void DeleteNote()
        {
            Console.WriteLine("You choosed Delete post");

            Notes.Remove(Notes.Last());
            Console.WriteLine(" Last post deleted successfully");
        }

        public void WriteNote()
        {
            Console.WriteLine("You choosed Add post. Enter your line below");
            var enteredLine = Console.ReadLine();

            var note = new Note();
            note.Checkbox = CheckboxState.Unchecked;
            note.Record = enteredLine;
            Notes.Add(note);

            Console.WriteLine("You wrote: {0}", enteredLine);
            Console.WriteLine("post saved successfully");
        }
    }
}
