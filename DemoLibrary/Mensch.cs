using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Stellt in unserem System die Grundlagen für einen Menschen dar
    /// </summary>
    public class Mensch
    {
        /// <summary>
        /// Speichert den Vornamen des Menschens
        /// </summary>
        private string _vorName;
        /// <summary>
        /// Speichert den Nachnamen des Menschens
        /// </summary>
        protected string _nachName;
        /// <summary>
        /// Speichert das Geburtsdatum des Menschens
        /// </summary>
        internal DateOnly _geburtsDatum;
        /// <summary>
        /// Speichert das Geschlecht des Menschens
        /// </summary>
        protected internal Geschlecht _geschlecht;
        /// <summary>
        /// Speichert das Alter des Menschens
        /// </summary>
        private float _alter;

        /// <summary>
        /// Liest oder setzt den Vornamen des Menschens
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
        /// Liest oder setzt den Nachnamen des Menschens
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
        /// Liest oder setzt das Geburtsdatum des Menschens
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
                    BerechneAlter();
                }
            }
        }

        /// <summary>
        /// Liest oder setzt das Geschlecht des Menschens
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
        /// Liest das Alter abhängig vom Geburtsdatum
        /// </summary>
        public float Alter
        {
            get
            {
                return _alter;
            }
        }

        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public Mensch()
        {
            _vorName = "";
            _nachName = "";
            _geburtsDatum = new DateOnly();
            _geschlecht = Geschlecht.NichtAngegeben;
        }

        /// <summary>
        /// Überladener Konstruktor um einen Mensch mit Vorname und Geschlecht zu erstellen
        /// </summary>
        /// <param name="vorName">Der Vorname des Menschen</param>
        /// <param name="geschlecht">Das Geschlecht des Menschen</param>
        public Mensch(string vorName, Geschlecht geschlecht) : this()
        {
            _vorName = vorName;
            _geschlecht = geschlecht;
        }

        /// <summary>
        /// Überladener Konstruktor um einen Mensch mit Vorname, Nachname und Geschlecht zu erstellen
        /// </summary>
        /// <param name="vorName">Der Vorname des Menschen</param>
        /// <param name="nachName">Der Nachname des Menschen</param>
        /// <param name="geschlecht">Das Geschlecht des Menschen</param>
        public Mensch(string vorName, string nachName, Geschlecht geschlecht) : this(vorName, geschlecht)
        {
            _nachName = nachName;
        }

        /// <summary>
        /// Überladener Konstruktor um einen Mensch mit Vorname, Nachname und Geschlecht zu erstellen
        /// </summary>
        /// <param name="vorName">Der Vorname des Menschen</param>
        /// <param name="nachName">Der Nachname des Menschen</param>
        /// <param name="geschlecht">Das Geschlecht des Menschen</param>
        /// <param name="geburtsDatum">Das Geburtsdatum des Menschen</param>
        public Mensch(string vorName, string nachName, Geschlecht geschlecht, DateOnly geburtsDatum) : this(vorName, nachName, geschlecht)
        {
           GeburtsDatum = geburtsDatum;
        }

        /// <summary>
        /// Generiert einen Begüßungstext mit dem Vornamen und Nachnamen des Menschs
        /// </summary>
        /// <returns>Der Begüßungstext</returns>
        public virtual string StellDichVor()
        {
            return $"Hallo, mein Name ist {_nachName}, {_vorName} {_nachName}.";
        }

        /// <summary>
        /// Berechnet das Alter des Menschens abhängig vom Geburtsdatum
        /// </summary>
        private void BerechneAlter()
        {
            int alter = DateTime.Now.Year - _geburtsDatum.Year;
            _alter = alter;
        }
    }
}