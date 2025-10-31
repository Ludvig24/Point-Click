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
    /// Interaction logic for Room2Window.xaml
    /// </summary>
    public partial class Room2Window : Window
    {
       
        User user;
        Room room1;
        Room room2;
        Room room3;
        List<Item> AllItems;
        public Room2Window(User user, Room room1, Room room2, Room room3, List<Item> AllItems)
        {
            InitializeComponent();
            this.user = user;
            this.room1 = room1;
            this.room2 = room2;
            this.room3 = room3;
            this.AllItems = AllItems;
        }

        private void GoToRoom1_Click(object sender, RoutedEventArgs e)
        {
            
            user.Move(room1.GetRoomID(), user, room1, room2, room3, AllItems);
            this.Visibility = Visibility.Hidden;
        }


        private void Ladder_Click(object sender, RoutedEventArgs e)
        {
            int ladderID = 2;
            Ladder.Visibility = Visibility.Hidden;
            user.GetInventar().addItem(room2.ClickItem(ladderID));
        }

        private void Kage_Click(object sender, RoutedEventArgs e)
        {
            int keycardID = 3;
            //Det er et keycard man får ud af kagen
            // .Visibility = Visibility.Hidden; //Her kan vi ændre udsynet på kage
            user.GetInventar().addItem(room2.ClickItem(keycardID));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
