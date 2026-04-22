using NewElements.DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.CSharpConsoleApp
{
    internal class DemoKlasse : Mensch
    {
        public void ZugriffsmodifiziererTest()
        {
            _geschlecht = new Geschlecht(); // protected internal
            _nachName = "protected";
        }
    }
}