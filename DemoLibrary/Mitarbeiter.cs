using NewElements.InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Stellt einen Mitarbeiter in unserem System dar
    /// </summary>
    public sealed class Mitarbeiter : Mensch , IMitarbeiter, IDisposable
    {
        /// <summary>
        /// Speichert die Personalnummer des Mitarbeiters
        /// </summary>
        private float _personalNummer;
        
        /// <summary>
        /// Speichert die Abteilung des Mitarbeiters
        /// </summary>
        private Abteilungen _abteilung;
        
        /// <summary>
        /// Speichert das Gehalt des Mitarbeiters
        /// </summary>
        private  decimal _gehalt;

        /// <summary>
        /// Speichert einen Zufallszahlengenerator um die Personalnummern zu befüllen
        /// </summary>
        private  static Random _personalNummerGenerator = new Random();
        private bool disposedValue;


        /// <summary>
        /// Liest die Personalnummer des Mitarbeiters
        /// </summary>
        public float PersonalNummer
        {
            get
            {
                return _personalNummer;
            }
        }

        /// <summary>
        /// Liest oder setzt die Abteilung des Mitarbeiters
        /// </summary>
        public Abteilungen Abteilung
        {
            get
            {
                return _abteilung;
            }
            set
            {
                if (value != _abteilung)
                {
                    _abteilung = value;
                    BerechneGehalt();
                }
            }
        }

       

        /// <summary>
        /// List das Gehalt eines Mitarbeiters aus
        /// </summary>
        public decimal Gehalt
        {
            get
            {
                return _gehalt;
            }
        }

        /// <summary>
        /// Liest und setzt das Geburtsdatum eines Mitarbeiters. Andere Implemntierung durch SHADOWING  (new) als Mensch.GeburtsDatum. Zusätzliche überprüfung des Alters auf mindestens 16 Jahre.
        /// </summary>
        public new DateOnly GeburtsDatum
        {
            get
            {
                return _geburtsDatum;
            }
            set
            {
                if(value != _geburtsDatum && (DateTime.Now.Year - value.Year >= 16))
                {
                    base.GeburtsDatum = value;
                }
            }
        }

        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public Mitarbeiter():base()
        {
            _abteilung = Abteilungen.Keine;
            _geburtsDatum = DateOnly.MinValue;
            _geschlecht = Geschlecht.NichtAngegeben;
            _nachName = "";
            VorName = "";
            _personalNummer = _personalNummerGenerator.Next(1, 1000000);
        }

        /// <summary>
        /// Überladender Konstruktor der das Mitarbeiterobjekt mit Vorname, Nachname und Abteilung initialisiert
        /// </summary>
        /// <param name="vorName">Der Vorname des Mitarbeiters</param>
        /// <param name="nachName">Der Nachname des Mitarbeiters</param>
        /// <param name="abteilung">Die Abteilung des Mitarbeiters</param>
        public Mitarbeiter(string vorName, string nachName, Abteilungen abteilung):this()
        {
            VorName = vorName;
            NachName = nachName;
            Abteilung = abteilung;
        }

        /// <summary>
        /// Überladener Konstruktor der das Mitarbeiterobjekt mit Vorname, Nachname, Abteilung, Geschlecht und Gerburtsdatum initialisiert
        /// </summary>
        /// <param name="vorName">Der Vorname des Mitarbeiters</param>
        /// <param name="nachName">Der Nachname des Mitarbeiters</param>
        /// <param name="abteilung">Die Abteilung des Mitarbeiters</param>
        /// <param name="geschlecht">Das Geschlecht des Mitarbeiters</param>
        /// <param name="geburtsDatum">Das Geburtsdatum des Mitarbeiters</param>
        public Mitarbeiter(string vorName, string nachName, Abteilungen abteilung, Geschlecht geschlecht, DateOnly geburtsDatum) : this(vorName, nachName, abteilung)
        {
            Geschlecht = geschlecht;
            GeburtsDatum = geburtsDatum;
        }

        /// <summary>
        /// Generiert einen Begüßungstext des Mitarbeiters
        /// </summary>
        /// <returns>Der Begrüßungstext mir Vorname und Abteilung</returns>
        public override string StellDichVor()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#################################################################################################################");
            sb.AppendLine(base.StellDichVor()); // base = ruft die originale Mensch.StellDichVor Methode auf!
            sb.AppendLine($"Ich arbeite in der Abteilung {_abteilung} und meine Personalnummer lautet: {_personalNummer}.");
            sb.AppendLine("#################################################################################################################");
            return sb.ToString();
        }

        /// <summary>
        /// Berechnet und setzt aufgrund unserer Geschäftsregeln das Gehalt eines Mitarbeiters
        /// </summary>
        private void BerechneGehalt()
        {
            switch (_abteilung)
            {
                case Abteilungen.Produktion:
                    _gehalt = 40000.00m;
                    break;
                case Abteilungen.Marketing:
                    _gehalt = 35000.00m;
                    break;
                case Abteilungen.IT:
                    _gehalt = 55000.00m;
                    break;
                case Abteilungen.Management:
                    _gehalt = 100000.00m;
                    break;
                default:
                    _gehalt = 22000.00m;
                    break;
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    // Alle Mitarbeiter Projekt Objekte zerstören
                    // zb.: this.Projkte[0].Dispose();
                    VorName = "";
                    NachName = "";
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~Mitarbeiter()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }


        /// <summary>
        /// Destruktor der Klasse Mitarbeiter
        /// </summary>
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
