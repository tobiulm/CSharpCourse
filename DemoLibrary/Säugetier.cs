using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Abstrakte Basisklasse für unsere Umgebung
    /// </summary>
    public abstract class Säugetier
    {
        /// <summary>
        /// Speichert wieviele Säugetiere in unserer Anwendung existieren
        /// </summary>
        public static long Anzahl_Säugetiere;

        private bool _istEinRaubtier = false;

        /// <summary>
        /// Liest oder setzt ob ein Säugetier ein Raubtier ist
        /// </summary>
        public bool IstEinRaubtier
        {
            get
            {
                return _istEinRaubtier;
            }
            set
            {
                _istEinRaubtier = value;
            }
        }

        /// <summary>
        /// Unser Standardkonstruktor bei dem angegeben werden muss ob ein Säugetier ein Raubtier ist oder nicht
        /// </summary>
        /// <param name="raubTier">Ist das Säugetier ein Raubtier?</param>
        public Säugetier(bool raubTier)
        {
            _istEinRaubtier = raubTier;
            Anzahl_Säugetiere++;
        }

        /// <summary>
        /// Diese Methode zeigt auf das in einer abstrakten Basisklasse Methoden die als abstract Definiert wurden genutzt werden können
        /// </summary>
        public void Kommuniziere()
        {
            Console.WriteLine(StellDichVor());
        }

        /// <summary>
        /// Diese Methode soll zeigen das abstrakte Klassen Kindern vorgeben können bestimmte Logiken ausprogrammieren zu müssen
        /// </summary>
        /// <returns>Gibt einen Begrüßungsstring zurück</returns>
        public abstract string StellDichVor();

    }
}
