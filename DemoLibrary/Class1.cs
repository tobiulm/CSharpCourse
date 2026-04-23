using System.Runtime.InteropServices;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Diese Klasse wurde beim Anlegen des Projektes erzeugt und dient der Schulung zu Testzwecken verschiedener Syntaxelemente
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Gibt die aktuelle Uhrzeit in der Console aus
        /// </summary>
        public static void PrintTime()
        {
            Console.WriteLine($"Aktuelle Uhrzeit: {DateTime.Now.ToLongTimeString()}");
        }


        /// <summary>
        /// Demonstriert Variablen durch Deklaration und Typkonvertierung
        /// </summary>
        public static void VariablenUndTypkonvertierung()
        {
            // Deklaration und Verwendung von Variablen
            string name = "Tobi";
            short alter = 49;

            Console.WriteLine($"Hallo, mein Name ist {name} und ich bin {alter} Jahre alt.");

            // Wertetypen
            int i;
            i = 1;

            int j;
            j = i;
            j = j + 1;

            Console.WriteLine($"Wertetypen:");
            Console.WriteLine($"i = {i}\tj = {j}");

            // Datentypkonvertierung
            double großerWert = 123456.123;
            int kleinererWert = (int)großerWert; // explizite Datentypkonvertierung von Fließkommawert zu Ganzzahl!
            Console.WriteLine($"Wert nach Datentypkonvertierung von double nach int:\t{großerWert} => {kleinererWert}");

            // Datentypgenauigkeit
            Console.WriteLine("Datentypgenauigkeit:");
            float f1 = 10.0f;
            float f2 = 9.9f;
            float floatResult = f1 - f2;
            Console.WriteLine($"Float:\tf1:{f1} - f2:{f2} = {floatResult}");

            double d1 = 10.0;
            double d2 = 9.9;
            double doubleResult = d1 - d2;
            Console.WriteLine($"Double:\td1:{d1} - d2:{d2} = {doubleResult}");

            decimal dec1 = 10.0m;
            decimal dec2 = 9.9m;
            decimal decResult = dec1 - dec2;
            Console.WriteLine($"Decimal:\tdec1:{dec1} - dec2:{dec2} = {decResult}");
        }

        /// <summary>
        /// Demonstriert die Deklaration und Verwendung von Arrays und Listen
        /// </summary>
        public static void ArraysUndListen()
        {
            Console.WriteLine("Arrays:");
            // Eindimensionales Array
            int[] zahlen = new int[3];
            zahlen[0] = 1;
            zahlen[1] = 2;
            zahlen[2] = 3;
            Console.WriteLine($"zahlen an der Position 1 hat den Wert:\t{zahlen[1]}");

            // Kurzschreibweise => Initialisierungslisten
            int[] zahlen2 = { 1, 2, 3 };
            Console.WriteLine($"zahlen2 an der Position 1 hat den Wert:\t{zahlen2[1]}");

            // Mehrdimensionale Arrays

            // Tabelle
            int[,] tabelle = new int[3, 4];
            tabelle[0,0] = 1;
            tabelle[0,1] = 2;
            tabelle[0,2] = 3;

            tabelle[2, 3] = 12;
            Console.WriteLine($"tabelle an der Position 2,3 hat den Wert:\t{tabelle[2,3]}. Insgesamt gibt es {tabelle.Length} Speichermöglichkeiten");

            // Würfel
            int[,,] würfel = new int[4, 5, 3];

            // Listen
            System.Collections.ArrayList myList = new System.Collections.ArrayList();
            myList.Add(1);
            myList.Add("Tobi");
            myList.Add(zahlen2);

            int value = (int)myList[0];
         }

        /// <summary>
        /// Demonstriert die Steuerung eines Codes durch Iterationen und Entscheidungen
        /// </summary>
        public static void Kontrollstrukturen()
        {
            // Entscheidungen

            Console.WriteLine("Entscheidungen:");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("\tif Statement");

            string name;
            Console.WriteLine("\tBitte geben Sie Ihren Namen ein:");
            name = Console.ReadLine()!;

            if(name == "Oliver")
            {
                Console.WriteLine("Hi Oliver");
            }
            else if(name == "Verena")
            {
                Console.WriteLine("Servus Verena!");
            }
            else
            {
                Console.WriteLine("Guten Tag!");
            }


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("\tswitch Statement (Mehrfachauswahl)");
            switch (name)
            {
                case "Oliver":
                    Console.WriteLine("Hi Oliver!");
                    break;
                case "Verena":
                    Console.WriteLine("Servus Verena!");
                    break;
                case "Janik":
                    Console.WriteLine("Hey Janik!");
                    break;
                case "Fabian":
                    Console.WriteLine("Hallo Fabian!");
                    break;
                case "Enno":
                    Console.WriteLine("Grüzi Enno!");
                    break;
                default:
                    Console.WriteLine("Einen wunderschönen Tag wünsche ich!");
                    break;
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Iterationen (Schleifen)");

            string[] namen = { "Verena", "Oliver", "Enno", "Fabian", "Janik", "Tobi" };

            Console.WriteLine("\tfor Schleife:");
            for(int zähler = 0; zähler < namen.GetUpperBound(0); ++zähler)
            {
                Console.WriteLine($"Name an Position: {namen[zähler]} => {zähler}");
            }

            Console.WriteLine("\tdo-while Schleife [Fußgesteuert]:");
            int doZähler = 4;
            do
            {
                // ++doZähler;
                Console.WriteLine($"Name an Position: {namen[doZähler]} => {doZähler}");
                ++doZähler;
            } while(doZähler < namen.GetUpperBound(0));


            Console.WriteLine("\twhile Schleife [Kopfgesteuert]:");
            int whileZähler = 0;            
            while(whileZähler < namen.GetUpperBound(0))
            {
                Console.WriteLine($"Name an Position: {namen[whileZähler]} => {whileZähler}");
                whileZähler++;
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("foreach Statement");
            foreach(string vname in namen)
            {
                Console.WriteLine(vname);
            }
            // Eigentlicher Code des foreach Statements
            //for (int zähler = 0; zähler <= namen.GetUpperBound(0); ++zähler)
            //{
            //    string vname = namen[zähler];
            //    Console.WriteLine($"Name an Position: {vname} => {zähler}");
            //}

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Schleifen steuern mit continue und break");
            int[] zahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int zähler = 0; zähler <= zahlen.GetUpperBound(0); zähler++)
            {
                if(zähler == 5)
                {
                    continue;
                }
                if (zähler == 8)
                {
                    break;
                }
                Console.WriteLine($"zähler hat den Wert: {zähler}; \t Eintrag in der Liste: {zahlen[zähler]}");
               
            }
        }

        /// <summary>
        /// Beispiele für Exception Handling (Ausnahmebehandlung)
        /// </summary>
        public static void Ausnahmenbehandlung()
        {
            throw new ApplicationException("Dies ist ein Demofehler!");
        }

        /// <summary>
        /// Einfache Methode die Hallo ausgibt
        /// </summary>
        public static void SagHallo()
        {
            Console.WriteLine("Hallo!");
        }

        /// <summary>
        /// Beispiel für Methodenüberladung der Methode SagHallo
        /// </summary>
        /// <param name="name">Der Name der zum Begrüßen verwendet werden soll</param>
        public static void SagHallo(string name)
        {
            Console.WriteLine($"Hallo {name}!");
        }

        /// <summary>
        /// Generiert einen String mit der aktuellen Uhrzeit
        /// </summary>
        /// <returns>Die aktuelle Uhrzeit</returns>
        public static string GeneriereUhrzeit()
        {
            return DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Addiert zwei ganzzahl werte
        /// </summary>
        /// <param name="zahl1">Operand 1</param>
        /// <param name="zahl2">Operand 2</param>
        /// <returns>Das ergebnis als int</returns>
        public static int Addiere(int zahl1, int zahl2)
        {
            return (zahl1 + zahl2);
        }


        // Rückgabetyp hat keinen Einfluß auf die Methodensignatur
        //public static void Addiere(int zahl1, int zahl2)
        //{

        //}

        /// <summary>
        /// Beispiel für Methodenüberladung der Addiere Methode. Unterschiedliche Methodensignatur!
        /// </summary>
        /// <param name="zahl1">1. Operand als float</param>
        /// <param name="zahl2">2. Operand als int</param>
        /// <returns>Das ergebnis als float</returns>
        public static float Addiere(float zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        /// <summary>
        /// Beispiel für Methodenüberladung der Addiere Methode. Unterschiedliche Methodensignatur!
        /// </summary>
        /// <param name="zahl1">Operand 1</param>
        /// <param name="zahl2">Operand 2</param>
        /// <returns>Das ergebnis als float</returns>
        public static float Addiere(int zahl1, float zahl2)
        {
            return zahl1 + zahl2;
        }

        /// <summary>
        /// Demonstriert die Übergabe von Parametern an Methoden ByValue
        /// </summary>
        /// <param name="zahl">Der Übergabeparameter für die Demonstration von ByValue</param>
        public static void ParamByValue(int zahl)
        {
            // zahl = zahl + 1;
            zahl += 1; // Kurzschreibweise für die zeile davor
            Console.WriteLine($"Class1.ParamByValue: zahl = {zahl}");
        }

        /// <summary>
        /// Demonstriert die Übergabe von Parametern an Methoden ByReference
        /// </summary>
        /// <param name="erwin">Der Übergabeparameter für die Demonstration von ByReference</param>
        public static void ParamByReference(ref int erwin)
        {
            erwin += 1;
            Console.WriteLine($"Class1.ParamByRef: zahl = {erwin}");
        }

        /// <summary>
        /// Beispiel für die Verwendung von Enumerationen
        /// </summary>
        /// <param name="tag">Der ausgwählte Wert aus der Enumeration Wochentage</param>
        public static void EnumDemo(Wochentage tag)
        {
            Console.WriteLine(tag.ToString());

            switch (tag)
            {
                case Wochentage.Samstag:
                    Console.WriteLine("Yippie! Hoch die Hände! Wochenende!");
                    break;
                case Wochentage.Sonntag:
                    Console.WriteLine("Immer noch frei! ;-)");
                    break;
                default:
                    Console.WriteLine("Ab zum malochen!");
                    break;
            }

        }

        /// <summary>
        /// Beispiel für die Verwendung von Strukturen
        /// </summary>
        public static void StrukturenDemo()
        {
            Punkt2D p1;
            p1.X = 12.98f;
            p1.Y = 21.89f;

            Punkt2D p2;
            p2.X = 34.78f;
            p2.Y = 43.87f;

            Punkt2D p3 = p1.AddiereVektor(15.32f, 67.12f);
            Console.WriteLine($"p1.X={p1.X}; p1.Y={p1.Y}; Vektor.X=15.32; Vektor.Y=67.12; => Eregbnis: p3.X={p3.X}; p3.Y={p3.Y}");

            Punkt2D p4 = p2.AddiereVektor(p3);
            Console.WriteLine($"p2.X={p2.X}; p2.Y={p2.Y}; Vektor.X={p3.X}; Vektor.Y={p3.Y}; => Eregbnis: p4.X={p4.X}; p4.Y={p4.Y}");

        }

        /// <summary>
        /// Beispielmethode für Objekt Orientiertes Programmieren (OOP)
        /// </summary>
        public static void OopDemo()
        {
            Mitarbeiter emp1;
            emp1 = new Mitarbeiter(); // Default Constructor = Standardkonstruktor
            emp1.GeburtsDatum = new DateOnly(1956, 10, 21);
            emp1.Geschlecht = Geschlecht.Mann;
            emp1.Abteilung = Abteilungen.Management;
            emp1.NachName = "Gates";
            emp1.VorName = "Bill";
            Console.WriteLine(emp1.StellDichVor());
            Console.WriteLine($"Gehalt von emp1: {emp1.Gehalt}");
            GibAnzahlSäugetiereAus();


            Mitarbeiter emp2 = new Mitarbeiter("James", "Bond", Abteilungen.Produktion, Geschlecht.Mann, new DateOnly(1955, 4, 12));
            Console.WriteLine(emp2.StellDichVor());
            Console.WriteLine($"Gehalt von emp2: {emp2.Gehalt}");
            Console.WriteLine($"Mitarbeiter erbt Mensch => Der Mitarbeiter ist {emp2.Alter} Jahre alt.");
            GibAnzahlSäugetiereAus();


            Mensch frauke = new Mensch("Frauke", "Musterfrau", Geschlecht.Frau, new DateOnly(1990, 8, 1));
            Console.WriteLine(frauke.StellDichVor());
            Console.WriteLine($"Frauke ist {frauke.Alter} Jahre alt.");
            GibAnzahlSäugetiereAus();


            // Nicht erlaubt da eine abstrakte Basisklasse
            // Säugetier tier1 = new Säugetier(); 
            Katze lilly = new Katze();
            GibAnzahlSäugetiereAus();

            PolymorphismusDemo(lilly);
            PolymorphismusDemo(frauke);
            PolymorphismusDemo(emp2);


            
            frauke = null;
            lilly = null;
            emp1.Dispose(); // Aufruf des Destruktors => Speicherverwaltung
            emp2.Dispose();

            
        }

        /// <summary>
        /// Demonstration von abstrakten Basisklassen und Polymorphismus
        /// </summary>
        /// <param name="säugetier"></param>
        public static void PolymorphismusDemo(Säugetier säugetier)
        {
            säugetier.Kommuniziere();
            GibAnzahlSäugetiereAus();
        }

        /// <summary>
        /// Gibt die Anzahl der Säugetiere in unserem System auf der Console aus. => static Keyword in Säugetier
        /// </summary>
        public static void GibAnzahlSäugetiereAus()
        {
            Console.WriteLine($"Anzahl der Säugetiere: {Säugetier.Anzahl_Säugetiere}");
        }

        /// <summary>
        /// Demonstriert die Verwendung von Delegates
        /// </summary>
        public static void DelegatesDemo()
        {
            int[] zahlen = { 1024, 256, 512, 64, 32, 8, 16, 128, 712, 1, 4, 2 };
            Sortierer.BubbleSort(zahlen, SortierRichtung.Aufsteigend);
            foreach (int zahl in zahlen)
            {
                Console.Write($"{zahl} ");
            }
        }

        //public static void LinqDemo()
        //{
        //    int[] zahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var geradeZahlen = from zahl in zahlen
        //                       where zahl % 2 == 0
        //                       select zahl;

        //    foreach(int zahl in geradeZahlen)
        //    {
        //        Console.WriteLine(zahl);
        //    }
        //}

        /// <summary>
        /// Zeigt die Verwendung von Attributen in .net
        /// </summary>
        public static void AttributeDemo()
        {
            string datei = @"C:\Windows\Media\chord.wav";
            Console.WriteLine($"Spiele Audiodatei: {datei}...");
            int wert =  InteropDemo.SpieleSound(ref datei, 0);
            Console.WriteLine(wert);

            // Verwendung unsers eigenen Attributes DevelopInfoAttribute
            Mitarbeiter emp1 = new Mitarbeiter();
            DeveloperInfoAttribute meinAttribut = (DeveloperInfoAttribute) Attribute.GetCustomAttribute(emp1.GetType(), typeof(DeveloperInfoAttribute));
            
            if (meinAttribut != null)
            {
                Console.WriteLine("DeveloperInfoAttribute gefunden!");
                if(meinAttribut.DeveloperName == "Tobi Ulm")
                {
                    Console.WriteLine("Vertrauenswürdiger Sourcecode...");
                    Console.WriteLine("Fahre mit der Ausführung des Programmes fort...");
                }
                return;
            }
            else
            {
                Console.WriteLine($"DeveloperInfoAttribute nicht gefunden.{System.Environment.NewLine}Beende das Programm.");
            }
        }

        /// <summary>
        /// Beispiele für Generics => System.Collections.Generic
        /// </summary>
        public static void GenerikaDemo()
        {
            List<int> meineListe = new List<int>();
            meineListe.Add(12);

            int meinWert = meineListe[0];

            PersonenListe<Kunde> neueListe = new PersonenListe<Kunde>();
        }

        public static void LambdaExpressionsDemo()
        {
            List<Mensch> personen = new List<Mensch>();
            personen.Add(new Mensch("A", "A", Geschlecht.Frau));
            personen.Add(new Mensch("B", "B", Geschlecht.Frau));
            personen.Add(new Mensch("C", "C", Geschlecht.Mann));
            personen.Add(new Mensch("D", "D", Geschlecht.Frau));
            personen.Add(new Mensch("E", "E", Geschlecht.Mann));
            personen.Add(new Mensch("F", "F", Geschlecht.Mann));
            personen.Add(new Mensch("G", "G", Geschlecht.Frau));
            personen.Add(new Mensch("H", "H", Geschlecht.Mann));
            personen.Add(new Mensch("I", "I", Geschlecht.Divers));



            // IEnumerable<Mensch> frauen = new List<Mensch>(); // Schnittstellenpolymorphismus
            

            // Lambda Schritt 1
            //foreach(Mensch m in personen)
            //{
            //    if(m.Geschlecht == Geschlecht.Frau)
            //    {
            //        frauen.Add(m);
            //    }
            //}

            // Lambda Schritt 2
            //Func<Mensch, bool> zeigerAufDieFilterFunktion = FilterNachFrauen; //generischer Delegate
            //frauen = personen.Where(zeigerAufDieFilterFunktion);

            // Lambda Schritt 3
            //frauen = personen.Where(delegate (Mensch m)
            //{
            //    bool ergebnis = false;
            //    if (m.Geschlecht == Geschlecht.Frau)
            //    {
            //        ergebnis = true;
            //    }
            //    return ergebnis;
            //});

            // Lambda Schritt 4
            //frauen = personen.Where((Mensch m) => // Lamda Operator =>
            //{
            //    bool ergebnis = false;
            //    if (m.Geschlecht == Geschlecht.Frau)
            //    {
            //        ergebnis = true;
            //    }
            //    return ergebnis;
            //});

            // Lambda Schritt 5
            //frauen = personen.Where(m => // wegnahme des datentyps des Parameters m => ergibt sich aus der liste personen = IEnumable<Mensch>
            //{
            //    bool ergebnis = false;
            //    if (m.Geschlecht == Geschlecht.Frau)
            //    {
            //        ergebnis = true;
            //    }
            //    return ergebnis;
            //});

            // Lambda Schritt 6
            var frauen = personen.Where(m => m.Geschlecht == Geschlecht.Frau || m.Geschlecht == Geschlecht.Divers); // Das ist ein Lamda Ausdruck!!!


            foreach (Mensch m in frauen)
            {
                Console.WriteLine($"{m.VorName} {m.NachName} {m.Geschlecht}");
            }

        }

        private static bool FilterNachFrauen(Mensch m)
        {
            //bool ergebnis = false;
            //if(m.Geschlecht == Geschlecht.Frau)
            //{
            //    ergebnis = true;
            //}
            //return ergebnis;
            return m.Geschlecht == Geschlecht.Frau ? true : false;
        }

        /// <summary>
        /// Beispiel für die Typenermittlung in C# => aka var Keyword
        /// </summary>
        public static void TypenErmittlung() // Typeinferencing
        {
            int i = 42;
            var tobi = new Mensch();

            var j = "42";

            var z = true;


        }

    }
}