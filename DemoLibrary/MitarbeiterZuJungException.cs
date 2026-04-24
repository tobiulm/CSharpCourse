using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Wird ausgelöst wenn ein Mitarbeiter das alter von 16 Jahren unterschreitet
    /// </summary>
    public class MitarbeiterZuJungException : Exception
    {
        /// <summary>
        /// Standardkonstruktor setzt die Meldung auf ein Mindestalter von 16 Jahren
        /// </summary>
        public MitarbeiterZuJungException(): base("Der Mitarbeiter muss mindestens 16 Jahre alt sein.")
        {
            
        }
    }
}