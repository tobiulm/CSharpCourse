using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;



namespace AsyncWinFormsApp
{
    internal static class InteropHelper
    {

        [DllImport("winmm.dll", SetLastError = true, EntryPoint ="sndPlaySoundA", ExactSpelling =true)]
        internal static extern int PlaySound(string lpszName, uint dwFlags);

    }
}
