using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    public abstract class Säugetier
    {
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
        }

        public void Kommuniziere()
        {
            Console.WriteLine(StellDichVor());
        }

        public abstract string StellDichVor();

    }
}
