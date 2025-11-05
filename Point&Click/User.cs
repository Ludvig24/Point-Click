using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Point_Click
{
    internal class User 
    {
        //Her er vores fields for vores klasse User
        //Fields name og isDead benyttes ikke i spiller, men vi har valgt at lade dem blive, da vi oprindeligt vil benytte dem
        //Eks, vil vi have brugt isDead, til at have fjener og at man kunne dø.
        private string name;
        private bool isDead;

        //Denne field bruges i spillet.
        private Inventar inventar = new Inventar();

        //Metode Move, går så brugeren kan bevæges sig mellem de forskellige rum.
        //Vi tager roomID, user, rooms og liste som parameter.
        public void Move(int roomID, User user, Room room1, Room room2, Room room3, List<Item> AllItems) 
        {
            //Formålet med switchen er at finde frem til det rum vi gerne vil flytte til via roomID.
            switch (roomID)
            {
                case 1:
                    //Vi laver et objekt af vores room1Window har understående parameter.
                    Room1Window room1W = new Room1Window(user, room1, room2, room3, AllItems);
                    //Her vises rummet
                    room1W.Show();
                    
                    break;

                case 2:
                    Room2Window room2W = new Room2Window(user, room1, room2, room3, AllItems);
                    room2W.Show();
                    
                    break;

                case 3:
                    Endscreen Endscreen = new Endscreen();
                    Endscreen.Show();
                    
                    break;

                case 4:
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();

                    break;
            }
            
        }

        //Her laver vi Get og Set, så vi kan anvende inventar i de andre klasser.
        public Inventar GetInventar()
        {
            return inventar;
        }
  
        public void SetInventar(Inventar inventar)
        {
            this.inventar = inventar;
        }
    }
}
