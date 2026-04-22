using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.InterfaceLibrary
{
    public interface IMensch
    {
        string VorName { get; set; }
        string NachName { get; set; }
        DateOnly GeburtsDatum { get; set; }

        string StellDichVor();
    }
}