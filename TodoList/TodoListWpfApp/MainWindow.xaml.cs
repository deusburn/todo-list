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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CoreLogic;

namespace TodoListWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NoteBoard Board { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            AddNote.Click += AddNote_Click;
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            var popup = new AddNoteWindow();
            popup.Board = Board;
            popup.Show();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Board = new NoteBoard();
            Board.Initialize();

            var data = Board.Notes.Select(n => new NoteItem()
            {
                Checked = (n.Checkbox == CheckboxState.Checked),
                Text = n.Record
            });

            NotesListBox.ItemsSource = data;
        }

        public class NoteItem
        {
            public bool Checked { get; set; }
            public string Text { get; set; }
        }
    }
}
