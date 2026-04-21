using NewElements.DemoLibrary;
namespace NewElements.CSharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anweisung über mehrere Zeilen verteilt, da Anweisungen mit Semikolon abgeschlossen werden
            //Console.WriteLine(
            //    "Hello, World!"
            //);


            // Verwendung von using ermöglicht eine Kurzschreibweise
            // NewElements.DemoLibrary.Class1.PrintTime();
            // Class1.PrintTime();

            // Verwendung von Variablen und Typkonvertierung
            // Class1.VariablenUndTypkonvertierung();

            // Verwendung von Variablen und Listen
            // Class1.ArraysUndListen();

            // Verwendung von Kontrollstrukturen wie if oder Schleifen
            Class1.Kontrollstrukturen();
        }
    }
}