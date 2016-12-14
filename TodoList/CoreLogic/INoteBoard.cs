using System.Collections.Generic;

namespace CoreLogic
{
    public interface INoteBoard
    {
        List<Note> Notes { get; set; }

        void Initialize();
        void CheckNote();
        void ShowNote();
        void DeleteNote();
        void WriteNote();
    }
}
