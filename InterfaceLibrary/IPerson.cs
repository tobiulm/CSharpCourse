namespace InterfaceLibrary
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateOnly DateOfBirth { get; set; }

        string SayHello();
    }
}