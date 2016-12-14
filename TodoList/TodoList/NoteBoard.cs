using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CoreLogic;

namespace TodoList
{
    public class NoteBoard : INoteBoard
    {
        private readonly string _pathToFile = @"C:\Users\Otaman\Documents\todo-list\StoredData.txt";

        private readonly string _checkboxCheckedState = " [x] ";
        private readonly string _checkboxUncheckedState = " [ ] ";

        private void WriteNotesToFile()
        {
            File.WriteAllLines(_pathToFile,
                Notes.Select(n => ConvertNoteToString(n)));
        }

        public List<Note> Notes { get; set; }

        public void Initialize()
        {
            Notes = new List<Note>();

            var lines = File.ReadAllLines(_pathToFile);
            Notes.AddRange(lines.Select(l => ConvertStringToNote(l)));
        }

        public void CheckNote()
        {
            Console.WriteLine("Check note");
            var choseNote = Console.ReadLine();
            var number = Int32.Parse(choseNote);
            Notes[number - 1].Checkbox = CheckboxState.Checked;

            WriteNotesToFile();
        }

        public void ShowNote()
        {
            Console.WriteLine("You choosed Show all posts. Listed below already existing records");
            foreach (var n in Notes)
            {
                Console.WriteLine(ConvertNoteToString(n));
            }
        }

        public void DeleteNote()
        {
            Console.WriteLine("You choosed Delete post");

            Notes.Remove(Notes.Last());
            Console.WriteLine(" Last post deleted successfully");

            WriteNotesToFile();
        }

        public void WriteNote()
        {
            Console.WriteLine("You choosed Add post. Enter your line below");
            var enteredLine = Console.ReadLine();

            var note = new Note
            {
                Checkbox = CheckboxState.Unchecked,
                Record = enteredLine
            };
            Notes.Add(note);

            WriteNotesToFile();

            Console.WriteLine("You wrote: {0}", enteredLine);
            Console.WriteLine("post saved successfully");
        }

        private string ConvertNoteToString(Note note)
        {
            string result;
            if (note.Checkbox == CheckboxState.Checked)
            {
                result = _checkboxCheckedState + note.Record;
            }
            else
            {
                result = _checkboxUncheckedState + note.Record;
            }
            return result;
        }

        private Note ConvertStringToNote(string raw)
        {
            var note = new Note();
            if (raw.StartsWith(_checkboxCheckedState))
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
