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
    }
}