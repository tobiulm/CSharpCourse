using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Diese Klasse enthält eine C# Methode die einen Aufruf durch das Attribut DllImport auf die Windows winmm.dll macht
    /// </summary>
    public static class InteropDemo
    {
        /// <summary>
        /// Diese C# Methode ist lediglich ein Proxy und reicht den Aufruf auf die PlaySound Methode aus der C Bibliothek winmm.dll weiter um eine Audiodatei zu spielen
        /// </summary>
        /// <param name="dateiName">Der Name der Audiodatei die abgespielt werden soll</param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        public static extern bool SpieleSound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);
    }

    [System.Flags]
    public enum PlaySoundFlags : int
    {
        SND_SYNC = 0x0000,
        SND_ASYNC = 0x0001,
        SND_NODEFAULT = 0x0002,
        SND_LOOP = 0x0008,
        SND_NOSTOP = 0x0010,
        SND_NOWAIT = 0x00002000,
        SND_FILENAME = 0x00020000,
        SND_RESOURCE = 0x00040004
    }
}
