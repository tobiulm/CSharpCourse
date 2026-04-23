using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Repräsentiert die Parameter die beim Verarbeiten eines Mitarbeiter.AbteilungVerändert Ereignisses mitgegeben werden
    /// </summary>
    public class AbteilungVerändertEventArgs : EventArgs
    {
        /// <summary>
        /// Liest oder schreibt den Namen der alten Abteilung
        /// </summary>
        public string AlteAbteilung { get; set; }

        /// <summary>
        /// Liest oder schreibt den Namen der neuen Abteilung
        /// </summary>
        public string NeueAbteilung { get; set; }

        /// <summary>
        /// Die AbteilungVerändertEventArgs benötigen die Namen der alten und neuen Abteilungen
        /// </summary>
        /// <param name="alteAbteilung">Name der alten Abteilung</param>
        /// <param name="neueAbteilung">Name der neuen Abteilung</param>
        public AbteilungVerändertEventArgs(string alteAbteilung, string neueAbteilung)
        {
            AlteAbteilung = alteAbteilung;
            NeueAbteilung = neueAbteilung;
        }
    }
}