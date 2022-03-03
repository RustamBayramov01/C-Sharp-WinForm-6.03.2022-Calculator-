using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AcilisEkrani.xaml
    /// </summary>
    public partial class AcilisEkrani : Window
    {

        int incerement = 0;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public AcilisEkrani()
        {
            InitializeComponent();

        }


        private void Window_Activated(object sender, EventArgs e)
        {

           dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
           dispatcherTimer.Tick += Gecis;
           dispatcherTimer.Start();

        }

        private void Gecis(object sender, EventArgs e)
        {

            incerement++;

            Random random = new Random();

            border1.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
            border2.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255 - 100), (byte)random.Next(0, 255 - 100), (byte)random.Next(0, 255 - 100)));
            border3.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255 - 150), (byte)random.Next(0, 255 - 150), (byte)random.Next(0, 255 - 150)));
            border4.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255 - 200), (byte)random.Next(0, 255 - 200), (byte)random.Next(0, 255 - 200)));


            if (incerement == 4)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
            }

        }

    }
}
