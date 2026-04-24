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
            //try
            //{
            //    Class1.Ausnahmenbehandlung();
            //}
            //catch (FileNotFoundException fex)
            //{
            //    Console.WriteLine("Datei konnte nicht gefunden werden. Wählen Sie bitte eine andere Datei zu öffnen aus.....");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Upps, das hätte nicht passieren dürfen.... ;-)");
            //}
            //finally
            //{
            //    Console.WriteLine("Dieser Code wird immer garantiert ausgeführt! Egal ob im try Block eine Exception passiert (=>  catch) oder nicht.");
            //}
            //Console.Write("Dieser Code läuft nach der Exception, oder etwa nicht?");

            //// Beispiele für Methoden

            //// Beispiel für Subroutine
            //Class1.SagHallo();
            //string uhrzeit = Class1.GeneriereUhrzeit();
            //Console.WriteLine(uhrzeit);

            //// Beispiel für Funktion mit Rückgabewert
            //int nummer1 = 21;
            //int nummer2 = 21;
            //int ergebnis = Class1.Addiere(nummer1, nummer2);
            //Console.WriteLine(ergebnis);


            //// Beispiel für Übergabeparameter als Wert oder Referenz
            //int zahl = 1;
            //Class1.ParamByValue(zahl);
            //Console.WriteLine($"Program.Main: zahl = {zahl}");
            //Class1.ParamByReference(ref zahl);
            //Console.WriteLine($"Program.Main: zahl = {zahl}");

            //// Beispiele für Methodenüberladung
            //Class1.SagHallo("James");

            //float ergebnis1 = Class1.Addiere(1, 2.34f);
            //Console.WriteLine(ergebnis1);

            //float ergebnis2 =  Class1.Addiere(1, 2);
            //Console.WriteLine(ergebnis2);

            //  **********************************************************************************************
            // Eigene Datentypen => ab hier gehts erst richtig los!!!
            //  **********************************************************************************************

            // Demo für Enumerationen
            //Wochentage meinTag = Wochentage.Donnerstag;
            //Class1.EnumDemo(meinTag);
            //Class1.EnumDemo(Wochentage.Samstag);

            // Demo für Strukturen
            // Class1.StrukturenDemo();

            // Demo für Klassen und OOP
            //Class1.OopDemo();

            // Demo für Delegates
            //Class1.DelegatesDemo();

            // Demos für Attribute
            //Class1.AttributeDemo();

            // Demo für Extensionmethods aka Erweiterungsmethoden
            //Mitarbeiter emp1 = new Mitarbeiter("Otto", "Waalkes", Abteilungen.Produktion);
            //Console.WriteLine(emp1.ZeigeMitarbeiterInfos());

            // Lambda Ausdrücke Demo
            //Class1.LambdaExpressionsDemo();

            // Typenermittlung
            //Class1.TypenErmittlung();

            // Linq
            //Class1.LinqDemo();

            // Datenbankprogrammierung
            Class1.DatenbankDemo();
        }
    }
}