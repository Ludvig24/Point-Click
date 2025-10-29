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
        public MainWindow()
        {
            InitializeComponent();
            Item item1 = new Item();
            item1.SetName("Key");
            item1.SetItemID(1);
            Item item2 = new Item();
            item2.SetName("Ladder");
            item2.SetItemID(2);
            Item item3 = new Item();
            item3.SetName("Keycard");
            item3.SetItemID(3);
            List<Item> AllItems = new List<Item>();
            AllItems.Add(item1);
            AllItems.Add(item2);
            AllItems.Add(item3); 

            Room room1 = new Room();
            room1.SetRoomID(1);
            List<Item> room1ItemList = room1.GetItemList();
            room1ItemList.Add(AllItems[0]);
            


            Room room2 = new Room();
            room2.SetRoomID(1);
            List<Item> room2ItemList = room2.GetItemList();
            room2ItemList.Add(AllItems[0]);
            room2ItemList.Add(AllItems[1]);













        }
    }
}