namespace HRWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainButton = new Button();
            outputLabel = new Label();
            eventHandlerAnfügenButton = new Button();
            eventHandlerLösenButton = new Button();
            groupBox1 = new GroupBox();
            abteilungComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            abteilungLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainButton
            // 
            mainButton.Location = new Point(12, 29);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(1005, 45);
            mainButton.TabIndex = 0;
            mainButton.Text = "Klick mich!";
            mainButton.UseVisualStyleBackColor = true;
            mainButton.Click += mainButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(12, 600);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 21);
            outputLabel.TabIndex = 1;
            // 
            // eventHandlerAnfügenButton
            // 
            eventHandlerAnfügenButton.Location = new Point(13, 89);
            eventHandlerAnfügenButton.Name = "eventHandlerAnfügenButton";
            eventHandlerAnfügenButton.Size = new Size(1005, 45);
            eventHandlerAnfügenButton.TabIndex = 2;
            eventHandlerAnfügenButton.Text = "EventHandler anfügen";
            eventHandlerAnfügenButton.UseVisualStyleBackColor = true;
            eventHandlerAnfügenButton.Click += eventHandlerAnfügenButton_Click;
            // 
            // eventHandlerLösenButton
            // 
            eventHandlerLösenButton.Location = new Point(13, 149);
            eventHandlerLösenButton.Name = "eventHandlerLösenButton";
            eventHandlerLösenButton.Size = new Size(1005, 45);
            eventHandlerLösenButton.TabIndex = 3;
            eventHandlerLösenButton.Text = "EventHandler lösen";
            eventHandlerLösenButton.UseVisualStyleBackColor = true;
            eventHandlerLösenButton.Click += eventHandlerLösenButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(abteilungLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(abteilungComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 372);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Custom Events";
            // 
            // abteilungComboBox
            // 
            abteilungComboBox.FormattingEnabled = true;
            abteilungComboBox.Location = new Point(265, 22);
            abteilungComboBox.Name = "abteilungComboBox";
            abteilungComboBox.Size = new Size(121, 29);
            abteilungComboBox.TabIndex = 1;
            abteilungComboBox.SelectedIndexChanged += abteilungComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(253, 21);
            label1.TabIndex = 0;
            label1.Text = "Abteilung für Mitarbeiter zuweisen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 25);
            label2.Name = "label2";
            label2.Size = new Size(175, 21);
            label2.TabIndex = 2;
            label2.Text = "Zugewiesene Abteilung:";
            // 
            // abteilungLabel
            // 
            abteilungLabel.AutoSize = true;
            abteilungLabel.Location = new Point(653, 25);
            abteilungLabel.Name = "abteilungLabel";
            abteilungLabel.Size = new Size(0, 21);
            abteilungLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(groupBox1);
            Controls.Add(eventHandlerLösenButton);
            Controls.Add(eventHandlerAnfügenButton);
            Controls.Add(outputLabel);
            Controls.Add(mainButton);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Personalverwaltung [NewElements]";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mainButton;
        private Label outputLabel;
        private Button eventHandlerAnfügenButton;
        private Button eventHandlerLösenButton;
        private GroupBox groupBox1;
        private ComboBox abteilungComboBox;
        private Label label1;
        private Label abteilungLabel;
        private Label label2;
    }
}
