using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    public abstract class Säugetier
    {
        public static long Anzahl_Säugetiere;

        private bool _istEinRaubtier = false;

        public bool IstEinRaubtier
        {
            get
            {
                return _istEinRaubtier;
            }
            set
            {
                _istEinRaubtier = value;
            }
        }

        public Säugetier(bool raubTier)
        {
            _istEinRaubtier = raubTier;
            Anzahl_Säugetiere++;
        }

        public void Kommuniziere()
        {
            Console.WriteLine(StellDichVor());
        }

        public abstract string StellDichVor();

    }
}
