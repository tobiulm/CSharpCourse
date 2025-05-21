using DemoLibrary;
namespace TestProject
{
    public class PersonTest
    {
        [Fact]
        public void Test_Person_Name_Constructor()
        {
            Person person = new Person("Max", "Mustermann");
            Assert.Equal("Max", person.FirstName);
            Assert.Equal("MUSTERMANN", person.LastName);
        }
    }
}