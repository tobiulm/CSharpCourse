using System.Text.Json.Serialization;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Repräsentiert die Abteilungen in unserer Welt
    /// </summary>
    public enum Abteilungen
    {
        /// <summary>
        /// Die Abteilung ist nicht zugewiesen
        /// </summary>
        Keine,
        /// <summary>
        /// Die Abteilung Produktion
        /// </summary>
        Produktion,
        /// <summary>
        /// Die Abteilung Marketing
        /// </summary>
        Marketing,
        /// <summary>
        /// Die Abteilung IT
        /// </summary>
        IT,
        /// <summary>
        /// Die Geschäftsleitung
        /// </summary>
        Management
    }
}