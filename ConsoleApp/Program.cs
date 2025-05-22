using ConsoleApp.CustomTypes;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DemoLibrary;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            //{
            //    builder.AddConsole();
            //});
            //ILogger logger = loggerFactory.CreateLogger<Program>();
            //logger.LogInformation("Application started.");

            //Console.WriteLine("Hello, World!");


            //// Variable für den Namen
            //string name;

            //// Frage den Benutzer nach seinem Namen
            //Console.WriteLine("Enter your name: ");
            //name = Console.ReadLine();


            //// Begrüße den Benutzer mit seinem Namen
            //Console.WriteLine($"Hello, {name}!");



            //switch (name)
            //{
            //    case "Alice":
            //        Console.WriteLine("Welcome, Alice!");
            //        break;
            //    case "Bob":
            //        Console.WriteLine("Welcome, Bob!");
            //        break;
            //    default:
            //        Console.WriteLine("Welcome, guest!");
            //        break;
            //}

            //DemoMethode();
            //string result = DemoMethode2();
            //DemoMethode3(name);


            ///* int meineZahl = 42; // x
            //Console.WriteLine($"Die Zahl ist: {meineZahl}");
            //MethodeParameterByValue(meineZahl); // y = x => zahl = meineZahl
            //Console.WriteLine($"Die Zahl ist: {meineZahl}");
            //MethodeParameterByReference(ref meineZahl); // y = x
            //Console.WriteLine($"Die Zahl ist: {meineZahl}");
            //*/

            //try
            //{

            //    SagHallo();
            //    SagHallo(name);
            //    SagHallo(name, 30);
            //    SagHallo(30, name);

            //}
            //catch(FileNotFoundException fex)
            //{

            //}
            //catch(DivideByZeroException dex)
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{

            //}

            // CustomTypes();
            //ArraysAndLists();
            //DelegatesDemo();
            //EventDemo();
            //LinqDemo();
            Oop();
        }

        /// <summary>
        /// Begrüßt den Benutzer mit "Hallo!"
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        static void SagHallo()
        {
            throw new FileNotFoundException("File not found exception occurred.");

            Console.WriteLine("Hallo!");
        }

        /// <summary>
        /// Begrüßt den Benutzer mit seinem Namen
        /// </summary>
        /// <param name="name">Der Name des Benutzers</param>
        static void SagHallo(string name)
        {
            Console.WriteLine($"Hallo, {name}!");
        }

        //static string SagHallo(string name)
        //{ 
        //    return ";
        //}

        static void SagHallo(string name, int alter)
        {
            Console.WriteLine($"Hallo, {name}! Du bist {alter} Jahre alt.");
        }

        static void SagHallo(int alter, string name)
        {
            Console.WriteLine($"Hallo, {name}! Du bist {alter} Jahre alt.");
        }

        static void MethodeParameterByValue(int zahl) // y
        {
            zahl = zahl + 1;
            Console.WriteLine($"In MethodeParameterByValue: {zahl}");
        }

        static void MethodeParameterByReference(ref int zahl) // y
        {
            zahl = zahl + 1;
            Console.WriteLine($"In MethodeParameterByReference: {zahl}");
        }

        static void DemoMethode()
        {
            Console.WriteLine("This is a demo method.");
        }

        static string DemoMethode2()
        {
            return "This is a demo method with a return value.";
        }

        static void DemoMethode3(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void CustomTypes()
        {
            // Demo for Structs
            float x = 12.12f;
            float y = 56.93f;

            Point2D p1 = new();
            p1.X = 12.89f;
            p1.Y = 23.45f;

            Point2D p2 = p1.AddVector(x, y);

            Console.WriteLine($"Point2D p2: {p2.X}, {p2.Y}");

            // Demo for Enums
            CarOptions myCar = CarOptions.Bluetooth | CarOptions.Sunroof | CarOptions.AllWheelDrive;
            Console.WriteLine($"My car options: {myCar}={(int)myCar}");
            EnumDemo(CarOptions.AllWheelDrive);

        }

        static void EnumDemo(CarOptions options)
        {
            Console.WriteLine(options);
        }

        static void ArraysAndLists()
        {
            string[] names = new string[3]; // Dim names as String(3)
            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";

            string[] backup = new string[names.Length];
            names.CopyTo(backup, 0);

            names = new string[4]; // Redim Preserve names as string(4);
            backup.CopyTo(names, 0);
            names[3] = "David";

            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add("Alice");
            list.Add("Bob");
            list.Add("Charlie");
            list.Insert(1, "David");
            list.Remove("Bob");
            list.RemoveAt(0);
            list.Clear();
            list.Add("Eve");
            list.Add("Frank");
            list.Reverse();

            list.Add("Tobi");
            list.Add(42);
            list.Add(names);

            


        }

        static void DelegatesDemo()
        {
            int[] numbers = { 5, 2, 8, 1, 4, 9, 3, 10, 7, 6 };
            Sorter sorter;
            sorter.BubbleSort(numbers, SortOrder.Ascending);
            PrintList(numbers);
            Console.WriteLine();
            sorter.BubbleSort(numbers, SortOrder.Descending);
            PrintList(numbers);

        }

        static void PrintList(int[] list)
        {
            foreach (int number in list)
            {
                Console.Write($"\t{number}");
            }
        }

        static void EventDemo()
        {
            Point2D p1 = new Point2D();
            p1.VectorAdded += MeinEvent;
            // a few ours later....
            p1.AddVector(1.0f, 2.0f);

        }

        static void MeinEvent()
        {
            Console.WriteLine("Mein Event wurde ausgelöst!");
        }

        static void LinqDemo()
        {


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Step 1
            //Func<int, bool> comparePointer = IsEven;
            //IEnumerable<int> evenNumbers = numbers.Where(comparePointer);

            // Step 2
            //IEnumerable<int> evenNumbers = numbers.Where(delegate (int number)
            //{
            //    return number % 2 == 0;
            //});

            // Step 3 = >
            //IEnumerable<int> evenNumbers = numbers.Where((int number) =>
            //{
            //    return number % 2 == 0;
            //});

            // Step 4
            //IEnumerable<int> evenNumbers = numbers.Where(number =>
            //{
            //    return number % 2 == 0;
            //});

            // Step 5 == LAMBDA EXPRESSION
            //IEnumerable<int> evenNumbers = numbers.Where(number => number % 2 == 0);

           // Step 6 == WHERE LINQ
          var evenNumbers = from number in numbers
                                          where number % 2 == 0
                                          select new
                                          {
                                            DerWert = number,
                                            Uhrzeit = DateTime.Now.ToLongTimeString()
                                          };

            



            //foreach (int number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"Der Wert ist: {number.DerWert} und die Uhrzeit ist: {number.Uhrzeit}");
            }

        }

        //static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        static void Oop()
        {
            Person james;
            james = new Person(); // Default Constructor
            james.FirstName = "James";
            james.LastName = "Bond";
            james.Gender = Gender.Male;
            james.DateOfBirth = new DateOnly(1980, 1, 1);

            Console.WriteLine(james.SayHello());

            string test = james.FirstName;

            //Person tobi = new Person("Tobi", "Ulm", new DateOnly(1976, 6,5), Gender.Male);
            //Console.WriteLine(tobi.SayHello());
            //Console.WriteLine(james.SayHello());

            Console.WriteLine(Person.PrintNumberOfPeople());


            Person tobi = new Person() { FirstName = "Tobi", LastName = "Ulm" };
            Person raphael = new Person("test", "test") { };


            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Tobi");
            list.Add(james);

            switch (list[0])
            {
                case int i:
                    Console.WriteLine($"Integer: {i}");
                    break;
                case string s:
                    Console.WriteLine($"String: {s}");
                    break;
                case Person p:
                    Console.WriteLine($"Person: {p.FirstName} {p.LastName}");
                    break;
                default:
                    Console.WriteLine("Unknown type.");
                    break;
            }
           
            List<Person> numbers = new List<Person>();

            DemoGenericType<int> myGenericObject = new DemoGenericType<int>();

            Employee emp1 = new Employee();
            
            
                       
        }
    }
}