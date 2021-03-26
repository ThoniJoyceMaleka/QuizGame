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

namespace quizGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> NumberOfQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int i;
        int score;
        public MainWindow()
        {
            InitializeComponent();

            StartGame();
            NextQuestion();
        }

        private void StartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
        }
        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly " + score + "/" + NumberOfQuestions.Count;

            NextQuestion();
        }

        private void NextQuestion()
        {

            if(qNum < NumberOfQuestions.Count)
            {
                i = NumberOfQuestions[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {
                case 1:
                    txtQuestion.Text = "A flower is a special kind of plant part. Flowers are also called the ___________ of a plant.";

                    ans1.Content = "Core";
                    ans2.Content = "Bloom/Blossom";
                    ans3.Content = "Food";
                    ans4.Content = "Head";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/2-1.jpg", UriKind.RelativeOrAbsolute));
                    break;

                case 2:
                    txtQuestion.Text = "What do you think the Alstoemeria symbolizes? ";

                    ans1.Content = "Friendship";
                    ans2.Content = "Love";
                    ans3.Content = "Truth";
                    ans4.Content = "Peace";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/3png.png", UriKind.RelativeOrAbsolute));
                    break;

                case 3:
                    txtQuestion.Text = "What do you think the Amaryllis symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Wealth";
                    ans3.Content = "Splendid beauty";
                    ans4.Content = "Love";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/4.png", UriKind.RelativeOrAbsolute));
                    break;

                case 4:
                    txtQuestion.Text = "What do you think the Anemone symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Wealth";
                    ans3.Content = "Success";
                    ans4.Content = "Anticipation";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/5.png", UriKind.RelativeOrAbsolute));
                    break;

                case 5 :
                    txtQuestion.Text = "What do you think the Anthurium symbolizes?";

                    ans1.Content = "Hospitality";
                    ans2.Content = "Health";
                    ans3.Content = "Calmness";
                    ans4.Content = "Peace";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/6.png", UriKind.RelativeOrAbsolute));
                    break;

                case 6:
                    txtQuestion.Text = "What do you think the Asiatic Lily symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Wealth";
                    ans3.Content = "Majesty";
                    ans4.Content = "Love";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/7.png", UriKind.RelativeOrAbsolute));
                    break;

                case 7:
                    txtQuestion.Text = "What do you think the Aster symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Patience";
                    ans3.Content = "Success";
                    ans4.Content = "Love";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/8.png", UriKind.RelativeOrAbsolute));
                    break;

                case 8:
                    txtQuestion.Text = "What do you think the Birds of Paradise symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Wealth";
                    ans3.Content = "Success";
                    ans4.Content = "Joyfulness";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/9.png", UriKind.RelativeOrAbsolute));
                    break;

                case 9:
                    txtQuestion.Text = "What do you think the Bouvardia symbolizes?";

                    ans1.Content = "Power";
                    ans2.Content = "Wealth";
                    ans3.Content = "Enthusiasm";
                    ans4.Content = "Love";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/10.png", UriKind.RelativeOrAbsolute));
                    break;

                case 10:
                    txtQuestion.Text = "What do you think the Abatina symbolizes?";

                    ans1.Content = "Fickleness";
                    ans2.Content = "Wealth";
                    ans3.Content = "Success";
                    ans4.Content = "Love";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"./img/11.jpg", UriKind.RelativeOrAbsolute));
                    break;
            }
        }
    }
}
