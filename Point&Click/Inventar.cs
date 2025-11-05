using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Click
{ 
  
    internal class Inventar
    {
        //Her er følgende fields på klassen Item.
        private List<Item> inventoryList = new List<Item>();
        private Item itemInUse = new Item();

        // Metode så man kan tilføje Item til ens Inventar
        public void AddItem(Item item)
        {
            inventoryList.Add(item);
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

        //Så man kan tilgå InventoryList i andre klasser.
        public List<Item> GetInventoryList()
        {
            return inventoryList;
        }

        //Så man kan tilgå Item,hvor boolen inUse er true.
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
    }
}
