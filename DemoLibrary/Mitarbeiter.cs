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
    public class Mitarbeiter
    {
        /// <summary>
        /// Speichert die Personalnummer des Mitarbeiters
        /// </summary>
        private float _personalNummer;
        /// <summary>
        /// Speichert den Vornamen des Mitarbeiters
        /// </summary>
        private string _vorName;
        /// <summary>
        /// Speichert den Nachnamen des Mitarbeiters
        /// </summary>
        private string _nachName;
        /// <summary>
        /// Speichert das Geburtsdatum des Mitarbeiters
        /// </summary>
        private DateOnly _geburtsDatum;
        /// <summary>
        /// Speichert die Abteilung des Mitarbeiters
        /// </summary>
        private Abteilungen _abteilung;
        /// <summary>
        /// Speichert das Geschlecht des Mitarbeiters
        /// </summary>
        private Geschlecht _geschlecht;
        /// <summary>
        /// Speichert das Gehalt des Mitarbeiters
        /// </summary>
        private  decimal _gehalt;

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
        /// Liest oder setzt den Vornamen des Mitarbeiters
        /// </summary>
        public string VorName
        {
            get
            {
                return _vorName;
            }
            set
            {
                if (_vorName != value && value.Length > 0)
                {
                    _vorName = value;
                }
            }
        }

        /// <summary>
        /// Liest oder setzt den Nachnamen des Mitarbeiters
        /// </summary>
        public string NachName
        {
            get
            {
                return _nachName;
            }
            set
            {
                if (_nachName != value && value.Length > 0)
                {
                    _nachName = value;
                }
            }
        }

        /// <summary>
        /// Liest oder setzt das Geburtsdatum des Mitarbeiters
        /// </summary>
        public DateOnly GeburtsDatum
        {
            get
            {
                return _geburtsDatum;
            }
            set
            {
                if (_geburtsDatum != value && (DateTime.Now.Year - value.Year >= 16))
                {
                    _geburtsDatum = value;
                }
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
        /// Liest oder setzt das Geschlecht des Mitarbeiters
        /// </summary>
        public Geschlecht Geschlecht
        {
            get
            {
                return _geschlecht;
            }
            set
            {
                if (value != _geschlecht)
                {
                    _geschlecht = value;
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
        /// Standardkonstruktor
        /// </summary>
        public Mitarbeiter()
        {
            _abteilung = Abteilungen.Keine;
            _geburtsDatum = DateOnly.MinValue;
            _geschlecht = Geschlecht.NichtAngegeben;
            _nachName = "";
            _vorName = "";
        }

        /// <summary>
        /// Überladender Konstruktor der das Mitarbeiterobjekt mit Vorname, Nachname und Abteilung initialisiert
        /// </summary>
        /// <param name="vorName">Der Vorname des Mitarbeiters</param>
        /// <param name="nachName">Der Nachname des Mitarbeiters</param>
        /// <param name="abteilung">Die Abteilung des Mitarbeiters</param>
        public Mitarbeiter(string vorName, string nachName, Abteilungen abteilung)
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
        public string StellDichVor()
        {
            return $"Hallo, mein Name ist {_vorName} und ich arbeite in der Abteilung {_abteilung}.";
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

    }
}
