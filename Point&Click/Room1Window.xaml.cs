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
    /// Interaction logic for Room1Window.xaml
    /// </summary>
    /// 

    
    public partial class Room1Window : Window
    {
        private MainWindow mainWindow;
        User user;
        Room room1;
        Room room2;
        Room room3;
        List<Item> AllItems;

        public Room1Window(User user, Room room1, Room room2, Room room3, List<Item> AllItems)
        {
            InitializeComponent();
            this.user = user;
            this.room1 = room1;
            this.room2 = room2;
            this.room3 = room3;
            this.AllItems = AllItems;

        }

        public Room GetRoom(int id)
        {
            switch (id)
            {
                case 1:
                    return room1;
                case 2:
                    return room2;
                case 3:
                    return room3;
                default:
                    return null;
            }

        }

        public List<Item> GetItems()
        {
            return AllItems;
        }

        /*public Room1Window(Window main)
        {
        }*/

        private void GoToRoom2_Click(object sender, RoutedEventArgs e)
        {


            user.Move(room2.GetRoomID(), user, room1, room2, room3, AllItems);
           
            this.Visibility = Visibility.Hidden;
        }

        private void Nøgle_Click(object sender, RoutedEventArgs e)
        {
            int nøgleID = 1;
            room1.ClickItem(nøgleID);
            Nøgle.Visibility = Visibility.Hidden;
        }
    }
}
