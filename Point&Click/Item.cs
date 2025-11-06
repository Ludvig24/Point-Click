using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Point_Click
{

    /// <Argumenter_for_ingen_nedarvning>
    /// Argument for ingen nedarvning  
    ///Man kan argumenter for at man kunne have valgt at gøre Item til en super klasse,
    ///så Key, Ladder og Keycard kunne nedarve attributter og metoder fra Item.
    ///Vi talte om nedarvning i starten af vores proces,
    ///særlig i forhold til Klassen Fjende, som vi har valgt ikke at medtage i spillet.
    ///Men efter en snak med Niels, som synes det kunne være fint at vise vi kunne nedarvning,
    ///gik vi tilbage og prøvede at indtænke det i vores spil.
    ///Vi prøvede at implementere nedarvning i dette program vi allerede have skrevet,
    ///men blev ved med at løbe ind i problemer,
    ///siden det gav en del omskrivning og var knap så lige til.
    ///Så i stedet for at lave et meget søgt og ikke indtænkt eksempel, bliv vi enig om,
    ///at det simpelthen ikke gav mening at implementere,
    ///nedarvning så sent i processen.Yderlige havde Key,
    ///Ladder og Keycard ikke noget unikt, hvilket ligeledes også argumenter for,
    ///hvorfor nedarvning ikke giver mening at indtænke i dette program. 
    /// Hvis nu vi have haft fjender eller objekter i vejen med,
    /// vil nedarvning have være en del at processen,
    /// for eks.har en fjende unikke attributter og nok metoder.
    /// Så det der ville ske, vil være fjenden arve fra Item Enemy : Item.
    /// Så vil man i fjende kunne gøre brug af metoderne og attributterne fra Item,
    /// som name og have sig egne unikke som metoden Attrack(). 
    /// </summary>
    internal class Item
    {
        //Her er følgende field på vores klasse Item.
        private string? name;
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