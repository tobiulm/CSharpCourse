using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    public static class InteropDemo
    {
        [DllImport("winmm.dll", CharSet = CharSet.Ansi, EntryPoint = "sndPlaySoundA", ExactSpelling = true)]
        public static extern int SpieleSound(ref string dateiName, int dwFlags);
    }
}
