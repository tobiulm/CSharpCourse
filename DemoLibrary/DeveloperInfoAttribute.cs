using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Repräsentiert Informationen eines Entwicklers.
    /// Kann auf Code angewendet werden um anzuzeigen wer diesen erstellt hat.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfoAttribute : Attribute
    {

        /// <summary>
        /// Liest oder setzt den Namen des Entwicklers
        /// </summary>
        public string DeveloperName { get; set; }
        /// <summary>
        /// Liest oder setzt die E-Mail Adresse des Entwicklers
        /// </summary>
        public string DeveloperEmail { get; set; }

        /// <summary>
        /// Für aussagekräftige Daten muss der Name und die E-Mail Adresse des Entwicklers angegeben werden
        /// </summary>
        /// <param name="name">Der Name des Entwicklers</param>
        /// <param name="email">Die E-Mail Adresse des Entwicklers</param>
        public DeveloperInfoAttribute(string name, string email)
        {
            DeveloperName = name;
            DeveloperEmail = email;
        }
    }
}