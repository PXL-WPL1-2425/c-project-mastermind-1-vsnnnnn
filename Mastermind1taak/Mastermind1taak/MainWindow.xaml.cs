using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mastermind1taak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
  
    public partial class MainWindow : Window
        {
            private string[] beschikbareKleuren = { "Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw" };
            private string color1, color2, color3, color4;

            public MainWindow()
            {
                InitializeComponent();
                GenereerGeheimeCode(out color1, out color2, out color3, out color4);
                Title = "MijnMastermind" + color1 + color2 + color3 + color4;
            }



            private void GenereerGeheimeCode(out string color1, out string color2, out string color3, out string color4)
            {
                Random random = new Random();
                List<string> colorList = new List<string>();
                string randomColor;
                for (int i = 0; i < 4; i++)
                {
                    randomColor = random.Next(1, 7).ToString();
                    switch (randomColor)
                    {
                        case "1":
                            randomColor = "Rood";
                            break;
                        case "2":
                            randomColor = "Blauw";
                            break;
                        case "3":
                            randomColor = "Geel";
                            break;
                        case "4":
                            randomColor = "Groen";
                            break;
                        case "5":
                            randomColor = "Oranje";
                            break;
                        case "6":
                            randomColor = "Wit";
                            break;
                    }
                    colorList.Add(randomColor);
                }
                color1 = colorList[0];
                color2 = colorList[1];
                color3 = colorList[2];
                color4 = colorList[3];



            }

            private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (Cbox1.SelectedIndex)
                {
                    case 0:
                        labelbox1.Background = Brushes.Red;
                        break;
                    case 1:
                        labelbox1.Background = Brushes.Blue;
                        break;
                    case 2:
                        labelbox1.Background = Brushes.Yellow;
                        break;
                    case 3:
                        labelbox1.Background = Brushes.Green;
                        break;
                    case 4:
                        labelbox1.Background = Brushes.Orange;
                        break;
                    case 5:
                        labelbox1.Background = Brushes.White;
                        break;
                }


            }

            private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (cBox2.SelectedIndex)
                {
                    case 0:
                        labelbox2.Background = Brushes.Red;
                        break;
                    case 1:
                        labelbox2.Background = Brushes.Blue;
                        break;
                    case 2:
                        labelbox2.Background = Brushes.Yellow;
                        break;
                    case 3:
                        labelbox2.Background = Brushes.Green;
                        break;
                    case 4:
                        labelbox2.Background = Brushes.Orange;
                        break;
                    case 5:
                        labelbox2.Background = Brushes.White;
                        break;
                }
            }

            private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (cBox3.SelectedIndex)
                {
                    case 0:
                        labelbox3.Background = Brushes.Red;
                        break;
                    case 1:
                        labelbox3.Background = Brushes.Blue;
                        break;
                    case 2:
                        labelbox3.Background = Brushes.Yellow;
                        break;
                    case 3:
                        labelbox3.Background = Brushes.Green;
                        break;
                    case 4:
                        labelbox3.Background = Brushes.Orange;
                        break;
                    case 5:
                        labelbox3.Background = Brushes.White;
                        break;


                }
            }

            private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (cBox4.SelectedIndex)
                {
                    case 0:
                        labelbox4.Background = Brushes.Red;
                        break;
                    case 1:
                        labelbox4.Background = Brushes.Blue;
                        break;
                    case 2:
                        labelbox4.Background = Brushes.Yellow;
                        break;
                    case 3:
                        labelbox4.Background = Brushes.Green;
                        break;
                    case 4:
                        labelbox4.Background = Brushes.Orange;
                        break;
                    case 5:
                        labelbox4.Background = Brushes.White;
                        break;
                }

            }

            private void codeKnop_Click(object sender, RoutedEventArgs e)
            {
                List<string> Colorbook = new List<string>
            {
                color1, color2, color3,color4
            };
                string chosenColor1 = Cbox1.Text;
                string chosenColor2 = cBox2.Text;
                string chosenColor3 = cBox3.Text;
                string chosenColor4 = cBox4.Text;

                List<string> Colorp = new List<string>
            {
                chosenColor1 , chosenColor2 , chosenColor3 , chosenColor4
            };
                for (int i = 0; i < 4; i++)
                {
                    Label temporaryLabel = null;
                    switch (i)
                    {
                        case 0:
                            temporaryLabel = labelbox1;
                            break;
                        case 1:
                            temporaryLabel = labelbox2;
                            break;
                        case 2:
                            temporaryLabel = labelbox3;
                            break;

                        case 3:
                            temporaryLabel = labelbox4;
                            break;
                    }
                    if (Colorbook[i] == Colorp[i])
                    {
                        temporaryLabel.BorderBrush = Brushes.DarkRed;
                        temporaryLabel.BorderThickness = new Thickness(5);
                    }
                    else if (Colorbook.Contains(Colorp[i]))
                    {
                        temporaryLabel.BorderBrush = Brushes.Wheat;
                        temporaryLabel.BorderThickness = new Thickness(5);
                    }
                }
            }
        }//Commit 4
    }

