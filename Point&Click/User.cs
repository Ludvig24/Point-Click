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
        private string name;
        private bool isDead;

        public int Move()
        {
            return 0; //formålet er at returnere et roomID som vi kan bruge til at navigere mellem de rum vi har oprettet
        }

        public Window Menu()
        {
            return null; //skal returnerer et Menu Window
        }
    }
}
