using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    internal class Katze : Säugetier
    {
        public Katze() : base(true)
        {
        }

        public override string StellDichVor()
        {
            return "Miau";
        }
    }
}
