using System;
using System.Collections.Generic;
using System.ComponentModel;
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
       
        private MainWindow mainWindow; //opretter objekt af MainWindow
        //opretter objekter af User klassen, Room klassen og en Liste af Item objekter
        User user;
        Room room1;
        Room room2;
        Room room3;
        List<Item> AllItems;

        //Constructor for klassen


        public Room1Window(User user, Room room1, Room room2, Room room3, List<Item> AllItems)
        {
            InitializeComponent();
            //Tildeler parameterne i constructoren til variablerne user, room1, room2, room3 og AllItems
            this.user = user;
            this.room1 = room1;
            this.room2 = room2;
            this.room3 = room3;
            this.AllItems = AllItems;
            
            

        }

       

        // Metoden GetRoom - tager en integer id som parameter og returnerer et objekt af klassen room
        public Room GetRoom(int id)
        {
            // Switch case der kører på id variablen - hver case svarer til et bestemt room id
            // Hver case returnerer det room objekt hvis id svarer til variablen id
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

        //Metoden GetItems returnerer listen AllItems
        public List<Item> GetItems()
        {
            return AllItems;
        }


        //WPF click metode der kører når en bestemt button i WPF vinduet trykkes på
        private void GoToRoom2_Click(object sender, RoutedEventArgs e)
        {
            if (InvListBox.SelectedItem == null) //Vi skulle lave denne if sætning, fordi hvis ikke der er noget item i listen som den kan lave om til string, så brokker den sig
            { 
                return;//Her skal vi lave en kommentar om at døren er låst
            }
                     //Opretter instanser af klasserne Inventar og Item
                if ( InvListBox.SelectedItem.ToString() != "Nøgle")
            { 
                return;
            }
                //Vi har lavet if sætninger, der ser om vi har selected vores item, hvis vi har, så virker "døren"
            Inventar inv;           
            inv = user.GetInventar(); //Tildeler Inventar instansen det Inventar objekt i user objektet
           
            
            inv.chooseItem(1);
                               


            if (inv.GetItemInUse() == null)//tjekker om der findes en item i ivn som er inUse - hvis ikke så returner vi ingenting for at hoppe ud af metoden 
            {
                return;

            }

            //If statement der checker om et Item objekt i Inventar objektet (inv) er inUse og om det bestemte Item objekts id er lig med 1 
            if (inv.GetItemInUse().GetinUse() == true && inv.GetItemInUse().GetItemID() == 1) //GetInUse() returnerer om inUse variablen er true eller false. GetItemInUse() returner det Item objekt hvor boolen inUse er true.
            {
                inv.deleteItem(1); // Kalder deleteItem() og sender 1 med som parameter
                user.SetInventar(inv); //Tildeler inv objektet til user objektets instans af Inventar med SetInventar() metoden
                user.Move(room2.GetRoomID(), user, room1, room2, room3, AllItems); //metoden Move() kaldes på user objektet. der sendes et roomId, User objekt, 3 Room objekter og en liste af Items med som parameter. Vi får roomId ved at kalde metoden GetRoomID() på objektet room2

                this.Visibility = Visibility.Hidden; //skjuler vinduet Room1Window ved at sætte Visibility til Hidden

            } //hvis false så skriv et hint/besked om at døren er låst
            
        }

        //WPF click metode der kører når en bestemt button i WPF vinduet trykkes på
        private void Nøgle_Click(object sender, RoutedEventArgs e)
        {
            int nøgleID = 1; //opretter en int nøgleID og tildeler den 1
            //Får fat i user objektets Inventar objektet og tildeler den item der blev clicket på (nøglen) til inventaret
            user.GetInventar().addItem(room1.ClickItem(nøgleID)); //kalder GetInventar() metoden på user objektet for at få det aktuelle inventar i useren. ClickItem kaldes på room1 objektet og nøgleID sendes som parameter - dette returnerer Item objektet der blev klikket på. addItem() metoden kaldes på Item objektet.
            Nøgle.Visibility = Visibility.Hidden; // Sætter visibility for nøgle objektet i WPF vinduet til hidden

            InvListBox.Items.Add(Nøgle.Content);

        }

       

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
