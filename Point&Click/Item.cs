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
        //Her er følgende field på vores klasse Item.
        private string name;
        private int itemID;

        //Dette er et field, vi bruger til at skelne mellem, hvilket item som er i bruge.
        private bool inUse = false;

        // Så man kan tilgå name i de andre klasser.
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        // Så man kan tilgå ItemID i andre klasser.
        public int GetItemID()
        {
            return itemID;
        }

        public void SetItemID(int itemID)
        {
            this.itemID = itemID;

        }

        // Så man kan tilgå inUse i andre klasser.
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