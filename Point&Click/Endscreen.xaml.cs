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

namespace Point_Click
{
    /// <summary>
    /// Interaction logic for Endscreen.xaml
    /// </summary>
    public partial class Endscreen : Window
    {
        //Vores laver en instans af MainWindow.
        MainWindow mainwindow = new MainWindow();
     
        public Endscreen()
        {
            InitializeComponent();
        }

        //Vores klik knap, som lukker Windowet 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Vores return knap, som sender os tilbage til MainWindow.
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Show();
            this.Close();
            
        }
    }
}
