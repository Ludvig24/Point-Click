using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Click
{
    internal class Room
    {
        //Dette er følgende fields på klassen Room.
        private int roomID;
        private List<Item> itemList = new List<Item>(); //liste over items i bestemt rum

        //Metoden CreateItem, hvor vi oprette et Item objekt og tildeler det et navn og ID og tilføjer det til ItemList.
        public void CreateItem(int id, string name)
        {
            Item item = new Item();
            item.SetItemID(id);
            item.SetName(name);
         
            itemList.Add(item);

        }

        //Click item går igennem en itemlist, og så retunere den det item hvis ID = itemID
        public Item ClickItem(int itemID)
        {
            int i = 0;
            while (i < itemList.Count)
            {
                if (itemID == itemList[i].GetItemID())
                {
                    
                    return itemList[i];
                }

                i++;
                
            }
            return null;
                
        }

        // Så man kan tilgå RoomID i andre klasser.
        public int GetRoomID()
        {
            return roomID;
        }

        public void SetRoomID(int id)
        {
            roomID = id;
        }

        // Så man kan tilgå ItemList i andre klasser.
        public List<Item> GetItemList()
        {
            return itemList;
        }
    }

}
