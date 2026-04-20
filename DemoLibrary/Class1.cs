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
    }
}