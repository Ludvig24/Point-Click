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

            //Kalder CreateItem() på room1 og room2. Tildeler hvert room et ID
            room1.CreateItem(1, "Key");
            room1.SetRoomID(1);

            room2.CreateItem(1, "Key");
            room2.CreateItem(2, "Ladder");
            room2.CreateItem(3, "Keycard");
            room2.SetRoomID(2);

            room3.SetRoomID(3);

            //Tildeler AllItems alle items i room2
            AllItems = room2.GetItemList();

            //Tildeler User et inventar
            user.SetInventar(inventar);
        }

        //Opretter en public metode af typen Room vi kalder GetRoom() som tager en integer som parameter
        internal Room GetRoom(int id) 
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

        //Opretter en public metode GetItems(). Metoden returnerer en liste af Item objekter
        internal List<Item> GetItems()
        {
            return AllItems; //metoden returnerer listen AllItems
        }

        //WPF click metode der kører når en bestemt button i WPF vinduet trykkes på
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //Metoden Move() kaldes på user objektet. der sendes understående som parameter. Vi får roomId ved at kalde metoden GetRoomID() på objektet room1
            user.Move(room1.GetRoomID(), user, room1, room2, room3, AllItems); 
            
            this.Visibility = Visibility.Hidden; //Vi sætter visibility for "this" som er WPF vinduet MainWindow til hidden hvilket lukker WPF vinduet
        }
    }
}