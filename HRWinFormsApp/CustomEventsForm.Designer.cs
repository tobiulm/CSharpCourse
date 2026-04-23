namespace HRWinFormsApp
{
    partial class CustomEventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            meldungsLabel = new Label();
            SuspendLayout();
            // 
            // meldungsLabel
            // 
            meldungsLabel.AutoSize = true;
            meldungsLabel.Location = new Point(12, 9);
            meldungsLabel.Name = "meldungsLabel";
            meldungsLabel.Size = new Size(0, 21);
            meldungsLabel.TabIndex = 0;
            // 
            // CustomEventsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 109);
            Controls.Add(meldungsLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CustomEventsForm";
            Text = "Eigene Ereignisse (Mitarbeiter.AbteilungGeändert)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label meldungsLabel;
    }
}