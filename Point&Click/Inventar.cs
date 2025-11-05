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

    internal class Inventar
    {
        private List<Item> inventoryList = new List<Item>();
        private Item itemInUse = new Item();

        // Metode så man kan tilføje Item til ens Inventar
        public void AddItem(Item item)
        {
            inventoryList.Add(item);
        }

        public List<Item> GetInventoryList()
        {
            return inventoryList;
        }

        //Metode så man sletter Item fra ens Inventar
        public void DeleteItem(int itemID)
        {
            int i = 0;

            while (i < inventoryList.Count)
            {
                if (inventoryList[i].GetItemID()== itemID)
                {
                    inventoryList.Remove(inventoryList[i]);
                }

                i++;
            }
        }

        //Metode hvor man kan vælge et specifikt Item
        public void ChooseItem(int itemID)
        {
            int i = 0;

            while (i < inventoryList.Count)
            {
                if (inventoryList[i].GetItemID()== itemID)
                {
                    inventoryList[i].SetinUse(true);
                    //itemInUse = inventoryList[i];
                    //itemInUse.SetinUse(true);
                }
                i++;
            }
        }




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
