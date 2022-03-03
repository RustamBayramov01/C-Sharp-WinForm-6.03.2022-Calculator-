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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double Num = 0, NumTwo = 0, n;

        bool First = false;
        bool NumTwoTrue = false;

        string Select = "";

        public MainWindow()
        {
            InitializeComponent();

            
            Text1.Content = "0";
            Text2.Content = "";

        }

        private void Button_Click(object sender, RoutedEventArgs e) { Close(); }

        

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try { DragMove(); }
            catch (Exception) { throw; }
        }

        

        

        private void AllNumberEvent(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                Button btn = (Button)sender;

                if(btn.Name == "n1")
                {
                    if (First == true) Text1.Content += "1";
                    else
                    {
                        Text1.Content = "1";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n2")
                {
                    if (First == true) Text1.Content += "2";
                    else
                    {
                        Text1.Content = "2";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n3")
                {
                    if (First == true) Text1.Content += "3";
                    else
                    {
                        Text1.Content = "3";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n4")
                {
                    if (First == true) Text1.Content += "4";
                    else
                    {
                        Text1.Content = "4";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n5")
                {
                    if (First == true) Text1.Content += "5";
                    else
                    {
                        Text1.Content = "5";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n6")
                {
                    if (First == true) Text1.Content += "6";
                    else
                    {
                        Text1.Content = "6";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n7")
                {
                    if (First == true) Text1.Content += "7";
                    else
                    {
                        Text1.Content = "7";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n8")
                {
                    if (First == true) Text1.Content += "8";
                    else
                    {
                        Text1.Content = "8";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if (btn.Name == "n9")
                {
                    if (First == true) Text1.Content += "9";
                    else
                    {
                        Text1.Content = "9";
                        First = true;
                    }

                    if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                    else { NumTwo = double.Parse((string)Text1.Content); }
                }
                else if(btn.Name == "n0")
                {
                    if (Text1.Content != "0")
                    {
                        if (First == true) Text1.Content += "0";
                        else
                        {
                            Text1.Content = "0";
                            First = true;
                        }

                        if (NumTwoTrue == false) Num = double.Parse((string)Text1.Content);
                        else { NumTwo = double.Parse((string)Text1.Content); }
                    }
                }
            }
        }



        public void AllSelectionEvent(object sender, RoutedEventArgs e)
        {

            if(sender is Button)
            {

                Button btn = (Button)sender;

                if (btn.Name == "Topla" && Text1.Content != "0")
                {

                    Select = "+";

                    if (NumTwoTrue == true)
                    {
                        string result = "";
                        result += Num + NumTwo;
                        Text1.Content = result;
                        Text2.Content += NumTwo + " + ";
                        Num = double.Parse(result);
                        First = false;
                    }
                    else
                    {
                        NumTwoTrue = true;
                        Text2.Content = Num + " + ";
                        First = false;
                    }

                }
                else if (btn.Name == "Cix" && Text1.Content != "0")
                {

                    Select = "-";

                    if (NumTwoTrue == true)
                    {
                        string result = "";
                        result += Num - NumTwo;
                        Text1.Content = result;
                        Text2.Content += Num + " - ";
                        Num = double.Parse(result);
                        First = false;
                    }
                    else
                    {
                        NumTwoTrue = true;
                        Text2.Content = Num + " - ";
                        First = false;
                    }
                }
                else if (btn.Name == "Vur" && Text1.Content != "0")
                {

                    Select = "*";

                    if (NumTwoTrue == true)
                    {
                        string result = "";
                        result += Num * NumTwo;
                        Text1.Content = result;
                        Text2.Content += Num + " * ";
                        Num = double.Parse(result);
                        First = false;
                    }
                    else
                    {
                        NumTwoTrue = true;
                        Text2.Content = Num + " * ";
                        First = false;
                    }
                }
                else if (btn.Name == "Bol" && Text1.Content != "0")
                {

                    Select = "÷";

                    if (NumTwoTrue == true)
                    {
                        string result = "";
                        result += Num / NumTwo;
                        Text1.Content = result;
                        Text2.Content += Num + " ÷ ";
                        Num = double.Parse(result);
                        First = false;
                    }
                    else
                    {
                        NumTwoTrue = true;
                        Text2.Content = Num + " ÷ ";
                        First = false;
                    }
                }
                else if (btn.Name == "Beraber")
                {
                    string result = "";

                    if (Num != 0 && NumTwo != 0)
                    {
                        if (Select == "+")
                        {
                            result += Num + NumTwo;
                            Text1.Content = result;
                            Text2.Content = result + " + ";
                            First = false;
                        }
                        else if (Select == "-")
                        {
                            result += Num - NumTwo;
                            Text1.Content = result;
                            Text1.Content = result + " - ";
                            First = false;

                        }
                        else if (Select == "*")
                        {
                            result += Num * NumTwo;
                            Text1.Content = result;
                            Text2.Content = result + " * ";
                            First = false;

                        }
                        else if (Select == "÷")
                        {
                            result += Num / NumTwo;
                            Text1.Content = result;
                            Text2.Content = result + " ÷ ";
                            First = false;

                        }
                    }
                }
                else if (btn.Name == "Sil")
                {

                    string size = "";
                    string selection = "";
                    string newNumber = "";

                    size = Text1.Content.ToString();

                    if (Text1.Content != "0")
                    {
                        if (size.Length == 1)
                        {
                            Text1.Content = "0";
                            First = false;
                        }
                        else
                        {
                            selection = Text1.Content.ToString();
                            size = Text1.Content.ToString();
                            for (int i = 0; i < size.Length - 1; i++)
                            {
                                newNumber += selection[i];
                            }

                            if (NumTwoTrue == false) Num = double.Parse(newNumber);
                            else NumTwo = double.Parse(newNumber);

                            Text1.Content = newNumber;
                        }
                    }
                }
                else if ( btn.Name == "Yari")
                {
                    Text1.Content += ",";
                }

                else if (btn.Name == "Clear")
                {
                    Text1.Content = "0";
                }
                else if (btn.Name == "AllClear")
                {
                    Text1.Content = "0";
                    Text2.Content = "";
                    First = false;
                    NumTwoTrue = false;
                    Num = 0;
                    NumTwo = 0;
                }
            }
        }

    }
}
