using System.Collections.Generic;
using CoreLogic;

namespace TodoListWpfApp
{
    public class NoteBoard : INoteBoard
    {
        public List<Note> Notes { get; set; }

        public void Initialize()
        {
            
        }

        public void CheckNote()
        {
            throw new System.NotImplementedException();
        }

        public void ShowNote()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteNote()
        {
            throw new System.NotImplementedException();
        }

        public void WriteNote()
        {
            throw new System.NotImplementedException();
        }
    }
}
