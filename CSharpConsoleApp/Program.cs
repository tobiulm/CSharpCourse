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
            // Class1.Kontrollstrukturen();

            // Beispiel für Ausnahmenbehandlung
            try
            {
                Class1.Ausnahmenbehandlung();
            }
            catch(FileNotFoundException fex)
            {
                Console.WriteLine("Datei konnte nicht gefunden werden. Wählen Sie bitte eine andere Datei zu öffnen aus.....");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Upps, das hätte nicht passieren dürfen.... ;-)");
            }
            finally
            {
                Console.WriteLine("Dieser Code wird immer garantiert ausgeführt! Egal ob im try Block eine Exception passiert (=>  catch) oder nicht.");
            }
            Console.Write("Dieser Code läuft nach der Exception, oder etwa nicht?");
        }
    }
}