using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Click
{ 
    // Vi har ændet klassen til public, fordi vores construtor i Window filen skabte accesebility problemer
    // Vi er godt klar over at lave klassen til public nok ikke er det bedste vælg
    // Men det løste et problem vi blev ved med at sidde fast i

    public class Inventar
    {
        private List<Item> inventoryList = new List<Item>();
        private Item itemInUse = new Item();

        // Metode så man kan tilføje Item til ens Inventar
        public void addItem(Item item)
        {
            inventoryList.Add(item);
        }

        public List<Item> GetInventoryList()
        {
            return inventoryList;
        }

        //Metode så man sletter Item fra ens Inventar
        public void deleteItem(int ItemID)
        {
            int i = 0;

            while (i < inventoryList.Count)
            {
                if (inventoryList[i].GetItemID()== ItemID)
                {
                    inventoryList.Remove(inventoryList[i]);
                }

                i++;
            }
        }

        //Metode hvor man kan vælge et specifikt Item
        public void chooseItem(int ItemID)
        {
            int i = 0;

            while (i < inventoryList.Count)
            {
                if (inventoryList[i].GetItemID()== ItemID)
                {
                    inventoryList[i].SetinUse(true);
                    //itemInUse = inventoryList[i];
                    //itemInUse.SetinUse(true);
                }
                i++;
            }
        }


        /*public Item GetItemInUse() 
        {
            return itemInUse;
        }*/

        public Item GetItemInUse() 
        {
            int i = 0;
          while(i < inventoryList.Count)
            {
                if (inventoryList[i].GetinUse() == true) 
                {
                 return inventoryList[i];
                }
                i++;
            }
          
          return null;

        }


        /// <Note>
        /// Indtilvidere så når vi går ind i et nyt rum, så er inventorien tømt, så vi ikke skal implimentere at man gemmer items fra rum til rum
        /// og hvert lokale ikke behøver at blive resettet
        /// det vælger vi ud fra om det bliver et langt spil så der er brug for funktionen

       
       
        

    }
}
