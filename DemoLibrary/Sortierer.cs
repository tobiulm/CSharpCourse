using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Kleine Hilfsklasse mit Sortierfunktionalität
    /// </summary>
    public class Sortierer
    {
        private static bool VergleicheAufsteigend(int zahl1, int zahl2)
        {
            bool ergebnis = false;
            if (zahl1 < zahl2)
            {
                ergebnis = true;
            }
            return ergebnis;
        }

        private static bool VergleicheAbsteigend(int zahl1, int zahl2)
        {
            bool ergebnis = false;
            if (zahl2 < zahl1)
            {
                ergebnis = true;
            }
            return ergebnis;
        }

        private delegate bool VergleichsFunktion(int zahl1, int zahl2);


        /// <summary>
        /// Einfache Implementierung des Bubble Sort Algorithmus
        /// </summary>
        /// <param name="zahlen">Die integer zahlen die zu sortieren sind</param>
        /// <param name="richtung">Die richutung der sortierung (Auf oder Ab)</param>
        public static void BubbleSort(int[] zahlen, SortierRichtung richtung)
        {
            int tempWert;

            VergleichsFunktion zeiger;
            if (richtung == SortierRichtung.Aufsteigend)
            {
                zeiger = new VergleichsFunktion(VergleicheAufsteigend);
            }
            else
            {
                zeiger = VergleicheAbsteigend;
            }


            for (int i = 0; i <= zahlen.GetUpperBound(0); i++)
            {
                tempWert = zahlen[i];
                for (int j = i + 1; j <= zahlen.GetUpperBound(0); j++)
                {
                    if (zeiger(zahlen[j], tempWert))
                    {
                        zahlen[i] = zahlen[j];
                        zahlen[j] = tempWert;
                        tempWert = zahlen[i];
                    }
                    //if (richtung == SortierRichtung.Aufsteigend)
                    //{
                    //    if (VergleicheAufsteigend(zahlen[j], tempWert))
                    //    {
                    //        zahlen[i] = zahlen[j];
                    //        zahlen[j] = tempWert;
                    //        tempWert = zahlen[i];
                    //    }
                    //}
                    //else
                    //{
                    //    if (VergleicheAbsteigend(zahlen[j], tempWert))
                    //    {
                    //        zahlen[i] = zahlen[j];
                    //        zahlen[j] = tempWert;
                    //        tempWert = zahlen[i];
                    //    }
                    //}
                }
            }
        }
    }
}
