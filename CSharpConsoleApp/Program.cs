namespace NewElements.CSharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Hello, World!"
            );
            Console.WriteLine(
                $"Aktuelle Uhrzeit: {DateTime.Now.ToLongTimeString()}"
            );
        }
    }
}
