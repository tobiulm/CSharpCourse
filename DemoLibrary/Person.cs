using InterfaceLibrary;
namespace DemoLibrary
{
    public class Person : IPerson
    {
        private string _firstName;
        internal string _lastName;
        private DateOnly _dateOfBirth;
        private Gender _gender;

        public static int NumberOfPeople = 0;
        
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if(_firstName != value)
                {
                    _firstName = value;
                }
            }
        }

        public int Age { get; set; }


        public string LastName { get => _lastName.ToUpper(); set => _lastName = value; }
        public DateOnly DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public Gender Gender { get => _gender; set => _gender = value; }


        // Default Constructor
        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            NumberOfPeople++;
        }

        // Constructor
        public Person(string firstName, string lastName) : this()
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Person(string firstName, string lastName, DateOnly dateOfBirth, Gender gender) : this(firstName, lastName)
        {
            _dateOfBirth = dateOfBirth;
            _gender = gender;
        }



        public virtual string SayHello()
        {
            return $"Hello, my name is {LastName}, {FirstName} {LastName}. We have {NumberOfPeople} People running around...";
        }

        public static string PrintNumberOfPeople()
        {
            return $"There are {NumberOfPeople} people in the system.";
        }
    }
}
