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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Item item1 = new Item();
        Item item2 = new Item();
        Item item3 = new Item();

        Room room1 = new Room();
        Room room2 = new Room();
        Room room3 = new Room();
        List<Item> AllItems = new List<Item>();

        User user = new User();
        public MainWindow()
        {
            InitializeComponent();
            
            item1.SetName("Key");
            item1.SetItemID(1);
            
            item2.SetName("Ladder");
            item2.SetItemID(2);
            
            item3.SetName("Keycard");
            item3.SetItemID(3);
            
            AllItems.Add(item1);
            AllItems.Add(item2);
            AllItems.Add(item3);



            //Room room1 = new Room();
            room1.SetRoomID(1);
            List<Item> room1ItemList = room1.GetItemList();
            room1ItemList.Add(AllItems[0]);



            
            room2.SetRoomID(2);
            List<Item> room2ItemList = room2.GetItemList();
            room2ItemList.Add(AllItems[0]);
            room2ItemList.Add(AllItems[1]);


            
            room3.SetRoomID(3);
            List<Item> room3ItemList = room3.GetItemList();
            room3ItemList.Add(AllItems[0]);
            room3ItemList.Add(AllItems[1]);
            room3ItemList.Add(AllItems[2]);











        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            
            user.Move(room1.GetRoomID());
            this.Visibility = Visibility.Hidden;
        }
    }
}