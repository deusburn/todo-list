using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoreLogic;

namespace TodoListWpfApp
{
    /// <summary>
    /// Interaction logic for AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        public NoteBoard Board { private get; set; }

        public AddNoteWindow()
        {
            InitializeComponent();

            OkButton.Click += OkButton_Click;
            CancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Board.WriteNote();
            Board.Notes.Add(new Note()
            {
                Checkbox = CheckboxState.Unchecked,
                Record = NoteTextBox.Text
            });

            this.Close();
        }
    }
}
