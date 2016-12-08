using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class NoteBoard
    {
        public List<Note> Notes = new List<Note>();

        public void Initialize()
        {
            var lines = File.ReadAllLines(@"C:\Users\Otaman\Documents\todo-list\StoredData.txt");
//            foreach (var line in lines)
//            {
//                var note = new Note();
//                note.Record = line;
//                Notes.Add(note);
//            }
            Notes.AddRange(lines.Select(l => ConvertStringToNote(l)));
        }

        public void CheckNote()
        {
            Console.WriteLine("Check note");
            var choseNote = Console.ReadLine();
            var number = Int32.Parse(choseNote);
            Notes[number - 1].Checkbox = CheckboxState.Checked;

            File.WriteAllLines(@"C:\Users\Otaman\Documents\todo-list\StoredData.txt",
                Notes.Select(n => ConvertNoteToString(n)));
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

            File.WriteAllLines(@"C:\Users\Otaman\Documents\todo-list\StoredData.txt",
                Notes.Select(n => ConvertNoteToString(n)));
        }

        public void WriteNote()
        {
            Console.WriteLine("You choosed Add post. Enter your line below");
            var enteredLine = Console.ReadLine();

            var note = new Note();
            note.Checkbox = CheckboxState.Unchecked;
            note.Record = enteredLine;
            Notes.Add(note);

            File.WriteAllLines(@"C:\Users\Otaman\Documents\todo-list\StoredData.txt", 
                Notes.Select(n => ConvertNoteToString(n)));

            Console.WriteLine("You wrote: {0}", enteredLine);
            Console.WriteLine("post saved successfully");
        }

        private string ConvertNoteToString(Note note)
        {
            string result;
            if (note.Checkbox == CheckboxState.Checked)
            {
                result = " [x] " + note.Record;
            }
            else
            {
                result = " [ ] " + note.Record;
            }
            return result;
        }

        private Note ConvertStringToNote(string raw)
        {
            var note = new Note();
            if (raw.StartsWith(" [x] "))
            {
                note.Checkbox = CheckboxState.Checked;
            }
            else
            {
                note.Checkbox = CheckboxState.Unchecked;
            }
            note.Record = raw.Substring(5);

            return note;
        }
    }
}
