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
        private int itemID;
        private bool inUse = false;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void HoverItem()
        {

        }

        // Så man kan tilgå ItemID i andre klasser 
        public int GetItemID()
        {
            return itemID;
        }

        public void SetItemID(int itemID)
        {
            this.itemID = itemID;

        }

        // Så man kan tilgå inUse i andre klasse
        public bool GetinUse()
        {
            return inUse;
        }

        public void SetinUse(bool inUse)
        {
            this.inUse = inUse;
        }

    }
}