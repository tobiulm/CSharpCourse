using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.InterfaceLibrary
{
    public interface IMitarbeiter : IMensch
    {
        float PersonalNummer { get; }
        decimal Gehalt { get; }
    }
}