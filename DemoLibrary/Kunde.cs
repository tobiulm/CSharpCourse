using NewElements.InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    public class Kunde : Mensch, IKunde
    {
        public Guid KundenNummer => throw new NotImplementedException();

    }
}