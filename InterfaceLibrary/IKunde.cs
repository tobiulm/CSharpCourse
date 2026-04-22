using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.InterfaceLibrary
{
    public interface IKunde : IMensch
    {
        Guid KundenNummer { get; }
    }
}