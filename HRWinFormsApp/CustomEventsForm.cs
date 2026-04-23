using NewElements.DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRWinFormsApp
{
    public partial class CustomEventsForm : Form
    {
        public CustomEventsForm()
        {
            InitializeComponent();
            Form1.Mitarbeiter.AbteilungVerändert += Mitarbeiter_AbteilungVerändert;
            // Anonyme Methode
            Form1.Mitarbeiter.AbteilungVerändert += delegate {
                meldungsLabel.Text = $"Die Abteilung um {DateTime.Now.ToLongTimeString()} geändert.";
            };
        }

        /// <summary>
        /// EventHandler für unser eigenes Ereignis AbteilungVerändert
        /// </summary>
        private void Mitarbeiter_AbteilungVerändert(AbteilungVerändertEventArgs e)
        {
            meldungsLabel.Text = $"Die Abteilung wurde von {e.AlteAbteilung} auf {e.NeueAbteilung} um {DateTime.Now.ToLongTimeString()} geändert.";
        }
    }
}