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

namespace TodoListWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            NotesListBox.ItemsSource = new List<NoteItem>()
            {
                new NoteItem() {Checked = false, Text = "asdf"},
                new NoteItem() {Checked = true, Text = "asdf2"}
            };
        }

        public class NoteItem
        {
            public bool Checked { get; set; }
            public string Text { get; set; }
        }
    }
}
