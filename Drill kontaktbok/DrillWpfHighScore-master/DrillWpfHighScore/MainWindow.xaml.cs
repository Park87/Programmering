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

namespace DrillWpfHighScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med poäng
        private List<Contact> phonebook = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveScore_Click(object sender, RoutedEventArgs e)
        {
            phonebook.Add(new Contact(PlayerName.Text, Score.Text, Telnum.Text));

            phonebook.Sort();

            int lastIndex = phonebook.Count() - 1;
            TextBlock insert = new TextBlock();
            insert.Text = phonebook[lastIndex].ToString();
            Phonebook.Children.Add(insert);
        }



    }
}
