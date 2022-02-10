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

namespace FrågesportNya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<QuestionCard> frågor;
        private int KorrektaSvar = 0;
        private int Frågenummer = 0;
        private int Svarnummer = 0;

        public MainWindow()
        {
            InitializeComponent();
            frågor = new List<QuestionCard>();
            frågor.Add(new QuestionCard("Vad är 4+4?", "9", "8", "25"));
            frågor.Add(new QuestionCard("Vilken färg är solen?", "Gul", "Blå", "Hot Pink"));
            frågor.Add(new QuestionCard("Är detta en flervalsfråga?", "Ja", "Nej", "Kanske"));
            QuestionOne.Text = frågor[Frågenummer].Fråga;
            Answer1.Content = 

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            textOne.Visibility = Visibility.Collapsed;
            Start.Visibility = Visibility.Collapsed;
            QuestionOne.Visibility = Visibility.Visible;
            FirstQuestion.Visibility = Visibility.Visible;

            
        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            Frågenummer = Frågenummer + 1;
            QuestionOne.Text = frågor[Frågenummer].Fråga;

        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {
            Frågenummer = Frågenummer + 1;
            QuestionOne.Text = frågor[Frågenummer].Fråga;

        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {
            Frågenummer = Frågenummer + 1;
            QuestionOne.Text = frågor[Frågenummer].Fråga;

        }

    }
}
