using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary;
namespace InterfaceApp
{
    internal class DummyPerson : IPerson
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateOnly DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SayHello()
        {
            throw new NotImplementedException();
        }
    }
}
