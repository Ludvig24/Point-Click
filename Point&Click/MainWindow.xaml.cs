using System.Security.Cryptography.X509Certificates;
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

namespace Point_Click 
{
    // Vi har kodet dette spil sammen, ved vise det på storskærm og snakke om det.
    // Hvilket betyder, at trods der står eks Tobias commit, så er det lavet i samarbejde

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Opretter 3 objekter af klassen Item // Måske skriv note om nedarvninger
        Item item1 = new Item();  
        Item item2 = new Item();
        Item item3 = new Item();

        //Opretter 3 objekter af klassen Room
        Room room1 = new Room();
        Room room2 = new Room();
        Room room3 = new Room();
        
        //Opretter en liste af typen Item
        List<Item> AllItems = new List<Item>();

        //Opretter et objekt af klassen User
        User user = new User();

        //Opretter et objekt af klassen Inventer
        Inventar inventar = new Inventar();
       
        public MainWindow() 
        {
            InitializeComponent();

            //Tildeler det første Item objekt et navn og et Id
            item1.SetName("Key"); //Kalder SetName() metoden på item1 og sender parameteren "Key" med
            item1.SetItemID(1); //Kalder metoden SetItemID() på item1 og sender parameteren 1 med
            
            
            //Tildeler item2 objektet et navn og et Id
            item2.SetName("Ladder"); //Kalder SetName() metoden på item2 og sender parameteren "Ladder" med
            item2.SetItemID(2); //Kalder SetItemID() metoden på item2 og sender parameteren 2 med
            
            //Tildeler item3 objektet et navn og et Id
            item3.SetName("Keycard"); //Kalder SetName() metoden på item3 og sender parameteren "KeyCard" med
            item3.SetItemID(3); //Kalder SetItemID() metoden på item3 og sender parameteren 3 med
            
            //kalder Add() på AllItems listen på de 3 objekter af Item klassen
            AllItems.Add(item1);
            AllItems.Add(item2);
            AllItems.Add(item3);

            //Tildeler User et inventar
            user.SetInventar(inventar);


            room1.SetRoomID(1); //Kalder SetRoomID() metoden på room1 objektet og sender parameteren 1 med
            List<Item> room1ItemList = room1.GetItemList(); //Opretter en liste af typen Item. Vi kalder metoden GetItemList på room1 objektet. Vi tildeler listen room1ItemList den liste der returneres af GetItemList() metoden.
            room1ItemList.Add(AllItems[0]); //Kalder add metoden på listen room1ItemList. Det item objekt i listen AllItems på index 0 tilføjes til listen room1ItemList



            
            room2.SetRoomID(2); //Kalder SetRoomID() metoden på room2 objektet og sender parameteren 2 med
            List<Item> room2ItemList = room2.GetItemList(); //Opretter en liste af typen Item. Vi kalder metoden GetItemList på room2 objektet. Vi tildeler listen room2ItemList den liste der returneres af GetItemList() metoden.
            room2ItemList.Add(AllItems[0]); //Kalder add metoden på listen room2ItemList. Det item objekt i listen AllItems på index 0 tilføjes til listen room2ItemList
            room2ItemList.Add(AllItems[1]); //Kalder add metoden på listen room2ItemList. Det item objekt i listen AllItems på index 1 tilføjes til listen room2ItemList
            room2ItemList.Add(AllItems[2]);


            room3.SetRoomID(3); //Kalder SetRoomID() metoden på room3 objektet og sender parameteren 3 med
            List<Item> room3ItemList = room3.GetItemList(); //Opretter en liste af typen Item. Vi kalder metoden GetItemList på room3 objektet. Vi tildeler listen room3ItemList den liste der returneres af GetItemList() metoden.
            room3ItemList.Add(AllItems[0]); //Kalder add metoden på listen room3ItemList. Det item objekt i listen AllItems på index 0 tilføjes til listen room3ItemList
            room3ItemList.Add(AllItems[1]); //Kalder add metoden på listen room3ItemList. Det item objekt i listen AllItems på index 1 tilføjes til listen room3ItemList
            room3ItemList.Add(AllItems[2]); //Kalder add metoden på listen room3ItemList. Det item objekt i listen AllItems på index 2 tilføjes til listen room3ItemList

        }
        
        public Room GetRoom(int id) //opretter en public metode af typen Room vi kalder GetRoom() som tager en integer som parameter
        {
            switch (id) //der køres et switch case statement på id variablet
            {
                case 1: //hvis id er lig 1
                    return room1; // returnerer room1 objektet
                case 2: //hvis id er lig 2
                    return room2; //returnerer room2 objektet
                case 3: //hvis id er lig 3
                    return room3; //returnerer room3 objektet
                default: //hvis id ikke opfylder nogen af de forrige cases kører default
                    return null; //der returneres null
            }
            
        }

        public List<Item> GetItems() //opretter en public metode GetItems(). Metoden returnerer en liste af Item objekter
        {
            return AllItems; //metoden returnerer listen AllItems
        }

      

        private void Start_Click(object sender, RoutedEventArgs e) //WPF click metode der kører når en bestemt button i WPF vinduet trykkes på
        {
            
            user.Move(room1.GetRoomID(), user, room1, room2, room3, AllItems); //metoden Move() kaldes på user objektet. der sendes et roomId, User objekt, 3 Room objekter og en liste af Items med som parameter. Vi får roomId ved at kalde metoden GetRoomID() på objektet room1
            
            this.Visibility = Visibility.Hidden; //Vi sætter visibility for "this" som er WPF vinduet MainWindow til hidden hvilket lukker WPF vinduet
        }
    }
}