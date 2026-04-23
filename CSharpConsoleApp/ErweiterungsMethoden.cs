using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewElements.DemoLibrary;

namespace NewElements.CSharpConsoleApp
{
    internal static class ErweiterungsMethoden
    {
        internal static string ZeigeMitarbeiterInfos(this Mitarbeiter m)
        {
            string ergebnis = $"Abteilung: {m.Abteilung}\t Gehalt: {m.Gehalt}";
            return ergebnis;
        }
    }
}