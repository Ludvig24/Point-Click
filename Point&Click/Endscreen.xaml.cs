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
        User user;
        MainWindow mainwindow = new MainWindow();
        Room room1;
        Room room2;
        Room room3;
        List<Item> AllItems;

        public Endscreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Show();
            this.Close();
            
        }
    }
}
