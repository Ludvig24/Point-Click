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
        bool cakeActive = false;

        internal Room2Window(User user, Room room1, Room room2, Room room3, List<Item> AllItems)
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
            user.GetInventar().AddItem(room2.ClickItem(ladderID));
            InvListBox.Items.Add(Ladder.Content);
        }

        private void Kage_Click(object sender, RoutedEventArgs e) //Når man clicker på kagen og går tilbage til rum 1, så driller den
        {
            if (cakeActive == false)
            {
                return;
            }
            int keycardID = 3;
            InvListBox.Items.Add("Keycard");
            //Det er et keycard man får ud af kagen
            // .Visibility = Visibility.Hidden; //Her kan vi ændre udsynet på kage
            user.GetInventar().AddItem(room2.ClickItem(keycardID));
            Kage.IsEnabled = false;
        }

        private void Shelf_Click(object sender, RoutedEventArgs e)
        { 
            if (InvListBox.SelectedItem== null)
            {
                return;
            }
            if (InvListBox.SelectedItem.ToString() != "Ladder")
            {
                return;
            }
            Ladder2.Visibility = Visibility.Visible;
            
            //Har tilføjet det samme som da vi skulle igennem døren i rum 1, bare uden move
            Inventar inv;
            inv = user.GetInventar();
            inv.ChooseItem(2);


            //if statement der tjekker om det item i inventaret hvor boolen inUse er true og tjekker om det item er en ladder
            if (inv.GetItemInUse() == AllItems[1]) 
            {

                inv.DeleteItem(2); // Kalder deleteItem() og sender 2 med som parameter
                user.SetInventar(inv); //Tildeler inv objektet til user objektets instans af Inventar med SetInventar() metoden
                InvListBox.Items.RemoveAt(InvListBox.Items.IndexOf(InvListBox.SelectedItem));

                cakeActive = true; // og her gør vi at kagen er true, så vi kan bruge det senere
            }
        }

        private void ExitDoor_Click(object sender, RoutedEventArgs e)
        {
            if (InvListBox.SelectedItem == null)
            {
                return;
            }
            if (InvListBox.SelectedItem.ToString() != "Keycard") //findes Keycard?
            {
                return;
            }
           

            Inventar inv;
            inv = user.GetInventar();

            inv.ChooseItem(3);
            
            //if statement der tjekker om det item i inventaret hvor boolen inUse er true og tjekker om det item er et keycard
            if (inv.GetItemInUse() == AllItems[2]) 
            {
                inv.DeleteItem(3); 
                user.SetInventar(inv); 
                user.Move(room3.GetRoomID(), user, room1, room2, room3, AllItems);

                this.Visibility = Visibility.Hidden; 

            }

        }
    }
}
