using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Click
{
    public class Room
    {
        private int roomID;
        private List<Item> itemList = new List<Item>(); //liste over items i bestemt rum


        public int GetRoomID()
        {
            return roomID;
        }

        public void SetRoomID(int id)
        {
            roomID = id;
        }

        public List<Item> GetItemList()
        {
            return itemList;
        }

        public string Hint()
        {
            return "";
        }

        public void CreateItem(int id, string name)
        {
            Item item = new Item();
            item.SetItemID(id);
            item.SetName(name);
            
            itemList.Add(item);

        }

        

        public void ClickItem()
        {

        }
    }
}
