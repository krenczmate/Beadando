using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamlaBeadando_KrenczMate
{
    class Szamla
    {
        /// <summary>
        /// Számla egyenleget tároló változó
        /// </summary>
        ///<value>
        /// Int változó
        /// </value>
        public int Egyenleg { get; set; }
        /// <summary>
        /// Tulajdonos nevét tároló változó
        /// </summary>
        /// <value>
        /// String változó
        /// </value>
        public string Tulajdonos { get; set; } = "";

        /// <summary>
        /// A számlához tartozó konstruktor ami megkapja az egyenleget és a számla tulajdonosának a nevét, amit be is álít a számlának
        /// </summary>
        /// <param name=" _Egyenleg">A számla egyenlege</param>
        /// <param name="_Tulajdonos">A számla tulajdonosának neve</param>
        public Szamla(int _Egyenleg, string _Tulajdonos)
        {
            Egyenleg = _Egyenleg;
            Tulajdonos = _Tulajdonos;
        }

        /// <summary>
        /// A számláról való pénz felvételt végző metódus
        /// </summary>
        /// <param name="osszeg">Az összeg amit ki szeretnénk venni</param>
        /// <remarks>
        /// Ez a metódus először megvizsgálja a számlához tartozó beviteli mező tartalmát, ha nem szám vagy negatív, akkor hibaüzenetet ad.
        /// Ha szám, akkor először megvizsgálja, hogy van-e ennyi pénz a számlán és ha igen akkor levonja. Ha nincs akkor hibaüzenet ablakot nyit meg.
        /// </remarks>
        public void Kivet(string osszeg)
        {
            int ossz;
            bool siker = Int32.TryParse(osszeg, out ossz);
            if(siker && ossz>0)
            {
                if (Egyenleg-ossz>0)
                {
                    Egyenleg -= ossz;
                }
                else
                {
                    Hiba hiba = new Hiba("Ennyi pénz nincs a számláján!");
                    hiba.Show();
                }
            }
            else
            {
                Hiba hiba = new Hiba("Hibás bemenet!");
                hiba.Show();
            }

        }

        /// <summary>
        /// A számlára való pénz feltöltést végző metódus
        /// </summary>
        /// <param name="osszeg">Az összeg amit fel szeretnénk tenni a számlára</param>
        /// <remarks>
        /// Ez a metódus először megvizsgálja a számlához tartozó beviteli mezőben megadott értéket. Ha ez az érték nem szám vagy negatív, akkor
        /// hibaüzenetes ablakot nyit meg. Ha pozitív számot adott meg a felhasználó, akkor annyival növeli az egyenleget.
        /// </remarks>
        public void Feltolt(string osszeg)
        {
            int ossz;
            bool siker = Int32.TryParse(osszeg, out ossz);
            if (siker && ossz > 0)
            {
                Egyenleg =Egyenleg +ossz;
            }
            else
            {
                Hiba hiba = new Hiba("Hibás bemenet!");
                hiba.Show();
            }
        }

        /// <summary>
        /// Ez a metódus végzi az utalást az "aktuális" számláról az értékként kapott másik számlára
        /// </summary>
        /// <param name="osszeg">Az összeg amit utalni szeretnénk</param>
        /// <param name="szamla">Az a számla amire utalunk</param>
        /// <remarks>
        /// Ez a metódus először megvizsgálja a beviteli mezőt, ha pozitív számot tartalmaz, akkor vizsgálja meg, hogy van-e annyi pénz
        /// a számlán és ha igen, akkor a paraméterként kapott számlára feltölti, míg a jelenlegi számláról leveszi a pénzt. Minden hiba esetén
        /// megnyílik egy hiba ablak, különböző üzenettel
        /// </remarks>
        public void Utalas(string osszeg, Szamla szamla)
        {
            int ossz;
            bool siker = Int32.TryParse(osszeg, out ossz);
            if (siker && ossz > 0)
            {
                if (Egyenleg - ossz > 0)
                {
                    Egyenleg -= ossz;
                    szamla.Egyenleg += ossz;
                }
                else
                {
                    Hiba hiba = new Hiba("Ennyi pénz nincs a számláján!");
                    hiba.Show();
                }
            }
            else
            {
                Hiba hiba = new Hiba("Hibás bemenet!");
                hiba.Show();
            }
        }
    }
}
