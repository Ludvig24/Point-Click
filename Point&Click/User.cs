using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Point_Click
{
    public class User //var internal
    {
        private string name;
        private bool isDead;
        private Inventar inventar = new Inventar();


        public Inventar GetInventar()
        {
            return inventar;
        }

        public Inventar SetInventar()
        {
            return inventar;
        }

        
        public void Move(int roomID, User user, Room room1, Room room2, Room room3, List<Item> AllItems) //vi tager roomID som parameter til at bruge i switch - vi tager vores instans af MainWindow som vi sender med så vi kan bruge de objekter der er initialiseret i MainWindowet i vores andre vinduer
        {
            switch (roomID)
            {
                case 1:
                    //MainWindow mainW = (MainWindow)window; //vi konverterer her window objektet til et MainWindow objekt vha cast (MainWindow) vi konverterer eksplicit window objekt til MainWindow
                    Room1Window room1W = new Room1Window(user, room1, room2, room3, AllItems);
                    room1W.Show();
                    
                    
                    break;
                case 2:
                    //Room1Window room1W = (Room1Window)window;
                    Room2Window room2W = new Room2Window(user, room1, room2, room3, AllItems);
                    room2W.Show();
                    
                    break;
                case 3:
                   
                    
                    break;
            }
            //formålet er at returnere et roomID som vi kan bruge til at navigere mellem de rum vi har oprettet
        }

        public Window Menu()
        {
            return null; //skal returnerer et Menu Window
        }
    }
}
