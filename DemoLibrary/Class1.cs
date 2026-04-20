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
    }
}