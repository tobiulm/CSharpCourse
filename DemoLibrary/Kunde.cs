using NewElements.InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Diese Klasse repräsentiert einen Kunden in unserer Umgebung
    /// </summary>
    public class Kunde : Mensch, IKunde
    {
        /// <summary>
        /// Liest die Kundennummer aus
        /// </summary>
        public Guid KundenNummer => throw new NotImplementedException();

    }
}