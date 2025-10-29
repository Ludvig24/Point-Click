using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Point_Click
{
    internal class Item
    {
        private string name;
        private int ItemID;
        

        
        
        


        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name; 
        }

        public int GetItemID()
        {
            return ItemID;
        }

        public void SetItemID(int ItemID)
        {
            this.ItemID = ItemID;
        }


        public void HoverItem()
        {

        }
    }
}
