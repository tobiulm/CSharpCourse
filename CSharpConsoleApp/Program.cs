using NewElements.DemoLibrary;
namespace NewElements.CSharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anweisung über mehrere Zeilen verteilt, da Anweisungen mit Semikolon abgeschlossen werden
            Console.WriteLine(
                "Hello, World!"
            );


            // Verwendung von using ermöglicht eine Kurzschreibweise
            // NewElements.DemoLibrary.Class1.PrintTime();
            Class1.PrintTime();            
        }
    }
}
