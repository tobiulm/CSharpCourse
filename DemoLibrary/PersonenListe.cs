using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Listenklasse die nur Datentypen basierend auf der Klasse Mensch erlaubt
    /// </summary>
    /// <typeparam name="T">Typen basierend auf Mensch</typeparam>
    public class PersonenListe<T> : List<T> where T : Mensch
    {
    }
}