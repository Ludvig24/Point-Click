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
       // Vores objekter af nedenstående klasser.
        User user;
        Room room1;
        Room room2;
        Room room3;
        List<Item> AllItems;
        bool cakeActive = false;

        //Constructor for klassen.
        internal Room2Window(User user, Room room1, Room room2, Room room3, List<Item> AllItems)
        {
            InitializeComponent();

            //Tildeler parameterne i constructoren til variablerne user, room1, room2, room3 og AllItems.
            this.user = user;
            this.room1 = room1;
            this.room2 = room2;
            this.room3 = room3;
            this.AllItems = AllItems;
        }

        //Når vi klikker på døren, åbner vi et nyt vindue af room1 og lukker room2.
        private void GoToRoom1_Click(object sender, RoutedEventArgs e)
        {
            
            user.Move(room1.GetRoomID(), user, room1, room2, room3, AllItems);
            this.Visibility = Visibility.Hidden;
        }

        //Vores ladder knap, som tilføjer ladder til vores inventar.
        private void Ladder_Click(object sender, RoutedEventArgs e)
        {
            int ladderID = 2;
            Ladder.Visibility = Visibility.Hidden;
            user.GetInventar().AddItem(room2.ClickItem(ladderID));
            InvListBox.Items.Add(Ladder.Content);
            StigeTeksBox.Visibility = Visibility.Visible;
        }

        //Vores Kage knap, som ser om kage er aktiv, hvis true tilføjes et keycard til inventar.
        private void Kage_Click(object sender, RoutedEventArgs e)
        {
            if (cakeActive == false)
            {
                return;
            }

            int keycardID = 3;
            InvListBox.Items.Add("Keycard"); //Det er et keycard man får ud af kagen
           
            user.GetInventar().AddItem(room2.ClickItem(keycardID));
            Kage.IsEnabled = false;
            ExitBox.Background = Brushes.Green; //Boksen farves grøn.
            KeycardTextBox.Visibility = Visibility.Visible;
        }

        //Vores Shelf knap, som kontroller om vi har valgt en stige.
        private void Shelf_Click(object sender, RoutedEventArgs e)
        { 
            if (InvListBox.SelectedItem== null)
            {
                return;
            }
            if (InvListBox.SelectedItem.ToString() != "Stige")
            {
                return;
            }
            Ladder2.Visibility = Visibility.Visible;

            //Vi opretter en instans af inventar.
            Inventar inv;

            inv = user.GetInventar(); //Tildeler Inventar instansen det Inventar objekt i user objektet.

            //Vi kalder ChooseItem
            inv.ChooseItem(2);
            StigeTeksBox.Visibility = Visibility.Hidden;

            //If statement der tjekker om det item i inventaret. hvor boolen inUse er true og tjekker om det item er en ladder.
            if (inv.GetItemInUse() == AllItems[1]) 
            {

                inv.DeleteItem(2); // Kalder DeleteItem() og sender 2 med som parameter
                user.SetInventar(inv); //Tildeler inv objektet til user objektets instans af Inventar med SetInventar() metoden.
                InvListBox.Items.RemoveAt(InvListBox.Items.IndexOf(InvListBox.SelectedItem));

                cakeActive = true; // og her gør vi at kagen er true, så vi kan bruge det senere.
            }
        }

        //Vores Exit door knap, som gør meget af det samme som overstående. Ændringen er den kalder move og kontroller man har et Keycrd nu.
        private void ExitDoor_Click(object sender, RoutedEventArgs e)
        {
            if (InvListBox.SelectedItem == null)
            {
                return;
            }
            if (InvListBox.SelectedItem.ToString() != "Keycard")
            {
                return;
            }

            //Vi opretter en instans af inventar.
            Inventar inv;
            inv = user.GetInventar(); //Tildeler Inventar instansen det Inventar objekt i user objektet.

            //Vi kalder ChooseItem
            inv.ChooseItem(3);
            
            //if statement der tjekker om det item i inventaret hvor boolen inUse er true og tjekker om det item er et keycard
            if (inv.GetItemInUse() == AllItems[2]) 
            {
                inv.DeleteItem(3); // Kalder DeleteItem() og sender 3 med som parameter
                user.SetInventar(inv); 
                user.Move(room3.GetRoomID(), user, room1, room2, room3, AllItems); // Vi bevæger os til room3.

                this.Visibility = Visibility.Hidden; 

            }

        }

        //Vores TextBox exit boks farves rød.
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ExitBox.Background = Brushes.Red;
        }
    }
}
